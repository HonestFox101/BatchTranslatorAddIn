using BatchTranslatorAddIn.Library.Worker;
using BatchTranslatorAddIn.Utils.Excel;
using System;
using System.Windows.Forms;

namespace BatchTranslatorAddIn.Views
{
    public partial class ProgressForm : Form
    {
        private readonly RangeRect selectedRect;
        private readonly TranslationWorker translationWorker;

        public ProgressForm(RangeRect selectedRect)
        {
            this.selectedRect = selectedRect;
            translationWorker = new TranslationWorker();
            InitializeComponent();
        }

        private void ProgressForm_Load(object sender, EventArgs e)
        {
            CompleteButton.Enabled = false;
            CancelButton.Enabled = true;

            ProgressBar.Maximum = 100;
            ProgressBar.Value = 0;

            LogBox.Text = $"选中{selectedRect.Width}x{selectedRect.Height}条数据\n";

            translationWorker.onProgressUpdated = (percentage, translationItem) =>
            {
                ProgressBar.Value = percentage;
                LogBox.Text += $"{translationItem.address}: {translationItem.src} -> ${translationItem.dst}";
            };
            translationWorker.onWorkCompleted = (isCancelled) =>
            {
                ProgressBar.Value = 100;
                LogBox.Text += isCancelled ? "翻译失败...\n" : "全部翻译完成！\n";
                CompleteButton.Enabled = true;
                CancelButton.Enabled = false;
            };
            translationWorker.Start();
        }

        private void CompleteButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            translationWorker.Cancel();
            CancelButton.Enabled = false;
            CompleteButton.Enabled = true;
        }
    }
}
