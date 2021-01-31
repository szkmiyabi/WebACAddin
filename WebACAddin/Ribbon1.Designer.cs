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
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl1 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl2 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl3 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl4 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl5 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl6 = this.Factory.CreateRibbonDropDownItem();
            this.webACTab = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.cellAnalysisButton = this.Factory.CreateRibbonButton();
            this.svDataForPasteButton = this.Factory.CreateRibbonButton();
            this.repoRowUpdateButton = this.Factory.CreateRibbonButton();
            this.customConditionFormatButton = this.Factory.CreateRibbonButton();
            this.dispEasyHtmlDocButton = this.Factory.CreateRibbonButton();
            this.dispContrastRepFormButton = this.Factory.CreateRibbonButton();
            this.libraPlusOnCheck = this.Factory.CreateRibbonCheckBox();
            this.group4 = this.Factory.CreateRibbonGroup();
            this.box3 = this.Factory.CreateRibbonBox();
            this.svRedimFlagCombo = this.Factory.CreateRibbonComboBox();
            this.svRedimInputButton = this.Factory.CreateRibbonButton();
            this.box1 = this.Factory.CreateRibbonBox();
            this.writeCommentBreakCheck = this.Factory.CreateRibbonCheckBox();
            this.writeCommentOverrideCheck = this.Factory.CreateRibbonCheckBox();
            this.writeCommentInsertPositionCheck = this.Factory.CreateRibbonCheckBox();
            this.gridPasteCheck = this.Factory.CreateRibbonCheckBox();
            this.box8 = this.Factory.CreateRibbonBox();
            this.addLabelColorCheck = this.Factory.CreateRibbonCheckBox();
            this.addColorRowCheck = this.Factory.CreateRibbonCheckBox();
            this.writeCommentReSurveyCheck = this.Factory.CreateRibbonCheckBox();
            this.box5 = this.Factory.CreateRibbonBox();
            this.writeCommentCombo = this.Factory.CreateRibbonComboBox();
            this.writeCommentInputButton = this.Factory.CreateRibbonButton();
            this.box6 = this.Factory.CreateRibbonBox();
            this.writeCommentAddButton = this.Factory.CreateRibbonButton();
            this.writeCommentAddFromFormButton = this.Factory.CreateRibbonButton();
            this.writeCommentAddFromFileButton = this.Factory.CreateRibbonButton();
            this.addCommentPreClearCheck = this.Factory.CreateRibbonCheckBox();
            this.box2 = this.Factory.CreateRibbonBox();
            this.delCommentSingleButton = this.Factory.CreateRibbonButton();
            this.delCommentAllButton = this.Factory.CreateRibbonButton();
            this.doEditComboButton = this.Factory.CreateRibbonButton();
            this.writeCommentComboSaveButton = this.Factory.CreateRibbonButton();
            this.box7 = this.Factory.CreateRibbonBox();
            this.markerDropdown = this.Factory.CreateRibbonComboBox();
            this.markerInputButton = this.Factory.CreateRibbonButton();
            this.autoNumberButton = this.Factory.CreateRibbonButton();
            this.selectedAutoFillButton = this.Factory.CreateRibbonButton();
            this.autoFilteredQueryButton = this.Factory.CreateRibbonButton();
            this.doRandomNumsButton = this.Factory.CreateRibbonButton();
            this.buttonGroup2 = this.Factory.CreateRibbonButtonGroup();
            this.ccEmptyButton = this.Factory.CreateRibbonButton();
            this.ccYellowButton = this.Factory.CreateRibbonButton();
            this.ccBlueButton = this.Factory.CreateRibbonButton();
            this.ccGreenButton = this.Factory.CreateRibbonButton();
            this.ccPinkButton = this.Factory.CreateRibbonButton();
            this.ccPurpleButton = this.Factory.CreateRibbonButton();
            this.ccRedButton = this.Factory.CreateRibbonButton();
            this.writeFormOpenButton = this.Factory.CreateRibbonButton();
            this.CursolControlFormButton = this.Factory.CreateRibbonButton();
            this.buttonGroup4 = this.Factory.CreateRibbonButtonGroup();
            this.fontBoldButton = this.Factory.CreateRibbonButton();
            this.fontRedButton = this.Factory.CreateRibbonButton();
            this.cellVerticalCenterButton = this.Factory.CreateRibbonButton();
            this.cellLineBreakButton = this.Factory.CreateRibbonButton();
            this.cellStrDeleteButton = this.Factory.CreateRibbonButton();
            this.borderMatrixButton = this.Factory.CreateRibbonButton();
            this.borderClearButton = this.Factory.CreateRibbonButton();
            this.group5 = this.Factory.CreateRibbonGroup();
            this.excelFooterClearButton = this.Factory.CreateRibbonButton();
            this.box9 = this.Factory.CreateRibbonBox();
            this.activeBookSheetsCombo = this.Factory.CreateRibbonComboBox();
            this.readActiveBookSheetsButton = this.Factory.CreateRibbonButton();
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
            this.group4.SuspendLayout();
            this.box3.SuspendLayout();
            this.box1.SuspendLayout();
            this.box8.SuspendLayout();
            this.box5.SuspendLayout();
            this.box6.SuspendLayout();
            this.box2.SuspendLayout();
            this.box7.SuspendLayout();
            this.buttonGroup2.SuspendLayout();
            this.buttonGroup4.SuspendLayout();
            this.group5.SuspendLayout();
            this.box9.SuspendLayout();
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
            this.group1.Items.Add(this.cellAnalysisButton);
            this.group1.Items.Add(this.svDataForPasteButton);
            this.group1.Items.Add(this.repoRowUpdateButton);
            this.group1.Items.Add(this.customConditionFormatButton);
            this.group1.Items.Add(this.dispEasyHtmlDocButton);
            this.group1.Items.Add(this.dispContrastRepFormButton);
            this.group1.Label = "セル解析";
            this.group1.Name = "group1";
            // 
            // cellAnalysisButton
            // 
            this.cellAnalysisButton.Label = "セルデータ解析";
            this.cellAnalysisButton.Name = "cellAnalysisButton";
            this.cellAnalysisButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cellAnalysisButton_Click);
            // 
            // svDataForPasteButton
            // 
            this.svDataForPasteButton.Label = "判定ひな形生成";
            this.svDataForPasteButton.Name = "svDataForPasteButton";
            this.svDataForPasteButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.svDataForPasteButton_Click);
            // 
            // repoRowUpdateButton
            // 
            this.repoRowUpdateButton.Label = "レポート行修正";
            this.repoRowUpdateButton.Name = "repoRowUpdateButton";
            this.repoRowUpdateButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.repoRowUpdateButton_Click);
            // 
            // customConditionFormatButton
            // 
            this.customConditionFormatButton.Label = "カスタム条件書式";
            this.customConditionFormatButton.Name = "customConditionFormatButton";
            this.customConditionFormatButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.customConditionFormatButton_Click);
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
            // libraPlusOnCheck
            // 
            this.libraPlusOnCheck.Label = "LibraPS有効";
            this.libraPlusOnCheck.Name = "libraPlusOnCheck";
            this.libraPlusOnCheck.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.libraPlusOnCheck_Click);
            // 
            // group4
            // 
            this.group4.Items.Add(this.box3);
            this.group4.Items.Add(this.box1);
            this.group4.Items.Add(this.box8);
            this.group4.Items.Add(this.box5);
            this.group4.Items.Add(this.box6);
            this.group4.Items.Add(this.box2);
            this.group4.Items.Add(this.box7);
            this.group4.Items.Add(this.buttonGroup2);
            this.group4.Items.Add(this.buttonGroup4);
            this.group4.Label = "表編集";
            this.group4.Name = "group4";
            // 
            // box3
            // 
            this.box3.Items.Add(this.libraPlusOnCheck);
            this.box3.Items.Add(this.svRedimFlagCombo);
            this.box3.Items.Add(this.svRedimInputButton);
            this.box3.Name = "box3";
            // 
            // svRedimFlagCombo
            // 
            this.svRedimFlagCombo.Label = "判定修正";
            this.svRedimFlagCombo.Name = "svRedimFlagCombo";
            this.svRedimFlagCombo.ShowLabel = false;
            this.svRedimFlagCombo.SizeString = "AAAAAAAA";
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
            this.box1.Items.Add(this.writeCommentInsertPositionCheck);
            this.box1.Items.Add(this.gridPasteCheck);
            this.box1.Name = "box1";
            // 
            // writeCommentBreakCheck
            // 
            this.writeCommentBreakCheck.Label = "空行";
            this.writeCommentBreakCheck.Name = "writeCommentBreakCheck";
            // 
            // writeCommentOverrideCheck
            // 
            this.writeCommentOverrideCheck.Label = "追記";
            this.writeCommentOverrideCheck.Name = "writeCommentOverrideCheck";
            // 
            // writeCommentInsertPositionCheck
            // 
            this.writeCommentInsertPositionCheck.Label = "先頭";
            this.writeCommentInsertPositionCheck.Name = "writeCommentInsertPositionCheck";
            // 
            // gridPasteCheck
            // 
            this.gridPasteCheck.Label = "升貼";
            this.gridPasteCheck.Name = "gridPasteCheck";
            // 
            // box8
            // 
            this.box8.Items.Add(this.addLabelColorCheck);
            this.box8.Items.Add(this.addColorRowCheck);
            this.box8.Items.Add(this.writeCommentReSurveyCheck);
            this.box8.Name = "box8";
            // 
            // addLabelColorCheck
            // 
            this.addLabelColorCheck.Label = "自動色付";
            this.addLabelColorCheck.Name = "addLabelColorCheck";
            // 
            // addColorRowCheck
            // 
            this.addColorRowCheck.Label = "行色付";
            this.addColorRowCheck.Name = "addColorRowCheck";
            // 
            // writeCommentReSurveyCheck
            // 
            this.writeCommentReSurveyCheck.Label = "再検査";
            this.writeCommentReSurveyCheck.Name = "writeCommentReSurveyCheck";
            this.writeCommentReSurveyCheck.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.writeCommentReSurveyCheck_Click);
            // 
            // box5
            // 
            this.box5.Items.Add(this.writeCommentCombo);
            this.box5.Items.Add(this.writeCommentInputButton);
            this.box5.Name = "box5";
            // 
            // writeCommentCombo
            // 
            this.writeCommentCombo.Label = "文言";
            this.writeCommentCombo.Name = "writeCommentCombo";
            this.writeCommentCombo.SizeString = "AAAAAAAAAA";
            this.writeCommentCombo.Text = null;
            // 
            // writeCommentInputButton
            // 
            this.writeCommentInputButton.Label = "語句挿入";
            this.writeCommentInputButton.Name = "writeCommentInputButton";
            this.writeCommentInputButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.surveyChangeInputButton_Click);
            // 
            // box6
            // 
            this.box6.Items.Add(this.writeCommentAddButton);
            this.box6.Items.Add(this.writeCommentAddFromFormButton);
            this.box6.Items.Add(this.writeCommentAddFromFileButton);
            this.box6.Items.Add(this.addCommentPreClearCheck);
            this.box6.Name = "box6";
            // 
            // writeCommentAddButton
            // 
            this.writeCommentAddButton.Label = "セルから追加";
            this.writeCommentAddButton.Name = "writeCommentAddButton";
            this.writeCommentAddButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.writeCommentAddButton_Click);
            // 
            // writeCommentAddFromFormButton
            // 
            this.writeCommentAddFromFormButton.Label = "フォーム";
            this.writeCommentAddFromFormButton.Name = "writeCommentAddFromFormButton";
            this.writeCommentAddFromFormButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.writeCommentAddFromFormButton_Click);
            // 
            // writeCommentAddFromFileButton
            // 
            this.writeCommentAddFromFileButton.Label = "ファイル";
            this.writeCommentAddFromFileButton.Name = "writeCommentAddFromFileButton";
            this.writeCommentAddFromFileButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.writeCommentAddFromFileButton_Click);
            // 
            // addCommentPreClearCheck
            // 
            this.addCommentPreClearCheck.Label = "全クリア追加";
            this.addCommentPreClearCheck.Name = "addCommentPreClearCheck";
            // 
            // box2
            // 
            this.box2.Items.Add(this.delCommentSingleButton);
            this.box2.Items.Add(this.delCommentAllButton);
            this.box2.Items.Add(this.doEditComboButton);
            this.box2.Items.Add(this.writeCommentComboSaveButton);
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
            // doEditComboButton
            // 
            this.doEditComboButton.Label = "値編集";
            this.doEditComboButton.Name = "doEditComboButton";
            this.doEditComboButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.doEditComboButton_Click);
            // 
            // writeCommentComboSaveButton
            // 
            this.writeCommentComboSaveButton.Label = "保存";
            this.writeCommentComboSaveButton.Name = "writeCommentComboSaveButton";
            this.writeCommentComboSaveButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.writeCommentComboSaveButton_Click);
            // 
            // box7
            // 
            this.box7.Items.Add(this.markerDropdown);
            this.box7.Items.Add(this.markerInputButton);
            this.box7.Items.Add(this.autoNumberButton);
            this.box7.Items.Add(this.selectedAutoFillButton);
            this.box7.Items.Add(this.autoFilteredQueryButton);
            this.box7.Items.Add(this.doRandomNumsButton);
            this.box7.Name = "box7";
            // 
            // markerDropdown
            // 
            ribbonDropDownItemImpl1.Label = "*";
            ribbonDropDownItemImpl2.Label = "-";
            ribbonDropDownItemImpl3.Label = "○";
            ribbonDropDownItemImpl4.Label = "△";
            ribbonDropDownItemImpl5.Label = "×";
            ribbonDropDownItemImpl6.Label = "■";
            this.markerDropdown.Items.Add(ribbonDropDownItemImpl1);
            this.markerDropdown.Items.Add(ribbonDropDownItemImpl2);
            this.markerDropdown.Items.Add(ribbonDropDownItemImpl3);
            this.markerDropdown.Items.Add(ribbonDropDownItemImpl4);
            this.markerDropdown.Items.Add(ribbonDropDownItemImpl5);
            this.markerDropdown.Items.Add(ribbonDropDownItemImpl6);
            this.markerDropdown.Label = "comboBox1";
            this.markerDropdown.Name = "markerDropdown";
            this.markerDropdown.ShowLabel = false;
            this.markerDropdown.SizeString = "AA";
            this.markerDropdown.Text = null;
            // 
            // markerInputButton
            // 
            this.markerInputButton.Label = "印を付ける";
            this.markerInputButton.Name = "markerInputButton";
            this.markerInputButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.markerInputButton_Click);
            // 
            // autoNumberButton
            // 
            this.autoNumberButton.Label = "通番";
            this.autoNumberButton.Name = "autoNumberButton";
            this.autoNumberButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.autoNumberButton_Click);
            // 
            // selectedAutoFillButton
            // 
            this.selectedAutoFillButton.Label = "オートフィル";
            this.selectedAutoFillButton.Name = "selectedAutoFillButton";
            this.selectedAutoFillButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.selectedAutoFillButton_Click);
            // 
            // autoFilteredQueryButton
            // 
            this.autoFilteredQueryButton.Label = "抽出";
            this.autoFilteredQueryButton.Name = "autoFilteredQueryButton";
            this.autoFilteredQueryButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.autoFilteredQueryButton_Click);
            // 
            // doRandomNumsButton
            // 
            this.doRandomNumsButton.Label = "乱数";
            this.doRandomNumsButton.Name = "doRandomNumsButton";
            this.doRandomNumsButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.doRandomNumsButton_Click);
            // 
            // buttonGroup2
            // 
            this.buttonGroup2.Items.Add(this.ccEmptyButton);
            this.buttonGroup2.Items.Add(this.ccYellowButton);
            this.buttonGroup2.Items.Add(this.ccBlueButton);
            this.buttonGroup2.Items.Add(this.ccGreenButton);
            this.buttonGroup2.Items.Add(this.ccPinkButton);
            this.buttonGroup2.Items.Add(this.ccPurpleButton);
            this.buttonGroup2.Items.Add(this.ccRedButton);
            this.buttonGroup2.Items.Add(this.writeFormOpenButton);
            this.buttonGroup2.Items.Add(this.CursolControlFormButton);
            this.buttonGroup2.Name = "buttonGroup2";
            // 
            // ccEmptyButton
            // 
            this.ccEmptyButton.Label = "無";
            this.ccEmptyButton.Name = "ccEmptyButton";
            this.ccEmptyButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ccEmptyButton_Click);
            // 
            // ccYellowButton
            // 
            this.ccYellowButton.Label = "黄";
            this.ccYellowButton.Name = "ccYellowButton";
            this.ccYellowButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ccYellowButton_Click);
            // 
            // ccBlueButton
            // 
            this.ccBlueButton.Label = "空";
            this.ccBlueButton.Name = "ccBlueButton";
            this.ccBlueButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ccBlueButton_Click);
            // 
            // ccGreenButton
            // 
            this.ccGreenButton.Label = "緑";
            this.ccGreenButton.Name = "ccGreenButton";
            this.ccGreenButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ccGreenButton_Click);
            // 
            // ccPinkButton
            // 
            this.ccPinkButton.Label = "桃";
            this.ccPinkButton.Name = "ccPinkButton";
            this.ccPinkButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ccPinkButton_Click);
            // 
            // ccPurpleButton
            // 
            this.ccPurpleButton.Label = "紫";
            this.ccPurpleButton.Name = "ccPurpleButton";
            this.ccPurpleButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ccPurpleButton_Click);
            // 
            // ccRedButton
            // 
            this.ccRedButton.Label = "赤";
            this.ccRedButton.Name = "ccRedButton";
            this.ccRedButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ccRedButton_Click);
            // 
            // writeFormOpenButton
            // 
            this.writeFormOpenButton.Label = "セル編集";
            this.writeFormOpenButton.Name = "writeFormOpenButton";
            this.writeFormOpenButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.writeFormOpenButton_Click);
            // 
            // CursolControlFormButton
            // 
            this.CursolControlFormButton.Label = "カーソル";
            this.CursolControlFormButton.Name = "CursolControlFormButton";
            this.CursolControlFormButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.CursolControlFormButton_Click);
            // 
            // buttonGroup4
            // 
            this.buttonGroup4.Items.Add(this.fontBoldButton);
            this.buttonGroup4.Items.Add(this.fontRedButton);
            this.buttonGroup4.Items.Add(this.cellVerticalCenterButton);
            this.buttonGroup4.Items.Add(this.cellLineBreakButton);
            this.buttonGroup4.Items.Add(this.cellStrDeleteButton);
            this.buttonGroup4.Items.Add(this.borderMatrixButton);
            this.buttonGroup4.Items.Add(this.borderClearButton);
            this.buttonGroup4.Name = "buttonGroup4";
            // 
            // fontBoldButton
            // 
            this.fontBoldButton.Label = "太字";
            this.fontBoldButton.Name = "fontBoldButton";
            this.fontBoldButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.fontBoldButton_Click);
            // 
            // fontRedButton
            // 
            this.fontRedButton.Label = "赤字";
            this.fontRedButton.Name = "fontRedButton";
            this.fontRedButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.fontRedButton_Click);
            // 
            // cellVerticalCenterButton
            // 
            this.cellVerticalCenterButton.Label = "縦中";
            this.cellVerticalCenterButton.Name = "cellVerticalCenterButton";
            this.cellVerticalCenterButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cellVerticalCenterButton_Click);
            // 
            // cellLineBreakButton
            // 
            this.cellLineBreakButton.Label = "折返";
            this.cellLineBreakButton.Name = "cellLineBreakButton";
            this.cellLineBreakButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cellLineBreakButton_Click);
            // 
            // cellStrDeleteButton
            // 
            this.cellStrDeleteButton.Label = "削除";
            this.cellStrDeleteButton.Name = "cellStrDeleteButton";
            this.cellStrDeleteButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cellStrDeleteButton_Click);
            // 
            // borderMatrixButton
            // 
            this.borderMatrixButton.Label = "升目";
            this.borderMatrixButton.Name = "borderMatrixButton";
            this.borderMatrixButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.borderMatrixButton_Click);
            // 
            // borderClearButton
            // 
            this.borderClearButton.Label = "無地";
            this.borderClearButton.Name = "borderClearButton";
            this.borderClearButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.borderClearButton_Click);
            // 
            // group5
            // 
            this.group5.Items.Add(this.excelFooterClearButton);
            this.group5.Items.Add(this.box9);
            this.group5.Label = "文書処理";
            this.group5.Name = "group5";
            // 
            // excelFooterClearButton
            // 
            this.excelFooterClearButton.Label = "フッタークリア";
            this.excelFooterClearButton.Name = "excelFooterClearButton";
            this.excelFooterClearButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.excelFooterClearButton_Click);
            // 
            // box9
            // 
            this.box9.Items.Add(this.activeBookSheetsCombo);
            this.box9.Items.Add(this.readActiveBookSheetsButton);
            this.box9.Name = "box9";
            // 
            // activeBookSheetsCombo
            // 
            this.activeBookSheetsCombo.Label = "シート切換";
            this.activeBookSheetsCombo.Name = "activeBookSheetsCombo";
            this.activeBookSheetsCombo.ShowLabel = false;
            this.activeBookSheetsCombo.SizeString = "AAAAA";
            this.activeBookSheetsCombo.Text = null;
            this.activeBookSheetsCombo.TextChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.activeBookSheetsCombo_TextChanged);
            // 
            // readActiveBookSheetsButton
            // 
            this.readActiveBookSheetsButton.Label = "読込";
            this.readActiveBookSheetsButton.Name = "readActiveBookSheetsButton";
            this.readActiveBookSheetsButton.OfficeImageId = "AccessListCustomDatasheet";
            this.readActiveBookSheetsButton.ShowImage = true;
            this.readActiveBookSheetsButton.ShowLabel = false;
            this.readActiveBookSheetsButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.readActiveBookSheetsButton_Click);
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
            this.group4.ResumeLayout(false);
            this.group4.PerformLayout();
            this.box3.ResumeLayout(false);
            this.box3.PerformLayout();
            this.box1.ResumeLayout(false);
            this.box1.PerformLayout();
            this.box8.ResumeLayout(false);
            this.box8.PerformLayout();
            this.box5.ResumeLayout(false);
            this.box5.PerformLayout();
            this.box6.ResumeLayout(false);
            this.box6.PerformLayout();
            this.box2.ResumeLayout(false);
            this.box2.PerformLayout();
            this.box7.ResumeLayout(false);
            this.box7.PerformLayout();
            this.buttonGroup2.ResumeLayout(false);
            this.buttonGroup2.PerformLayout();
            this.buttonGroup4.ResumeLayout(false);
            this.buttonGroup4.PerformLayout();
            this.group5.ResumeLayout(false);
            this.group5.PerformLayout();
            this.box9.ResumeLayout(false);
            this.box9.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.group3.ResumeLayout(false);
            this.group3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab webACTab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton setHrefBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton setPageTitleBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton saveAsTSVButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group3;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton openIEButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton openFirefoxButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton openChromeButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton openFirefoxDevButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton openChromeBetaButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox addLabelColorCheck;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton dispEasyHtmlDocButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton dispContrastRepFormButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group4;
        internal Microsoft.Office.Tools.Ribbon.RibbonComboBox writeCommentCombo;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton writeCommentInputButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton markerInputButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton writeFormOpenButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton writeCommentAddButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox writeCommentBreakCheck;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box3;
        internal Microsoft.Office.Tools.Ribbon.RibbonComboBox svRedimFlagCombo;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton svRedimInputButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox writeCommentOverrideCheck;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box1;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box5;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box6;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton writeCommentAddFromFileButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton delCommentSingleButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton delCommentAllButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox addCommentPreClearCheck;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton svDataForPasteButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ccBlueButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ccPurpleButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ccPinkButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ccGreenButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ccYellowButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ccEmptyButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton fontBoldButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton fontRedButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton cellVerticalCenterButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton cellLineBreakButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton autoNumberButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group5;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton excelFooterClearButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box7;
        internal Microsoft.Office.Tools.Ribbon.RibbonComboBox markerDropdown;
        internal Microsoft.Office.Tools.Ribbon.RibbonButtonGroup buttonGroup2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButtonGroup buttonGroup4;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton cellStrDeleteButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton writeCommentAddFromFormButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box8;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox addColorRowCheck;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ccRedButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton selectedAutoFillButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton writeCommentComboSaveButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonComboBox activeBookSheetsCombo;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box9;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton readActiveBookSheetsButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox writeCommentReSurveyCheck;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox writeCommentInsertPositionCheck;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton customConditionFormatButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton autoFilteredQueryButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton cellAnalysisButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton CursolControlFormButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton doEditComboButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton borderMatrixButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton borderClearButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton repoRowUpdateButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox gridPasteCheck;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton doRandomNumsButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox libraPlusOnCheck;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
