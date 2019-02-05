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
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl1 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl2 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl3 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl4 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl5 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl6 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl7 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl8 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl9 = this.Factory.CreateRibbonDropDownItem();
            this.webACTab = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.box4 = this.Factory.CreateRibbonBox();
            this.cellValText = this.Factory.CreateRibbonEditBox();
            this.cellColorCodeBtn = this.Factory.CreateRibbonButton();
            this.globalAlertOKNGRadio = this.Factory.CreateRibbonCheckBox();
            this.separator1 = this.Factory.CreateRibbonSeparator();
            this.thisListMatchBtn = this.Factory.CreateRibbonButton();
            this.thisColorCodeBtn = this.Factory.CreateRibbonButton();
            this.listReverseButton = this.Factory.CreateRibbonButton();
            this.waCheckCommentBaseButton = this.Factory.CreateRibbonButton();
            this.dispEasyHtmlDocButton = this.Factory.CreateRibbonButton();
            this.dispContrastRepFormButton = this.Factory.CreateRibbonButton();
            this.group4 = this.Factory.CreateRibbonGroup();
            this.box3 = this.Factory.CreateRibbonBox();
            this.svRedimFlagCombo = this.Factory.CreateRibbonComboBox();
            this.svRedimInputButton = this.Factory.CreateRibbonButton();
            this.box1 = this.Factory.CreateRibbonBox();
            this.writeCommentBreakCheck = this.Factory.CreateRibbonCheckBox();
            this.writeCommentOverrideCheck = this.Factory.CreateRibbonCheckBox();
            this.addLabelColorCheck = this.Factory.CreateRibbonCheckBox();
            this.box5 = this.Factory.CreateRibbonBox();
            this.writeCommentCombo = this.Factory.CreateRibbonComboBox();
            this.writeCommentInputButton = this.Factory.CreateRibbonButton();
            this.box6 = this.Factory.CreateRibbonBox();
            this.writeCommentAddButton = this.Factory.CreateRibbonButton();
            this.writeCommentAddFromFileButton = this.Factory.CreateRibbonButton();
            this.box2 = this.Factory.CreateRibbonBox();
            this.delCommentSingleButton = this.Factory.CreateRibbonButton();
            this.delCommentAllButton = this.Factory.CreateRibbonButton();
            this.addCommentPreClearCheck = this.Factory.CreateRibbonCheckBox();
            this.groupLabelAddButton = this.Factory.CreateRibbonButton();
            this.markerInputButton = this.Factory.CreateRibbonButton();
            this.writeFormOpenButton = this.Factory.CreateRibbonButton();
            this.group5 = this.Factory.CreateRibbonGroup();
            this.documentEditButton = this.Factory.CreateRibbonButton();
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
            this.box4.SuspendLayout();
            this.group4.SuspendLayout();
            this.box3.SuspendLayout();
            this.box1.SuspendLayout();
            this.box5.SuspendLayout();
            this.box6.SuspendLayout();
            this.box2.SuspendLayout();
            this.group5.SuspendLayout();
            this.group2.SuspendLayout();
            this.group3.SuspendLayout();
            this.SuspendLayout();
            // 
            // webACTab
            // 
            this.webACTab.Groups.Add(this.group1);
            this.webACTab.Groups.Add(this.group4);
            this.webACTab.Groups.Add(this.group5);
            this.webACTab.Groups.Add(this.group2);
            this.webACTab.Groups.Add(this.group3);
            this.webACTab.Label = "WEB_ACC";
            this.webACTab.Name = "webACTab";
            // 
            // group1
            // 
            this.group1.Items.Add(this.box4);
            this.group1.Items.Add(this.globalAlertOKNGRadio);
            this.group1.Items.Add(this.separator1);
            this.group1.Items.Add(this.thisListMatchBtn);
            this.group1.Items.Add(this.thisColorCodeBtn);
            this.group1.Items.Add(this.listReverseButton);
            this.group1.Items.Add(this.waCheckCommentBaseButton);
            this.group1.Items.Add(this.dispEasyHtmlDocButton);
            this.group1.Items.Add(this.dispContrastRepFormButton);
            this.group1.Label = "セル解析";
            this.group1.Name = "group1";
            // 
            // box4
            // 
            this.box4.Items.Add(this.cellValText);
            this.box4.Items.Add(this.cellColorCodeBtn);
            this.box4.Name = "box4";
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
            this.dispEasyHtmlDocButton.Label = "簡易HTML表示";
            this.dispEasyHtmlDocButton.Name = "dispEasyHtmlDocButton";
            this.dispEasyHtmlDocButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.dispEasyHtmlDocButton_Click);
            // 
            // dispContrastRepFormButton
            // 
            this.dispContrastRepFormButton.Label = "コントラスト結果";
            this.dispContrastRepFormButton.Name = "dispContrastRepFormButton";
            this.dispContrastRepFormButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.dispContrastRepFormButton_Click);
            // 
            // group4
            // 
            this.group4.Items.Add(this.box3);
            this.group4.Items.Add(this.box1);
            this.group4.Items.Add(this.addLabelColorCheck);
            this.group4.Items.Add(this.box5);
            this.group4.Items.Add(this.box6);
            this.group4.Items.Add(this.box2);
            this.group4.Items.Add(this.groupLabelAddButton);
            this.group4.Items.Add(this.markerInputButton);
            this.group4.Items.Add(this.writeFormOpenButton);
            this.group4.Label = "表編集";
            this.group4.Name = "group4";
            // 
            // box3
            // 
            this.box3.Items.Add(this.svRedimFlagCombo);
            this.box3.Items.Add(this.svRedimInputButton);
            this.box3.Name = "box3";
            // 
            // svRedimFlagCombo
            // 
            ribbonDropDownItemImpl1.Label = "適合";
            ribbonDropDownItemImpl2.Label = "不適合";
            ribbonDropDownItemImpl3.Label = "非適用";
            ribbonDropDownItemImpl4.Label = "適合(注記)";
            ribbonDropDownItemImpl5.Label = "※追記";
            ribbonDropDownItemImpl6.Label = "※修正";
            ribbonDropDownItemImpl7.Label = "※削除";
            this.svRedimFlagCombo.Items.Add(ribbonDropDownItemImpl1);
            this.svRedimFlagCombo.Items.Add(ribbonDropDownItemImpl2);
            this.svRedimFlagCombo.Items.Add(ribbonDropDownItemImpl3);
            this.svRedimFlagCombo.Items.Add(ribbonDropDownItemImpl4);
            this.svRedimFlagCombo.Items.Add(ribbonDropDownItemImpl5);
            this.svRedimFlagCombo.Items.Add(ribbonDropDownItemImpl6);
            this.svRedimFlagCombo.Items.Add(ribbonDropDownItemImpl7);
            this.svRedimFlagCombo.Label = "判定修正";
            this.svRedimFlagCombo.Name = "svRedimFlagCombo";
            this.svRedimFlagCombo.ShowLabel = false;
            this.svRedimFlagCombo.Text = null;
            // 
            // svRedimInputButton
            // 
            this.svRedimInputButton.Label = "修正指摘する";
            this.svRedimInputButton.Name = "svRedimInputButton";
            this.svRedimInputButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.svRedimInputButton_Click);
            // 
            // box1
            // 
            this.box1.Items.Add(this.writeCommentBreakCheck);
            this.box1.Items.Add(this.writeCommentOverrideCheck);
            this.box1.Name = "box1";
            // 
            // writeCommentBreakCheck
            // 
            this.writeCommentBreakCheck.Label = "空行あり";
            this.writeCommentBreakCheck.Name = "writeCommentBreakCheck";
            // 
            // writeCommentOverrideCheck
            // 
            this.writeCommentOverrideCheck.Label = "追記";
            this.writeCommentOverrideCheck.Name = "writeCommentOverrideCheck";
            // 
            // addLabelColorCheck
            // 
            this.addLabelColorCheck.Label = "自動色付";
            this.addLabelColorCheck.Name = "addLabelColorCheck";
            // 
            // box5
            // 
            this.box5.Items.Add(this.writeCommentCombo);
            this.box5.Items.Add(this.writeCommentInputButton);
            this.box5.Name = "box5";
            // 
            // writeCommentCombo
            // 
            ribbonDropDownItemImpl8.Label = "見落としがあります";
            ribbonDropDownItemImpl9.Label = "過剰指摘です";
            this.writeCommentCombo.Items.Add(ribbonDropDownItemImpl8);
            this.writeCommentCombo.Items.Add(ribbonDropDownItemImpl9);
            this.writeCommentCombo.Label = "文言";
            this.writeCommentCombo.Name = "writeCommentCombo";
            this.writeCommentCombo.Text = null;
            // 
            // writeCommentInputButton
            // 
            this.writeCommentInputButton.Label = "選択文言を記入";
            this.writeCommentInputButton.Name = "writeCommentInputButton";
            this.writeCommentInputButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.surveyChangeInputButton_Click);
            // 
            // box6
            // 
            this.box6.Items.Add(this.writeCommentAddButton);
            this.box6.Items.Add(this.writeCommentAddFromFileButton);
            this.box6.Name = "box6";
            // 
            // writeCommentAddButton
            // 
            this.writeCommentAddButton.Label = "セルから値追加";
            this.writeCommentAddButton.Name = "writeCommentAddButton";
            this.writeCommentAddButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.writeCommentAddButton_Click);
            // 
            // writeCommentAddFromFileButton
            // 
            this.writeCommentAddFromFileButton.Label = "ファイルから値追加";
            this.writeCommentAddFromFileButton.Name = "writeCommentAddFromFileButton";
            this.writeCommentAddFromFileButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.writeCommentAddFromFileButton_Click);
            // 
            // box2
            // 
            this.box2.Items.Add(this.delCommentSingleButton);
            this.box2.Items.Add(this.delCommentAllButton);
            this.box2.Items.Add(this.addCommentPreClearCheck);
            this.box2.Name = "box2";
            // 
            // delCommentSingleButton
            // 
            this.delCommentSingleButton.Label = "1件削除";
            this.delCommentSingleButton.Name = "delCommentSingleButton";
            this.delCommentSingleButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.delCommentSingleButton_Click);
            // 
            // delCommentAllButton
            // 
            this.delCommentAllButton.Label = "全削除";
            this.delCommentAllButton.Name = "delCommentAllButton";
            this.delCommentAllButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.delCommentAllButton_Click);
            // 
            // addCommentPreClearCheck
            // 
            this.addCommentPreClearCheck.Label = "全クリアして追加";
            this.addCommentPreClearCheck.Name = "addCommentPreClearCheck";
            // 
            // groupLabelAddButton
            // 
            this.groupLabelAddButton.Label = "グループ名";
            this.groupLabelAddButton.Name = "groupLabelAddButton";
            this.groupLabelAddButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.groupLabelAddButton_Click);
            // 
            // markerInputButton
            // 
            this.markerInputButton.Label = "印を付ける";
            this.markerInputButton.Name = "markerInputButton";
            this.markerInputButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.markerInputButton_Click);
            // 
            // writeFormOpenButton
            // 
            this.writeFormOpenButton.Label = "セル文字編集";
            this.writeFormOpenButton.Name = "writeFormOpenButton";
            this.writeFormOpenButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.writeFormOpenButton_Click);
            // 
            // group5
            // 
            this.group5.Items.Add(this.documentEditButton);
            this.group5.Label = "文書処理";
            this.group5.Name = "group5";
            // 
            // documentEditButton
            // 
            this.documentEditButton.Label = "テキスト編集";
            this.documentEditButton.Name = "documentEditButton";
            this.documentEditButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.documentEditButton_Click);
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
            this.box4.ResumeLayout(false);
            this.box4.PerformLayout();
            this.group4.ResumeLayout(false);
            this.group4.PerformLayout();
            this.box3.ResumeLayout(false);
            this.box3.PerformLayout();
            this.box1.ResumeLayout(false);
            this.box1.PerformLayout();
            this.box5.ResumeLayout(false);
            this.box5.PerformLayout();
            this.box6.ResumeLayout(false);
            this.box6.PerformLayout();
            this.box2.ResumeLayout(false);
            this.box2.PerformLayout();
            this.group5.ResumeLayout(false);
            this.group5.PerformLayout();
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
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox addLabelColorCheck;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox globalAlertOKNGRadio;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton dispEasyHtmlDocButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton dispContrastRepFormButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group4;
        internal Microsoft.Office.Tools.Ribbon.RibbonComboBox writeCommentCombo;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton writeCommentInputButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton markerInputButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton writeFormOpenButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton writeCommentAddButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox writeCommentBreakCheck;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box4;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box3;
        internal Microsoft.Office.Tools.Ribbon.RibbonComboBox svRedimFlagCombo;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton svRedimInputButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox writeCommentOverrideCheck;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group5;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton documentEditButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box1;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box5;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box6;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton writeCommentAddFromFileButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton delCommentSingleButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton delCommentAllButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox addCommentPreClearCheck;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
