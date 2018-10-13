﻿namespace WebACAddin
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
            this.cellColorCodeBtn = this.Factory.CreateRibbonButton();
            this.cellValText = this.Factory.CreateRibbonEditBox();
            this.thisColorCodeBtn = this.Factory.CreateRibbonButton();
            this.thisListMatchBtn = this.Factory.CreateRibbonButton();
            this.setHrefBtn = this.Factory.CreateRibbonButton();
            this.setPageTitleBtn = this.Factory.CreateRibbonButton();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.separator1 = this.Factory.CreateRibbonSeparator();
            this.listReverseButton = this.Factory.CreateRibbonButton();
            this.saveAsTSVButton = this.Factory.CreateRibbonButton();
            this.webACTab.SuspendLayout();
            this.group1.SuspendLayout();
            this.group2.SuspendLayout();
            this.SuspendLayout();
            // 
            // webACTab
            // 
            this.webACTab.Groups.Add(this.group1);
            this.webACTab.Groups.Add(this.group2);
            this.webACTab.Label = "WebAcc";
            this.webACTab.Name = "webACTab";
            // 
            // group1
            // 
            this.group1.Items.Add(this.cellValText);
            this.group1.Items.Add(this.cellColorCodeBtn);
            this.group1.Items.Add(this.separator1);
            this.group1.Items.Add(this.thisListMatchBtn);
            this.group1.Items.Add(this.thisColorCodeBtn);
            this.group1.Items.Add(this.listReverseButton);
            this.group1.Label = "セル解析";
            this.group1.Name = "group1";
            // 
            // cellColorCodeBtn
            // 
            this.cellColorCodeBtn.Label = "色コード";
            this.cellColorCodeBtn.Name = "cellColorCodeBtn";
            this.cellColorCodeBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cellColorCodeBtn_Click);
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
            // thisColorCodeBtn
            // 
            this.thisColorCodeBtn.Label = "この色のセル";
            this.thisColorCodeBtn.Name = "thisColorCodeBtn";
            this.thisColorCodeBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.thisColorCodeBtn_Click);
            // 
            // thisListMatchBtn
            // 
            this.thisListMatchBtn.Label = "リスト一致";
            this.thisListMatchBtn.Name = "thisListMatchBtn";
            this.thisListMatchBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.thisListMatchBtn_Click);
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
            // group2
            // 
            this.group2.Items.Add(this.setHrefBtn);
            this.group2.Items.Add(this.setPageTitleBtn);
            this.group2.Items.Add(this.saveAsTSVButton);
            this.group2.Label = "URL処理";
            this.group2.Name = "group2";
            // 
            // separator1
            // 
            this.separator1.Name = "separator1";
            // 
            // listReverseButton
            // 
            this.listReverseButton.Label = "リスト反転";
            this.listReverseButton.Name = "listReverseButton";
            this.listReverseButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.listReverseButton_Click);
            // 
            // saveAsTSVButton
            // 
            this.saveAsTSVButton.Label = "TSV保存";
            this.saveAsTSVButton.Name = "saveAsTSVButton";
            this.saveAsTSVButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.saveAsTSVButton_Click);
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
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
