using BatchTranslatorAddIn.Utils.Config;
using Microsoft.Office.Tools.Ribbon;
using BatchTranslatorAddIn.Utils.Common;
using System;
using BatchTranslatorAddIn.Utils.Excel;

namespace BatchTranslatorAddIn.Views
{
    public partial class MainRibbon
    {
        readonly static Config config = Config.Instance;

        private void MainRibbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void MainRibbon_Close(object sender, System.EventArgs e)
        {
            config.Save();
        }

        private void TranslationStart_Click(object sender, RibbonControlEventArgs e)
        {
            ProgressForm progressForm = new ProgressForm(Operations.GetSelectedRect());
            progressForm.ShowDialog();
        }

        private void EngineDrowDown_SelectionChanged(object sender, RibbonControlEventArgs e)
        {
            var control = sender as RibbonDropDown;
            var rawData = control.SelectedItem.SuperTip;
            config.TransEngine = (TransEngine)Enum.Parse(typeof(TransEngine), rawData);
        }

        private void LanguageDrowDown_SelectionChanged(object sender, RibbonControlEventArgs e)
        {
            var control = sender as RibbonDropDown;
            var rawData = control.SelectedItem.SuperTip.Split('2');
            var from = rawData[0];
            var to = rawData[1];
            config.From = (Language)Enum.Parse(typeof(Language), from);
            config.To = (Language)Enum.Parse(typeof(Language), to);
        }

        private void DirectionDrawDown_SelectionChanged(object sender, RibbonControlEventArgs e)
        {
            var control = sender as RibbonDropDown;
            var rawData = control.SelectedItem.SuperTip;
            config.GenerateDirection = (Direction)Enum.Parse(typeof(Direction), rawData);
        }

        private void DialogLauncher_Click(object sender, RibbonControlEventArgs e)
        {
            ConfigForm configForm = new ConfigForm();
            configForm.ShowDialog();
        }
    }
}
