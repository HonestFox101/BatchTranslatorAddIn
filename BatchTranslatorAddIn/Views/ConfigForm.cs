using BatchTranslatorAddIn.Utils.Config;
using BatchTranslatorAddIn.Utils.Translator;
using System;
using System.Windows.Forms;

namespace BatchTranslatorAddIn.Views
{
    public partial class ConfigForm : Form
    {
        private readonly static Config config = Config.Instance;

        public ConfigForm()
        {
            InitializeComponent();
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            LoadConfig();
            SaveButton.Enabled = false;
        }

        private void ConfigForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveConfig();
        }

        private void LoadConfig()
        {
            var baiduProperty = config.BaiduProperty;
            BaiduAppIDTextBox.Text = baiduProperty.AppID;
            BaiduSecretTextBox.Text = baiduProperty.Secret;
            BaiduQPSNumericUpDown.Value = baiduProperty.QPS;

            var caiyunProperty = config.CaiyunProperty;
            CaiyunTokenTextBox.Text = caiyunProperty.Token;
            CaiyunQPSNumericUpDown.Value = caiyunProperty.QPS;
        }

        private void SaveConfig()
        {
            var baiduProperty = config.BaiduProperty;
            baiduProperty.AppID = BaiduAppIDTextBox.Text;
            baiduProperty.Secret = BaiduSecretTextBox.Text;
            baiduProperty.QPS = (int)BaiduQPSNumericUpDown.Value;
            config.BaiduProperty = baiduProperty;

            var caiyunProperty = config.CaiyunProperty;
            caiyunProperty.Token = CaiyunTokenTextBox.Text;
            caiyunProperty.QPS = (int)CaiyunQPSNumericUpDown.Value;
            config.CaiyunProperty = caiyunProperty;
            config.Save();
        }

        private void BaiduTestBotton_Click(object sender, EventArgs e)
        {
            var content = "Apple";
            var translator = TranslatorFactory.CreateBaiduTranslator();
            var result = translator.TryTranslate(content, out _);
            BaiduTestBotton.Text = result ? "成功" : "失败";
        }

        private void CaiyunTestBotton_Click(object sender, EventArgs e)
        {
            var content = "Apple";
            var translator = TranslatorFactory.CreateCaiyunTranslator();
            var result = translator.TryTranslate(content, out _);
            CaiyunTestBotton.Text = result ? "成功" : "失败";
        }

        private void BaiduAppIDTextBox_TextChanged(object sender, EventArgs e)
        {
            SaveButton.Enabled = true;
        }

        private void BaiduSecretTextBox_TextChanged(object sender, EventArgs e)
        {
            SaveButton.Enabled = true;
        }

        private void CaiyunTokenTextBox_TextChanged(object sender, EventArgs e)
        {
            SaveButton.Enabled = true;
        }

        private void BaiduQPSNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            SaveButton.Enabled = true;
        }

        private void CaiyunQPSNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            SaveButton.Enabled = true;
        }
    }
}
