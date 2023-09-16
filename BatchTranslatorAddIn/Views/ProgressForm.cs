using BatchTranslatorAddIn.Utils.Config;
using BatchTranslatorAddIn.Utils.Excel;
using BatchTranslatorAddIn.Utils.Common;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using BatchTranslatorAddIn.Utils.Translator;

namespace BatchTranslatorAddIn.Views
{
    public partial class ProgressForm : Form
    {
        private readonly static Config config = Config.Instance;

        private readonly RangeRect selectedRect;

        private readonly ITranslator translator;

        private int completeCount;
        private int totalCount;

        public ProgressForm(RangeRect selectedRect)
        {
            this.selectedRect = selectedRect;
            switch (config.TransEngine)
            {
                case (TransEngine.Caiyun):translator = TranslatorFactory.CreateCaiyunTranslator(); break;
                default:
                case (TransEngine.Baidu): translator = TranslatorFactory.CreateBaiduTranslator(); break;
            }
            InitializeComponent();
        }

        private void ProgressForm_Load(object sender, EventArgs e)
        {
            CompleteButton.Enabled = false;
            CancelButton.Enabled = true;

            ProgressBar.Maximum = 100;
            ProgressBar.Value = 0;

            completeCount = 0;
            totalCount = selectedRect.Count;
            LogBox.Text = $"选中{selectedRect.Width}x{selectedRect.Height}条数据\n";

            BackgroundTranslator.RunWorkerAsync();
        }

        private void BackgroundTranslator_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            // Do Translation Work
            BackgroundWorker worker = sender as BackgroundWorker;

            switch (config.GenerateDirection)
            {
                case (Direction.Right):
                    {
                        foreach (var column in selectedRect.Columns)
                        {
                            string[] resultArr = new string[column.Height];
                            // Translate
                            for (var j = 0; j < column.Height; j++)
                            {
                                if (worker.CancellationPending)
                                {
                                    e.Cancel = true;
                                    break;
                                }

                                resultArr[j] = DoTranslateByRangePosition(worker, column, 0, j);
                            }
                            // Add new column
                            column.InsertColumnToRight();
                            // Paste translated result to it
                            var insertedColumn = column.Offset(1, 0);
                            for (var j = 0; j < column.Height; j++)
                            {
                                insertedColumn[0, j].Value = resultArr[j];
                            }
                        }
                        break;
                    }
                case (Direction.Down):
                    {
                        foreach (var row in selectedRect.Rows)
                        {
                            string[] resultArr = new string[row.Width];
                            // Translate
                            for (var i = 0; i < row.Width; i++)
                            {
                                if (worker.CancellationPending)
                                {
                                    e.Cancel = true;
                                    break;
                                }

                                resultArr[i] = DoTranslateByRangePosition(worker, row, i, 0);
                            }
                            // Add new Row
                            row.InsertRowToBottom();
                            // Paste translated result to it
                            var insertedRow = row.Offset(0, 1);
                            for (var i = 0; i < row.Width; i++)
                            {
                                insertedRow[i, 0].Value = resultArr[i];
                            }
                        }
                        break;
                    }
                default: break;
            }
        }

        private void BackgroundTranslator_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int precentage = e.ProgressPercentage;
            string logContent = (string)e.UserState;
            ProgressBar.Value = precentage;
            LogBox.Text += logContent + "\n";
        }

        private void BackgroundTranslator_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            LogBox.Text += e.Cancelled ? "失败..." : "全部完成！";

            CancelButton.Enabled = false;
            CompleteButton.Enabled = true;
        }

        private string DoTranslateByRangePosition(BackgroundWorker worker, RangeRect rangeRect, int posX, int posY)
        {
            string result;
            string rawContent = rangeRect[posX, posY].Value;
            if (rawContent == null)
            {
                worker.ReportProgress(
                    completeCount * 100 / totalCount,
                    "翻译失败：选中内容有空");
                worker.CancelAsync();
                return "null";
            }
            else if (translator.TryTranslate(rawContent, out result))
            {
                completeCount++;
                worker.ReportProgress(
                    completeCount * 100 / totalCount,
                    $"{rawContent} -> {result}");
            }
            else
            {
                worker.ReportProgress(
                    completeCount * 100 / totalCount,
                    $"翻译失败：{result}");
                worker.CancelAsync();
            }
            return result;
        }



        private void CompleteButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            var worker = BackgroundTranslator;
            if (worker.IsBusy && worker.WorkerSupportsCancellation)
            {
                worker.CancelAsync();
            }
            CancelButton.Enabled = false;
            CompleteButton.Enabled = true;
        }
    }
}
