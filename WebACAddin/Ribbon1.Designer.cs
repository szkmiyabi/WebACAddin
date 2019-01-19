namespace WebACAddin
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary>
        /// デザイナーのサポートに必要なメソッドです。
        /// このメソッドの内容をコード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.webACTab = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.cellValText = this.Factory.CreateRibbonEditBox();
            this.cellColorCodeBtn = this.Factory.CreateRibbonButton();
            this.globalAlertOKNGRadio = this.Factory.CreateRibbonCheckBox();
            this.separator1 = this.Factory.CreateRibbonSeparator();
            this.thisListMatchBtn = this.Factory.CreateRibbonButton();
            this.thisColorCodeBtn = this.Factory.CreateRibbonButton();
            this.listReverseButton = this.Factory.CreateRibbonButton();
            this.waCheckCommentBaseButton = this.Factory.CreateRibbonButton();
            this.dispEasyHtmlDocButton = this.Factory.CreateRibbonButton();
            this.separator2 = this.Factory.CreateRibbonSeparator();
            this.groupLabelWithColorRadio = this.Factory.CreateRibbonCheckBox();
            this.groupLabelAddButton = this.Factory.CreateRibbonButton();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.setHrefBtn = this.Factory.CreateRibbonButton();
            this.setPageTitleBtn = this.Factory.CreateRibbonButton();
            this.saveAsTSVButton = this.Factory.CreateRibbonButton();
            this.group3 = this.Factory.CreateRibbonGroup();
            this.openIEButton = this.Factory.CreateRibbonButton();
            this.openFirefoxButton = this.Factory.CreateRibbonButton();
            this.openChromeButton = this.Factory.CreateRibbonButton();
            this.openFirefoxDevButton = this.Factory.CreateRibbonButton();
            this.openChromeBetaButton = this.Factory.CreateRibbonButton();
            this.webACTab.SuspendLayout();
            this.group1.SuspendLayout();
            this.group2.SuspendLayout();
            this.group3.SuspendLayout();
            this.SuspendLayout();
            // 
            // webACTab
            // 
            this.webACTab.Groups.Add(this.group1);
            this.webACTab.Groups.Add(this.group2);
            this.webACTab.Groups.Add(this.group3);
            this.webACTab.Label = "WebAcc";
            this.webACTab.Name = "webACTab";
            // 
            // group1
            // 
            this.group1.Items.Add(this.cellValText);
            this.group1.Items.Add(this.cellColorCodeBtn);
            this.group1.Items.Add(this.globalAlertOKNGRadio);
            this.group1.Items.Add(this.separator1);
            this.group1.Items.Add(this.thisListMatchBtn);
            this.group1.Items.Add(this.thisColorCodeBtn);
            this.group1.Items.Add(this.listReverseButton);
            this.group1.Items.Add(this.waCheckCommentBaseButton);
            this.group1.Items.Add(this.dispEasyHtmlDocButton);
            this.group1.Items.Add(this.separator2);
            this.group1.Items.Add(this.groupLabelWithColorRadio);
            this.group1.Items.Add(this.groupLabelAddButton);
            this.group1.Label = "セル解析";
            this.group1.Name = "group1";
            // 
            // cellValText
            // 
            this.cellValText.Label = "editBox1";
            this.cellValText.MaxLength = 6;
            this.cellValText.Name = "cellValText";
            this.cellValText.ShowLabel = false;
            this.cellValText.SizeString = "AAAAAA";
            this.cellValText.Text = null;
            // 
            // cellColorCodeBtn
            // 
            this.cellColorCodeBtn.Label = "色コード";
            this.cellColorCodeBtn.Name = "cellColorCodeBtn";
            this.cellColorCodeBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cellColorCodeBtn_Click);
            // 
            // globalAlertOKNGRadio
            // 
            this.globalAlertOKNGRadio.Label = "確認非表示";
            this.globalAlertOKNGRadio.Name = "globalAlertOKNGRadio";
            // 
            // separator1
            // 
            this.separator1.Name = "separator1";
            // 
            // thisListMatchBtn
            // 
            this.thisListMatchBtn.Label = "リスト一致";
            this.thisListMatchBtn.Name = "thisListMatchBtn";
            this.thisListMatchBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.thisListMatchBtn_Click);
            // 
            // thisColorCodeBtn
            // 
            this.thisColorCodeBtn.Label = "この色のセル";
            this.thisColorCodeBtn.Name = "thisColorCodeBtn";
            this.thisColorCodeBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.thisColorCodeBtn_Click);
            // 
            // listReverseButton
            // 
            this.listReverseButton.Label = "リスト反転";
            this.listReverseButton.Name = "listReverseButton";
            this.listReverseButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.listReverseButton_Click);
            // 
            // waCheckCommentBaseButton
            // 
            this.waCheckCommentBaseButton.Label = "品質チェックコメント";
            this.waCheckCommentBaseButton.Name = "waCheckCommentBaseButton";
            this.waCheckCommentBaseButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.waCheckCommentBaseButton_Click);
            // 
            // dispEasyHtmlDocButton
            // 
            this.dispEasyHtmlDocButton.Label = "html簡易表示";
            this.dispEasyHtmlDocButton.Name = "dispEasyHtmlDocButton";
            this.dispEasyHtmlDocButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.dispEasyHtmlDocButton_Click);
            // 
            // separator2
            // 
            this.separator2.Name = "separator2";
            // 
            // groupLabelWithColorRadio
            // 
            this.groupLabelWithColorRadio.Label = "自動色付";
            this.groupLabelWithColorRadio.Name = "groupLabelWithColorRadio";
            // 
            // groupLabelAddButton
            // 
            this.groupLabelAddButton.Label = "グループ名入力";
            this.groupLabelAddButton.Name = "groupLabelAddButton";
            this.groupLabelAddButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.groupLabelAddButton_Click);
            // 
            // group2
            // 
            this.group2.Items.Add(this.setHrefBtn);
            this.group2.Items.Add(this.setPageTitleBtn);
            this.group2.Items.Add(this.saveAsTSVButton);
            this.group2.Label = "URL処理";
            this.group2.Name = "group2";
            // 
            // setHrefBtn
            // 
            this.setHrefBtn.Label = "href設定";
            this.setHrefBtn.Name = "setHrefBtn";
            this.setHrefBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.setHrefBtn_Click);
            // 
            // setPageTitleBtn
            // 
            this.setPageTitleBtn.Label = "title設定";
            this.setPageTitleBtn.Name = "setPageTitleBtn";
            this.setPageTitleBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.setPageTitleBtn_Click);
            // 
            // saveAsTSVButton
            // 
            this.saveAsTSVButton.Label = "TSV保存";
            this.saveAsTSVButton.Name = "saveAsTSVButton";
            this.saveAsTSVButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.saveAsTSVButton_Click);
            // 
            // group3
            // 
            this.group3.Items.Add(this.openIEButton);
            this.group3.Items.Add(this.openFirefoxButton);
            this.group3.Items.Add(this.openChromeButton);
            this.group3.Items.Add(this.openFirefoxDevButton);
            this.group3.Items.Add(this.openChromeBetaButton);
            this.group3.Label = "ブラウズ";
            this.group3.Name = "group3";
            // 
            // openIEButton
            // 
            this.openIEButton.Label = "IE";
            this.openIEButton.Name = "openIEButton";
            this.openIEButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.openIEButton_Click);
            // 
            // openFirefoxButton
            // 
            this.openFirefoxButton.Label = "Firefox";
            this.openFirefoxButton.Name = "openFirefoxButton";
            this.openFirefoxButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.openFirefoxButton_Click);
            // 
            // openChromeButton
            // 
            this.openChromeButton.Label = "Chrome";
            this.openChromeButton.Name = "openChromeButton";
            this.openChromeButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.openChromeButton_Click);
            // 
            // openFirefoxDevButton
            // 
            this.openFirefoxDevButton.Label = "Firefox(dev)";
            this.openFirefoxDevButton.Name = "openFirefoxDevButton";
            this.openFirefoxDevButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.openFirefoxDevButton_Click);
            // 
            // openChromeBetaButton
            // 
            this.openChromeBetaButton.Label = "Chrome(beta)";
            this.openChromeBetaButton.Name = "openChromeBetaButton";
            this.openChromeBetaButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.openChromeBetaButton_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.webACTab);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.webACTab.ResumeLayout(false);
            this.webACTab.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.group3.ResumeLayout(false);
            this.group3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab webACTab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox cellValText;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton cellColorCodeBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton thisColorCodeBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton thisListMatchBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton setHrefBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton setPageTitleBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton listReverseButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton saveAsTSVButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group3;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton openIEButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton openFirefoxButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton openChromeButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton openFirefoxDevButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton openChromeBetaButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton waCheckCommentBaseButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton groupLabelAddButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator2;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox groupLabelWithColorRadio;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox globalAlertOKNGRadio;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton dispEasyHtmlDocButton;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
