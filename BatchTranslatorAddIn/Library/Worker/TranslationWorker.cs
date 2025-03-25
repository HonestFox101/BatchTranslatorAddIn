using System;
using System.ComponentModel;
using BatchTranslatorAddIn.Utils.Common;
using BatchTranslatorAddIn.Utils.Config;
using BatchTranslatorAddIn.Utils.Excel;
using BatchTranslatorAddIn.Utils.Translator;

namespace BatchTranslatorAddIn.Library.Worker
{
    public class TranslationWorker
    {
        private readonly BackgroundWorker _worker;
        private readonly Config _config = Config.Instance;
        private readonly RangeRect _selectedRect;
        private readonly ITranslator _translator;
        private int _completeCount = 0;
        private readonly int _totalCount;

        public TranslationWorker()
        {
            _selectedRect = Operations.GetSelectedRect();
            switch (_config.TransEngine)
            {
                case TransEngine.Caiyun:
                    _translator = TranslatorFactory.CreateCaiyunTranslator();
                    break;
                default:
                case TransEngine.Baidu:
                    _translator = TranslatorFactory.CreateBaiduTranslator();
                    break;
            }
            _totalCount = _selectedRect.Count;

            _worker = new BackgroundWorker() { WorkerReportsProgress = true, WorkerSupportsCancellation = true };
            _worker.DoWork += (sender, e) => { DoWork(e); };
            _worker.ProgressChanged += (sender, e) => { ProgressChanged(e); };
            _worker.RunWorkerCompleted += (sender, e) => { RunWorkerCompleted(e); };
        }

        private void DoWork(DoWorkEventArgs e)
        {
            switch (_config.GenerateDirection)
            {
                case Direction.Right:
                    foreach (var column in _selectedRect.Columns)
                    {
                        string[] resultArr = new string[column.Height];
                        for (var j = 0; j < column.Height; j++)
                        {
                            if (_worker.CancellationPending)
                            {
                                e.Cancel = true;
                                break;
                            }
                            resultArr[j] = DoTranslateByRangePosition(column, 0, j);
                        }
                        column.InsertColumnToRight();
                        var insertedColumn = column.Offset(1, 0);
                        for (var j = 0; j < column.Height; j++)
                        {
                            insertedColumn[0, j].Value = resultArr[j];
                        }
                    }
                    break;
                case Direction.Down:
                    foreach (var row in _selectedRect.Rows)
                    {
                        string[] resultArr = new string[row.Width];
                        for (var i = 0; i < row.Width; i++)
                        {
                            if (_worker.CancellationPending)
                            {
                                e.Cancel = true;
                                break;
                            }
                            resultArr[i] = DoTranslateByRangePosition(row, i, 0);
                        }
                        row.InsertRowToBottom();
                        var insertedRow = row.Offset(0, 1);
                        for (var i = 0; i < row.Width; i++)
                        {
                            insertedRow[i, 0].Value = resultArr[i];
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        private void ProgressChanged(ProgressChangedEventArgs e)
        {
            var precentage = e.ProgressPercentage;
            var state = e.UserState as (string, string, string)?;
            if (state.HasValue)
            {
                onProgressUpdated?.Invoke(precentage, (address: state.Value.Item1, src: state.Value.Item2, dst: state.Value.Item3));
            }
            else
            {
                Cancel();
            }
        }

        private void RunWorkerCompleted(RunWorkerCompletedEventArgs e)
        {
            onWorkCompleted?.Invoke(e.Cancelled);
        }

        private string DoTranslateByRangePosition(RangeRect rangeRect, int posX, int posY)
        {
            var rawContent = rangeRect[posX, posY].Value;
            if (rawContent == null)
            {
                _worker.ReportProgress(_completeCount * 100 / _totalCount, null);
                _worker.CancelAsync();
                return "";
            }
            if (_translator.TryTranslate(rawContent, out string result))
            {
                _completeCount++;
                _worker.ReportProgress(_completeCount * 100 / _totalCount, (rangeRect.Address, rawContent, result));
                return result;
            }
            else
            {
                _worker.ReportProgress(_completeCount * 100 / _totalCount, null);
                _worker.CancelAsync();
                return "";
            }
        }

        public void Start()
        {
            _worker.RunWorkerAsync();
        }

        public bool Cancel()
        {
            if (_worker.IsBusy && _worker.WorkerSupportsCancellation)
            {
                _worker.CancelAsync();
                return true;
            }
            return false;
        }

        public Action<int, (string address, string src, string dst)> onProgressUpdated;

        public Action<bool> onWorkCompleted;
    }
}
