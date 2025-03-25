namespace BatchTranslatorAddIn.Views
{
    partial class MainRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public MainRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Office.Tools.Ribbon.RibbonDialogLauncher ribbonDialogLauncherImpl1 = this.Factory.CreateRibbonDialogLauncher();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl1 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl2 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl3 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl4 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl5 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl6 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl7 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl8 = this.Factory.CreateRibbonDropDownItem();
            this.tab1 = this.Factory.CreateRibbonTab();
            this.TranslatorAddInGroup = this.Factory.CreateRibbonGroup();
            this.TranslationStart = this.Factory.CreateRibbonButton();
            this.separator1 = this.Factory.CreateRibbonSeparator();
            this.EngineDrowDown = this.Factory.CreateRibbonDropDown();
            this.LanguageDrowDown = this.Factory.CreateRibbonDropDown();
            this.DirectionDrawDown = this.Factory.CreateRibbonDropDown();
            this.tab1.SuspendLayout();
            this.TranslatorAddInGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.TranslatorAddInGroup);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // TranslatorAddInGroup
            // 
            this.TranslatorAddInGroup.DialogLauncher = ribbonDialogLauncherImpl1;
            this.TranslatorAddInGroup.Items.Add(this.TranslationStart);
            this.TranslatorAddInGroup.Items.Add(this.separator1);
            this.TranslatorAddInGroup.Items.Add(this.EngineDrowDown);
            this.TranslatorAddInGroup.Items.Add(this.LanguageDrowDown);
            this.TranslatorAddInGroup.Items.Add(this.DirectionDrawDown);
            this.TranslatorAddInGroup.Label = "批量翻译";
            this.TranslatorAddInGroup.Name = "TranslatorAddInGroup";
            this.TranslatorAddInGroup.DialogLauncherClick += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.DialogLauncher_Click);
            // 
            // TranslationStart
            // 
            this.TranslationStart.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.TranslationStart.Image = global::BatchTranslatorAddIn.Properties.Resources.globe_solid;
            this.TranslationStart.Label = "开始翻译";
            this.TranslationStart.Name = "TranslationStart";
            this.TranslationStart.ShowImage = true;
            this.TranslationStart.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.TranslationStart_Click);
            // 
            // separator1
            // 
            this.separator1.Name = "separator1";
            // 
            // EngineDrowDown
            // 
            ribbonDropDownItemImpl1.Label = "百度翻译";
            ribbonDropDownItemImpl1.SuperTip = "Baidu";
            ribbonDropDownItemImpl1.Tag = "";
            ribbonDropDownItemImpl2.Label = "彩云小译";
            ribbonDropDownItemImpl2.SuperTip = "Caiyun";
            this.EngineDrowDown.Items.Add(ribbonDropDownItemImpl1);
            this.EngineDrowDown.Items.Add(ribbonDropDownItemImpl2);
            this.EngineDrowDown.Label = "翻译引擎：";
            this.EngineDrowDown.Name = "EngineDrowDown";
            this.EngineDrowDown.SelectionChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.EngineDrowDown_SelectionChanged);
            // 
            // LanguageDrowDown
            // 
            ribbonDropDownItemImpl3.Label = "日转中";
            ribbonDropDownItemImpl3.SuperTip = "JP2CN";
            ribbonDropDownItemImpl4.Label = "英转中";
            ribbonDropDownItemImpl4.SuperTip = "EN2CN";
            ribbonDropDownItemImpl5.Label = "中转日";
            ribbonDropDownItemImpl5.SuperTip = "CN2JP";
            ribbonDropDownItemImpl6.Label = "中转英";
            ribbonDropDownItemImpl6.SuperTip = "CN2EN";
            this.LanguageDrowDown.Items.Add(ribbonDropDownItemImpl3);
            this.LanguageDrowDown.Items.Add(ribbonDropDownItemImpl4);
            this.LanguageDrowDown.Items.Add(ribbonDropDownItemImpl5);
            this.LanguageDrowDown.Items.Add(ribbonDropDownItemImpl6);
            this.LanguageDrowDown.Label = "语言选择：";
            this.LanguageDrowDown.Name = "LanguageDrowDown";
            this.LanguageDrowDown.SelectionChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.LanguageDrowDown_SelectionChanged);
            // 
            // DirectionDrawDown
            // 
            ribbonDropDownItemImpl7.Label = "向右";
            ribbonDropDownItemImpl7.SuperTip = "Right";
            ribbonDropDownItemImpl8.Label = "向下";
            ribbonDropDownItemImpl8.SuperTip = "Down";
            this.DirectionDrawDown.Items.Add(ribbonDropDownItemImpl7);
            this.DirectionDrawDown.Items.Add(ribbonDropDownItemImpl8);
            this.DirectionDrawDown.Label = "插入方向：";
            this.DirectionDrawDown.Name = "DirectionDrawDown";
            this.DirectionDrawDown.SelectionChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.DirectionDrawDown_SelectionChanged);
            // 
            // MainRibbon
            // 
            this.Name = "MainRibbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Close += new System.EventHandler(this.MainRibbon_Close);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.MainRibbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.TranslatorAddInGroup.ResumeLayout(false);
            this.TranslatorAddInGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup TranslatorAddInGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton TranslationStart;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown EngineDrowDown;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown LanguageDrowDown;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown DirectionDrawDown;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator1;
    }
}
