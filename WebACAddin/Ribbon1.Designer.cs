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
            this.buttonGroup1 = this.Factory.CreateRibbonButtonGroup();
            this.libraPlusToggle = this.Factory.CreateRibbonToggleButton();
            this.cellAnalysisButton = this.Factory.CreateRibbonButton();
            this.CellViewButton = this.Factory.CreateRibbonButton();
            this.buttonGroup3 = this.Factory.CreateRibbonButtonGroup();
            this.svDataForPasteButton = this.Factory.CreateRibbonButton();
            this.svDataDisplayButton = this.Factory.CreateRibbonButton();
            this.dispEasyHtmlDocButton = this.Factory.CreateRibbonButton();
            this.customConditionFormatButton = this.Factory.CreateRibbonButton();
            this.buttonGroup5 = this.Factory.CreateRibbonButtonGroup();
            this.repoRowUpdateButton = this.Factory.CreateRibbonButton();
            this.dispContrastRepFormButton = this.Factory.CreateRibbonButton();
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
            this.usedRangeSelectButton = this.Factory.CreateRibbonButton();
            this.selectThisColumnRangeButton = this.Factory.CreateRibbonButton();
            this.CursolControlFormButton = this.Factory.CreateRibbonButton();
            this.writeFormOpenButton = this.Factory.CreateRibbonButton();
            this.box7 = this.Factory.CreateRibbonBox();
            this.markerDropdown = this.Factory.CreateRibbonComboBox();
            this.markerInputButton = this.Factory.CreateRibbonButton();
            this.criteriaFazzyCheck = this.Factory.CreateRibbonCheckBox();
            this.buttonGroup2 = this.Factory.CreateRibbonButtonGroup();
            this.autoNumberButton = this.Factory.CreateRibbonButton();
            this.doRandomNumsButton = this.Factory.CreateRibbonButton();
            this.selectedAutoFillButton = this.Factory.CreateRibbonButton();
            this.nearCellCopyButton = this.Factory.CreateRibbonSplitButton();
            this.nearCellCopyFromLeftButton = this.Factory.CreateRibbonButton();
            this.cellDropDownListButton = this.Factory.CreateRibbonButton();
            this.buttonGroup4 = this.Factory.CreateRibbonButtonGroup();
            this.fontBoldButton = this.Factory.CreateRibbonButton();
            this.fontRedButton = this.Factory.CreateRibbonButton();
            this.cellVerticalAlignToggleButton = this.Factory.CreateRibbonButton();
            this.cellLineBreakButton = this.Factory.CreateRibbonButton();
            this.box11 = this.Factory.CreateRibbonBox();
            this.criteriaStringText = this.Factory.CreateRibbonEditBox();
            this.autoFilterAutoValSetButton = this.Factory.CreateRibbonButton();
            this.autoFilterDeleteButton = this.Factory.CreateRibbonButton();
            this.autoFilteredQueryButton = this.Factory.CreateRibbonButton();
            this.box12 = this.Factory.CreateRibbonBox();
            this.ccEmptyButton = this.Factory.CreateRibbonButton();
            this.ccYellowButton = this.Factory.CreateRibbonButton();
            this.ccBlueButton = this.Factory.CreateRibbonButton();
            this.ccGreenButton = this.Factory.CreateRibbonButton();
            this.ccPinkButton = this.Factory.CreateRibbonButton();
            this.ccPurpleButton = this.Factory.CreateRibbonButton();
            this.ccRedButton = this.Factory.CreateRibbonButton();
            this.box13 = this.Factory.CreateRibbonBox();
            this.cellStrDeleteButton = this.Factory.CreateRibbonButton();
            this.borderMatrixButton = this.Factory.CreateRibbonButton();
            this.borderClearButton = this.Factory.CreateRibbonButton();
            this.group5 = this.Factory.CreateRibbonGroup();
            this.box9 = this.Factory.CreateRibbonBox();
            this.readActiveBookSheetsButton = this.Factory.CreateRibbonButton();
            this.activeBookSheetsCombo = this.Factory.CreateRibbonComboBox();
            this.box4 = this.Factory.CreateRibbonBox();
            this.insertRoundedRectButton = this.Factory.CreateRibbonButton();
            this.insertLineArrowButton = this.Factory.CreateRibbonButton();
            this.insertArrowButton = this.Factory.CreateRibbonButton();
            this.insertCalloutButton = this.Factory.CreateRibbonButton();
            this.insertTextBoxButton = this.Factory.CreateRibbonButton();
            this.insertBigTextButton = this.Factory.CreateRibbonButton();
            this.box10 = this.Factory.CreateRibbonBox();
            this.resetShapeStyleButton = this.Factory.CreateRibbonButton();
            this.bringFrontButton = this.Factory.CreateRibbonButton();
            this.horizontalFlipButton = this.Factory.CreateRibbonButton();
            this.verticalFlipButton = this.Factory.CreateRibbonButton();
            this.selectObjectButton = this.Factory.CreateRibbonButton();
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
            this.buttonGroup1.SuspendLayout();
            this.buttonGroup3.SuspendLayout();
            this.buttonGroup5.SuspendLayout();
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
            this.box11.SuspendLayout();
            this.box12.SuspendLayout();
            this.box13.SuspendLayout();
            this.group5.SuspendLayout();
            this.box9.SuspendLayout();
            this.box4.SuspendLayout();
            this.box10.SuspendLayout();
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
            this.group1.Items.Add(this.buttonGroup1);
            this.group1.Items.Add(this.buttonGroup3);
            this.group1.Items.Add(this.buttonGroup5);
            this.group1.Label = "セル解析";
            this.group1.Name = "group1";
            // 
            // buttonGroup1
            // 
            this.buttonGroup1.Items.Add(this.libraPlusToggle);
            this.buttonGroup1.Items.Add(this.cellAnalysisButton);
            this.buttonGroup1.Items.Add(this.CellViewButton);
            this.buttonGroup1.Name = "buttonGroup1";
            // 
            // libraPlusToggle
            // 
            this.libraPlusToggle.Label = "PS";
            this.libraPlusToggle.Name = "libraPlusToggle";
            this.libraPlusToggle.OfficeImageId = "SetPertWeights";
            this.libraPlusToggle.ShowImage = true;
            this.libraPlusToggle.SuperTip = "Libra／LibraPlusモード切替";
            this.libraPlusToggle.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.libraPlusToggle_Click);
            // 
            // cellAnalysisButton
            // 
            this.cellAnalysisButton.Label = "セル解析";
            this.cellAnalysisButton.Name = "cellAnalysisButton";
            this.cellAnalysisButton.OfficeImageId = "SparklineConvertToLine";
            this.cellAnalysisButton.ScreenTip = "セル解析";
            this.cellAnalysisButton.ShowImage = true;
            this.cellAnalysisButton.ShowLabel = false;
            this.cellAnalysisButton.SuperTip = "セルデータをいろいろ解析します。";
            this.cellAnalysisButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cellAnalysisButton_Click);
            // 
            // CellViewButton
            // 
            this.CellViewButton.Label = "button1";
            this.CellViewButton.Name = "CellViewButton";
            this.CellViewButton.OfficeImageId = "CellStylesMerge";
            this.CellViewButton.ScreenTip = "セルデータ表示";
            this.CellViewButton.ShowImage = true;
            this.CellViewButton.ShowLabel = false;
            this.CellViewButton.SuperTip = "セル内データをフォームで大きく表示します。";
            this.CellViewButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.CellViewButton_Click);
            // 
            // buttonGroup3
            // 
            this.buttonGroup3.Items.Add(this.svDataForPasteButton);
            this.buttonGroup3.Items.Add(this.svDataDisplayButton);
            this.buttonGroup3.Items.Add(this.dispEasyHtmlDocButton);
            this.buttonGroup3.Items.Add(this.customConditionFormatButton);
            this.buttonGroup3.Name = "buttonGroup3";
            // 
            // svDataForPasteButton
            // 
            this.svDataForPasteButton.Label = "判定ひな形";
            this.svDataForPasteButton.Name = "svDataForPasteButton";
            this.svDataForPasteButton.OfficeImageId = "Indexed";
            this.svDataForPasteButton.ScreenTip = "判定ひな形";
            this.svDataForPasteButton.ShowImage = true;
            this.svDataForPasteButton.ShowLabel = false;
            this.svDataForPasteButton.SuperTip = "検査報告書からLibraの判定ひな形を生成します。";
            this.svDataForPasteButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.svDataForPasteButton_Click);
            // 
            // svDataDisplayButton
            // 
            this.svDataDisplayButton.Label = "判定結果を整形表示";
            this.svDataDisplayButton.Name = "svDataDisplayButton";
            this.svDataDisplayButton.OfficeImageId = "InfopathFormActionsMenu";
            this.svDataDisplayButton.ScreenTip = "判定結果を整形表示";
            this.svDataDisplayButton.ShowImage = true;
            this.svDataDisplayButton.ShowLabel = false;
            this.svDataDisplayButton.SuperTip = "判定結果を見やすく整形して表示します。";
            this.svDataDisplayButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.svDataDisplayButton_Click);
            // 
            // dispEasyHtmlDocButton
            // 
            this.dispEasyHtmlDocButton.Label = "HTML表示";
            this.dispEasyHtmlDocButton.Name = "dispEasyHtmlDocButton";
            this.dispEasyHtmlDocButton.OfficeImageId = "GroupListCustomActionsManage";
            this.dispEasyHtmlDocButton.ScreenTip = "HTML表示";
            this.dispEasyHtmlDocButton.ShowImage = true;
            this.dispEasyHtmlDocButton.ShowLabel = false;
            this.dispEasyHtmlDocButton.SuperTip = "HTMLソースが入力されたセルを簡易ブラウザ表示します。";
            this.dispEasyHtmlDocButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.dispEasyHtmlDocButton_Click);
            // 
            // customConditionFormatButton
            // 
            this.customConditionFormatButton.Label = "カスタム条件書式";
            this.customConditionFormatButton.Name = "customConditionFormatButton";
            this.customConditionFormatButton.OfficeImageId = "ConditionalFormattingColorScalesGallery";
            this.customConditionFormatButton.ScreenTip = "カスタム条件書式";
            this.customConditionFormatButton.ShowImage = true;
            this.customConditionFormatButton.ShowLabel = false;
            this.customConditionFormatButton.SuperTip = "自由度の高い条件付き書式を設定します。";
            this.customConditionFormatButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.customConditionFormatButton_Click);
            // 
            // buttonGroup5
            // 
            this.buttonGroup5.Items.Add(this.repoRowUpdateButton);
            this.buttonGroup5.Items.Add(this.dispContrastRepFormButton);
            this.buttonGroup5.Name = "buttonGroup5";
            // 
            // repoRowUpdateButton
            // 
            this.repoRowUpdateButton.Label = "検査報告書の行修正";
            this.repoRowUpdateButton.Name = "repoRowUpdateButton";
            this.repoRowUpdateButton.OfficeImageId = "XDInkPicture";
            this.repoRowUpdateButton.ScreenTip = "検査報告書の行修正";
            this.repoRowUpdateButton.ShowImage = true;
            this.repoRowUpdateButton.ShowLabel = false;
            this.repoRowUpdateButton.SuperTip = "検査報告書の内容を行単位でひな形を用いて修正します。";
            this.repoRowUpdateButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.repoRowUpdateButton_Click);
            // 
            // dispContrastRepFormButton
            // 
            this.dispContrastRepFormButton.Label = "コントラスト解析";
            this.dispContrastRepFormButton.Name = "dispContrastRepFormButton";
            this.dispContrastRepFormButton.OfficeImageId = "GroupMasterEditTheme";
            this.dispContrastRepFormButton.ScreenTip = "コントラスト解析";
            this.dispContrastRepFormButton.ShowImage = true;
            this.dispContrastRepFormButton.ShowLabel = false;
            this.dispContrastRepFormButton.SuperTip = "コントラスト測定結果が入力されたセルを簡易プレビューします。";
            this.dispContrastRepFormButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.dispContrastRepFormButton_Click);
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
            this.group4.Items.Add(this.box11);
            this.group4.Items.Add(this.box12);
            this.group4.Items.Add(this.box13);
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
            this.svRedimFlagCombo.Label = "判定";
            this.svRedimFlagCombo.Name = "svRedimFlagCombo";
            this.svRedimFlagCombo.ScreenTip = "判定語句自動挿入";
            this.svRedimFlagCombo.SizeString = "AAAAAAAA";
            this.svRedimFlagCombo.SuperTip = "検査報告書で判定語句を追記あるいは差替ます。";
            this.svRedimFlagCombo.Text = null;
            // 
            // svRedimInputButton
            // 
            this.svRedimInputButton.Label = "修正指摘する";
            this.svRedimInputButton.Name = "svRedimInputButton";
            this.svRedimInputButton.OfficeImageId = "BrowseNext";
            this.svRedimInputButton.ShowImage = true;
            this.svRedimInputButton.ShowLabel = false;
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
            this.writeCommentCombo.Label = "定型句";
            this.writeCommentCombo.Name = "writeCommentCombo";
            this.writeCommentCombo.ScreenTip = "定型句自動挿入";
            this.writeCommentCombo.SizeString = "AAAAAAAAAAAAAA";
            this.writeCommentCombo.SuperTip = "あらかじめ登録した定型句を追記したりします。語句は現在のセルやファイルからも取込可能で語句一覧編集も対応しています。";
            this.writeCommentCombo.Text = null;
            // 
            // writeCommentInputButton
            // 
            this.writeCommentInputButton.Label = "語句挿入";
            this.writeCommentInputButton.Name = "writeCommentInputButton";
            this.writeCommentInputButton.OfficeImageId = "BrowseNext";
            this.writeCommentInputButton.ShowImage = true;
            this.writeCommentInputButton.ShowLabel = false;
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
            this.writeCommentAddButton.OfficeImageId = "TableInsertRowsAbove";
            this.writeCommentAddButton.ShowImage = true;
            this.writeCommentAddButton.ShowLabel = false;
            this.writeCommentAddButton.SuperTip = "セルから追加";
            this.writeCommentAddButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.writeCommentAddButton_Click);
            // 
            // writeCommentAddFromFormButton
            // 
            this.writeCommentAddFromFormButton.Label = "フォームから追加";
            this.writeCommentAddFromFormButton.Name = "writeCommentAddFromFormButton";
            this.writeCommentAddFromFormButton.OfficeImageId = "FormControlInsertMenu";
            this.writeCommentAddFromFormButton.ShowImage = true;
            this.writeCommentAddFromFormButton.ShowLabel = false;
            this.writeCommentAddFromFormButton.SuperTip = "フォームから追加";
            this.writeCommentAddFromFormButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.writeCommentAddFromFormButton_Click);
            // 
            // writeCommentAddFromFileButton
            // 
            this.writeCommentAddFromFileButton.Label = "ファイルから追加";
            this.writeCommentAddFromFileButton.Name = "writeCommentAddFromFileButton";
            this.writeCommentAddFromFileButton.OfficeImageId = "CreateDocumentLibrary";
            this.writeCommentAddFromFileButton.ShowImage = true;
            this.writeCommentAddFromFileButton.ShowLabel = false;
            this.writeCommentAddFromFileButton.SuperTip = "ファイルから追加";
            this.writeCommentAddFromFileButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.writeCommentAddFromFileButton_Click);
            // 
            // addCommentPreClearCheck
            // 
            this.addCommentPreClearCheck.Label = "全削除追加";
            this.addCommentPreClearCheck.Name = "addCommentPreClearCheck";
            // 
            // box2
            // 
            this.box2.Items.Add(this.delCommentSingleButton);
            this.box2.Items.Add(this.delCommentAllButton);
            this.box2.Items.Add(this.doEditComboButton);
            this.box2.Items.Add(this.writeCommentComboSaveButton);
            this.box2.Items.Add(this.usedRangeSelectButton);
            this.box2.Items.Add(this.selectThisColumnRangeButton);
            this.box2.Items.Add(this.CursolControlFormButton);
            this.box2.Items.Add(this.writeFormOpenButton);
            this.box2.Name = "box2";
            // 
            // delCommentSingleButton
            // 
            this.delCommentSingleButton.Label = "1件削除";
            this.delCommentSingleButton.Name = "delCommentSingleButton";
            this.delCommentSingleButton.OfficeImageId = "SectionMergeWithPrevious";
            this.delCommentSingleButton.ShowImage = true;
            this.delCommentSingleButton.ShowLabel = false;
            this.delCommentSingleButton.SuperTip = "現在選択語句を1件削除";
            this.delCommentSingleButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.delCommentSingleButton_Click);
            // 
            // delCommentAllButton
            // 
            this.delCommentAllButton.Label = "全件削除";
            this.delCommentAllButton.Name = "delCommentAllButton";
            this.delCommentAllButton.OfficeImageId = "SectionRemoveAll";
            this.delCommentAllButton.ShowImage = true;
            this.delCommentAllButton.ShowLabel = false;
            this.delCommentAllButton.SuperTip = "語句を全件削除";
            this.delCommentAllButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.delCommentAllButton_Click);
            // 
            // doEditComboButton
            // 
            this.doEditComboButton.Label = "語句一覧編集";
            this.doEditComboButton.Name = "doEditComboButton";
            this.doEditComboButton.OfficeImageId = "SearchTools";
            this.doEditComboButton.ShowImage = true;
            this.doEditComboButton.ShowLabel = false;
            this.doEditComboButton.SuperTip = "語句一覧編集";
            this.doEditComboButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.doEditComboButton_Click);
            // 
            // writeCommentComboSaveButton
            // 
            this.writeCommentComboSaveButton.Label = "語句一覧ファイル保存";
            this.writeCommentComboSaveButton.Name = "writeCommentComboSaveButton";
            this.writeCommentComboSaveButton.OfficeImageId = "SaveHollow";
            this.writeCommentComboSaveButton.ScreenTip = "語句一覧ファイル保存";
            this.writeCommentComboSaveButton.ShowImage = true;
            this.writeCommentComboSaveButton.ShowLabel = false;
            this.writeCommentComboSaveButton.SuperTip = "現在のドロップダウンリストの語句一覧をテキストファイルに保存します。";
            this.writeCommentComboSaveButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.writeCommentComboSaveButton_Click);
            // 
            // usedRangeSelectButton
            // 
            this.usedRangeSelectButton.Label = "表全選択";
            this.usedRangeSelectButton.Name = "usedRangeSelectButton";
            this.usedRangeSelectButton.OfficeImageId = "ControlPaddingNone";
            this.usedRangeSelectButton.ScreenTip = "表全選択";
            this.usedRangeSelectButton.ShowImage = true;
            this.usedRangeSelectButton.ShowLabel = false;
            this.usedRangeSelectButton.SuperTip = "表全体を自動選択します。";
            this.usedRangeSelectButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.usedRangeSelectButton_Click);
            // 
            // selectThisColumnRangeButton
            // 
            this.selectThisColumnRangeButton.Label = "列範囲全選択";
            this.selectThisColumnRangeButton.Name = "selectThisColumnRangeButton";
            this.selectThisColumnRangeButton.OfficeImageId = "SelectColumns";
            this.selectThisColumnRangeButton.ScreenTip = "列範囲全選択";
            this.selectThisColumnRangeButton.ShowImage = true;
            this.selectThisColumnRangeButton.ShowLabel = false;
            this.selectThisColumnRangeButton.SuperTip = "列のデータ入力範囲をアクティブセルを起点に全て選択します。";
            this.selectThisColumnRangeButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.selectThisColumnRangeButton_Click);
            // 
            // CursolControlFormButton
            // 
            this.CursolControlFormButton.Label = "カーソル制御";
            this.CursolControlFormButton.Name = "CursolControlFormButton";
            this.CursolControlFormButton.OfficeImageId = "LeftButtonIconColor";
            this.CursolControlFormButton.ScreenTip = "カーソル制御";
            this.CursolControlFormButton.ShowImage = true;
            this.CursolControlFormButton.ShowLabel = false;
            this.CursolControlFormButton.SuperTip = "セルのカーソルを上下左右、指定行へマウス操作で制御するコントローラーを立ち上げます。";
            this.CursolControlFormButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.CursolControlFormButton_Click);
            // 
            // writeFormOpenButton
            // 
            this.writeFormOpenButton.Label = "セル編集フォーム表示";
            this.writeFormOpenButton.Name = "writeFormOpenButton";
            this.writeFormOpenButton.OfficeImageId = "EditPermissionGroup";
            this.writeFormOpenButton.ScreenTip = "セル編集フォーム表示";
            this.writeFormOpenButton.ShowImage = true;
            this.writeFormOpenButton.ShowLabel = false;
            this.writeFormOpenButton.SuperTip = "セルの複数行編集に役立つ専用フォーム画面を立ち上げます。";
            this.writeFormOpenButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.writeFormOpenButton_Click);
            // 
            // box7
            // 
            this.box7.Items.Add(this.markerDropdown);
            this.box7.Items.Add(this.markerInputButton);
            this.box7.Items.Add(this.criteriaFazzyCheck);
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
            this.markerDropdown.Label = "記号";
            this.markerDropdown.Name = "markerDropdown";
            this.markerDropdown.ScreenTip = "記号自動挿入";
            this.markerDropdown.SizeString = "AAA";
            this.markerDropdown.SuperTip = "行の印付のための記号を挿入します。デフォルトは「*」で行を黄色く塗ります。";
            this.markerDropdown.Text = null;
            // 
            // markerInputButton
            // 
            this.markerInputButton.Label = "印を付ける";
            this.markerInputButton.Name = "markerInputButton";
            this.markerInputButton.OfficeImageId = "BrowseNext";
            this.markerInputButton.ShowImage = true;
            this.markerInputButton.ShowLabel = false;
            this.markerInputButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.markerInputButton_Click);
            // 
            // criteriaFazzyCheck
            // 
            this.criteriaFazzyCheck.Label = "曖昧";
            this.criteriaFazzyCheck.Name = "criteriaFazzyCheck";
            // 
            // buttonGroup2
            // 
            this.buttonGroup2.Items.Add(this.selectedAutoFillButton);
            this.buttonGroup2.Items.Add(this.autoNumberButton);
            this.buttonGroup2.Items.Add(this.doRandomNumsButton);
            this.buttonGroup2.Items.Add(this.nearCellCopyButton);
            this.buttonGroup2.Items.Add(this.cellDropDownListButton);
            this.buttonGroup2.Name = "buttonGroup2";
            // 
            // autoNumberButton
            // 
            this.autoNumberButton.Label = "連番自動挿入";
            this.autoNumberButton.Name = "autoNumberButton";
            this.autoNumberButton.OfficeImageId = "AsianLayoutHorizontalInVertical";
            this.autoNumberButton.ScreenTip = "連番自動挿入";
            this.autoNumberButton.ShowImage = true;
            this.autoNumberButton.ShowLabel = false;
            this.autoNumberButton.SuperTip = "選択範囲に連番をふります。";
            this.autoNumberButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.autoNumberButton_Click);
            // 
            // doRandomNumsButton
            // 
            this.doRandomNumsButton.Label = "乱数自動挿入";
            this.doRandomNumsButton.Name = "doRandomNumsButton";
            this.doRandomNumsButton.OfficeImageId = "R";
            this.doRandomNumsButton.ScreenTip = "乱数自動挿入";
            this.doRandomNumsButton.ShowImage = true;
            this.doRandomNumsButton.ShowLabel = false;
            this.doRandomNumsButton.SuperTip = "選択範囲に乱数を挿入します。";
            this.doRandomNumsButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.doRandomNumsButton_Click);
            // 
            // selectedAutoFillButton
            // 
            this.selectedAutoFillButton.Label = "カスタム自動フィル";
            this.selectedAutoFillButton.Name = "selectedAutoFillButton";
            this.selectedAutoFillButton.OfficeImageId = "ArrangementGallery";
            this.selectedAutoFillButton.ScreenTip = "カスタム自動フィル";
            this.selectedAutoFillButton.ShowImage = true;
            this.selectedAutoFillButton.ShowLabel = false;
            this.selectedAutoFillButton.SuperTip = "通常のオートフィルを単純化。選択範囲の先頭セルの内容で埋めます。数式は自動反映対応しています。";
            this.selectedAutoFillButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.selectedAutoFillButton_Click);
            // 
            // nearCellCopyButton
            // 
            this.nearCellCopyButton.Items.Add(this.nearCellCopyFromLeftButton);
            this.nearCellCopyButton.Label = "セル値を拝借";
            this.nearCellCopyButton.Name = "nearCellCopyButton";
            this.nearCellCopyButton.OfficeImageId = "AutoScheduleSelectedTask";
            this.nearCellCopyButton.ScreenTip = "セル値を拝借";
            this.nearCellCopyButton.ShowLabel = false;
            this.nearCellCopyButton.SuperTip = "現在カーソルがあるセルに隣接するセルと同じ内容で埋めます。現在は左隣だけに対応しています。";
            // 
            // nearCellCopyFromLeftButton
            // 
            this.nearCellCopyFromLeftButton.Label = "左から";
            this.nearCellCopyFromLeftButton.Name = "nearCellCopyFromLeftButton";
            this.nearCellCopyFromLeftButton.ShowImage = true;
            this.nearCellCopyFromLeftButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.nearCellCopyFromLeftButton_Click);
            // 
            // cellDropDownListButton
            // 
            this.cellDropDownListButton.Label = "入力規則リスト自動設定";
            this.cellDropDownListButton.Name = "cellDropDownListButton";
            this.cellDropDownListButton.OfficeImageId = "BullettedListControl";
            this.cellDropDownListButton.ScreenTip = "入力規則リスト自動設定";
            this.cellDropDownListButton.ShowImage = true;
            this.cellDropDownListButton.ShowLabel = false;
            this.cellDropDownListButton.SuperTip = "Libraの判定語句を入力規則リストに自動設定します。";
            this.cellDropDownListButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cellDropDownListButton_Click);
            // 
            // buttonGroup4
            // 
            this.buttonGroup4.Items.Add(this.borderClearButton);
            this.buttonGroup4.Items.Add(this.borderMatrixButton);
            this.buttonGroup4.Items.Add(this.cellLineBreakButton);
            this.buttonGroup4.Items.Add(this.cellVerticalAlignToggleButton);
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
            // cellVerticalAlignToggleButton
            // 
            this.cellVerticalAlignToggleButton.Label = "縦位置";
            this.cellVerticalAlignToggleButton.Name = "cellVerticalAlignToggleButton";
            this.cellVerticalAlignToggleButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cellVerticalAlignToggleButton_Click);
            // 
            // cellLineBreakButton
            // 
            this.cellLineBreakButton.Label = "折返";
            this.cellLineBreakButton.Name = "cellLineBreakButton";
            this.cellLineBreakButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cellLineBreakButton_Click);
            // 
            // box11
            // 
            this.box11.Items.Add(this.criteriaStringText);
            this.box11.Items.Add(this.autoFilterAutoValSetButton);
            this.box11.Items.Add(this.autoFilterDeleteButton);
            this.box11.Items.Add(this.autoFilteredQueryButton);
            this.box11.Name = "box11";
            // 
            // criteriaStringText
            // 
            this.criteriaStringText.Label = "絞込";
            this.criteriaStringText.Name = "criteriaStringText";
            this.criteriaStringText.ShowLabel = false;
            this.criteriaStringText.SizeString = "AAAAAAAAA";
            this.criteriaStringText.SuperTip = "オートフィルタ絞込条件の語句を入力";
            this.criteriaStringText.Text = null;
            // 
            // autoFilterAutoValSetButton
            // 
            this.autoFilterAutoValSetButton.Label = "フィルタ絞込";
            this.autoFilterAutoValSetButton.Name = "autoFilterAutoValSetButton";
            this.autoFilterAutoValSetButton.OfficeImageId = "ChartQuickExplore";
            this.autoFilterAutoValSetButton.ScreenTip = "オートフィルタ絞込";
            this.autoFilterAutoValSetButton.ShowImage = true;
            this.autoFilterAutoValSetButton.ShowLabel = false;
            this.autoFilterAutoValSetButton.SuperTip = "オートフィルタ適用した表で現在のカーソル列の絞込を左欄に入力した語句で実行します。「曖昧」にチェックを入れると曖昧に絞込ます。";
            this.autoFilterAutoValSetButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.autoFilterAutoValSetButton_Click);
            // 
            // autoFilterDeleteButton
            // 
            this.autoFilterDeleteButton.Label = "button1";
            this.autoFilterDeleteButton.Name = "autoFilterDeleteButton";
            this.autoFilterDeleteButton.OfficeImageId = "DisabledAddins";
            this.autoFilterDeleteButton.ScreenTip = "フィルタ絞込解除";
            this.autoFilterDeleteButton.ShowImage = true;
            this.autoFilterDeleteButton.ShowLabel = false;
            this.autoFilterDeleteButton.SuperTip = "現在のカーソル列のオートフィルタの絞込を解除します。";
            this.autoFilterDeleteButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.autoFilterDeleteButton_Click);
            // 
            // autoFilteredQueryButton
            // 
            this.autoFilteredQueryButton.Label = "オートフィルタ抽出行出力";
            this.autoFilteredQueryButton.Name = "autoFilteredQueryButton";
            this.autoFilteredQueryButton.OfficeImageId = "AutoFilterProject";
            this.autoFilteredQueryButton.ScreenTip = "オートフィルタ抽出行出力";
            this.autoFilteredQueryButton.ShowImage = true;
            this.autoFilteredQueryButton.ShowLabel = false;
            this.autoFilteredQueryButton.SuperTip = "オートフィルタで抽出し現在見えている行を全て別シートに出力します。";
            this.autoFilteredQueryButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.autoFilteredQueryButton_Click);
            // 
            // box12
            // 
            this.box12.Items.Add(this.ccEmptyButton);
            this.box12.Items.Add(this.ccYellowButton);
            this.box12.Items.Add(this.ccBlueButton);
            this.box12.Items.Add(this.ccGreenButton);
            this.box12.Items.Add(this.ccPinkButton);
            this.box12.Items.Add(this.ccPurpleButton);
            this.box12.Items.Add(this.ccRedButton);
            this.box12.Name = "box12";
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
            // box13
            // 
            this.box13.Items.Add(this.fontBoldButton);
            this.box13.Items.Add(this.fontRedButton);
            this.box13.Items.Add(this.cellStrDeleteButton);
            this.box13.Name = "box13";
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
            this.group5.Items.Add(this.box9);
            this.group5.Items.Add(this.box4);
            this.group5.Items.Add(this.box10);
            this.group5.Label = "文書処理";
            this.group5.Name = "group5";
            // 
            // box9
            // 
            this.box9.Items.Add(this.readActiveBookSheetsButton);
            this.box9.Items.Add(this.activeBookSheetsCombo);
            this.box9.Name = "box9";
            // 
            // readActiveBookSheetsButton
            // 
            this.readActiveBookSheetsButton.Label = "シート一覧セット";
            this.readActiveBookSheetsButton.Name = "readActiveBookSheetsButton";
            this.readActiveBookSheetsButton.OfficeImageId = "TablesGallery";
            this.readActiveBookSheetsButton.ShowImage = true;
            this.readActiveBookSheetsButton.ShowLabel = false;
            this.readActiveBookSheetsButton.SuperTip = "シート一覧をセット";
            this.readActiveBookSheetsButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.readActiveBookSheetsButton_Click);
            // 
            // activeBookSheetsCombo
            // 
            this.activeBookSheetsCombo.Label = "シート切換";
            this.activeBookSheetsCombo.Name = "activeBookSheetsCombo";
            this.activeBookSheetsCombo.ScreenTip = "シート切換";
            this.activeBookSheetsCombo.ShowLabel = false;
            this.activeBookSheetsCombo.SizeString = "AAAAAAAAA";
            this.activeBookSheetsCombo.SuperTip = "ドロップダウンリストでシートを切り替えれます。シート一覧をセットするには左側のボタンを押してください。";
            this.activeBookSheetsCombo.Text = null;
            this.activeBookSheetsCombo.TextChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.activeBookSheetsCombo_TextChanged);
            // 
            // box4
            // 
            this.box4.Items.Add(this.insertRoundedRectButton);
            this.box4.Items.Add(this.insertLineArrowButton);
            this.box4.Items.Add(this.insertArrowButton);
            this.box4.Items.Add(this.insertCalloutButton);
            this.box4.Items.Add(this.insertTextBoxButton);
            this.box4.Items.Add(this.insertBigTextButton);
            this.box4.Name = "box4";
            // 
            // insertRoundedRectButton
            // 
            this.insertRoundedRectButton.Label = "赤枠";
            this.insertRoundedRectButton.Name = "insertRoundedRectButton";
            this.insertRoundedRectButton.OfficeImageId = "InkFeltTipPen";
            this.insertRoundedRectButton.ScreenTip = "赤枠";
            this.insertRoundedRectButton.ShowImage = true;
            this.insertRoundedRectButton.ShowLabel = false;
            this.insertRoundedRectButton.SuperTip = "ぬり無し角丸赤枠を挿入します。";
            this.insertRoundedRectButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.insertRoundedRectButton_Click);
            // 
            // insertLineArrowButton
            // 
            this.insertLineArrowButton.Label = "矢印";
            this.insertLineArrowButton.Name = "insertLineArrowButton";
            this.insertLineArrowButton.OfficeImageId = "Arrow";
            this.insertLineArrowButton.ScreenTip = "矢印";
            this.insertLineArrowButton.ShowImage = true;
            this.insertLineArrowButton.ShowLabel = false;
            this.insertLineArrowButton.SuperTip = "赤線矢印を挿入します。";
            this.insertLineArrowButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.insertLineArrowButton_Click);
            // 
            // insertArrowButton
            // 
            this.insertArrowButton.Label = "図矢印";
            this.insertArrowButton.Name = "insertArrowButton";
            this.insertArrowButton.OfficeImageId = "MultipleSelect";
            this.insertArrowButton.ScreenTip = "図矢印";
            this.insertArrowButton.ShowImage = true;
            this.insertArrowButton.ShowLabel = false;
            this.insertArrowButton.SuperTip = "橙のブロック矢印を挿入します。";
            this.insertArrowButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.insertArrowButton_Click);
            // 
            // insertCalloutButton
            // 
            this.insertCalloutButton.Label = "吹出";
            this.insertCalloutButton.Name = "insertCalloutButton";
            this.insertCalloutButton.OfficeImageId = "Callout";
            this.insertCalloutButton.ScreenTip = "吹出";
            this.insertCalloutButton.ShowImage = true;
            this.insertCalloutButton.ShowLabel = false;
            this.insertCalloutButton.SuperTip = "橙罫線の吹出を挿入します。";
            this.insertCalloutButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.insertCalloutButton_Click);
            // 
            // insertTextBoxButton
            // 
            this.insertTextBoxButton.Label = "透明枠";
            this.insertTextBoxButton.Name = "insertTextBoxButton";
            this.insertTextBoxButton.OfficeImageId = "DrawTextBox";
            this.insertTextBoxButton.ScreenTip = "透明枠";
            this.insertTextBoxButton.ShowImage = true;
            this.insertTextBoxButton.ShowLabel = false;
            this.insertTextBoxButton.SuperTip = "ぬり無し罫線無しのテキスト枠を挿入します。";
            this.insertTextBoxButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.insertTextBoxButton_Click);
            // 
            // insertBigTextButton
            // 
            this.insertBigTextButton.Label = "大きな文字";
            this.insertBigTextButton.Name = "insertBigTextButton";
            this.insertBigTextButton.OfficeImageId = "AddToContentStore";
            this.insertBigTextButton.ScreenTip = "大きな文字";
            this.insertBigTextButton.ShowImage = true;
            this.insertBigTextButton.ShowLabel = false;
            this.insertBigTextButton.SuperTip = "大きな文字枠を挿入します。";
            this.insertBigTextButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.insertBigTextButton_Click);
            // 
            // box10
            // 
            this.box10.Items.Add(this.resetShapeStyleButton);
            this.box10.Items.Add(this.bringFrontButton);
            this.box10.Items.Add(this.horizontalFlipButton);
            this.box10.Items.Add(this.verticalFlipButton);
            this.box10.Items.Add(this.selectObjectButton);
            this.box10.Name = "box10";
            // 
            // resetShapeStyleButton
            // 
            this.resetShapeStyleButton.Label = "書式無";
            this.resetShapeStyleButton.Name = "resetShapeStyleButton";
            this.resetShapeStyleButton.OfficeImageId = "Clear";
            this.resetShapeStyleButton.ScreenTip = "書式無";
            this.resetShapeStyleButton.ShowImage = true;
            this.resetShapeStyleButton.ShowLabel = false;
            this.resetShapeStyleButton.SuperTip = "選択した図形の書式をクリアします。";
            this.resetShapeStyleButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.resetShapeStyleButton_Click);
            // 
            // bringFrontButton
            // 
            this.bringFrontButton.Label = "最前面";
            this.bringFrontButton.Name = "bringFrontButton";
            this.bringFrontButton.OfficeImageId = "CircularReferences";
            this.bringFrontButton.ScreenTip = "最前面に移動";
            this.bringFrontButton.ShowImage = true;
            this.bringFrontButton.ShowLabel = false;
            this.bringFrontButton.SuperTip = "最前面に図形を移動させます。";
            this.bringFrontButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.bringFrontButton_Click);
            // 
            // horizontalFlipButton
            // 
            this.horizontalFlipButton.Label = "横反転";
            this.horizontalFlipButton.Name = "horizontalFlipButton";
            this.horizontalFlipButton.OfficeImageId = "ReviewCompareTwoVersions";
            this.horizontalFlipButton.ScreenTip = "横反転";
            this.horizontalFlipButton.ShowImage = true;
            this.horizontalFlipButton.ShowLabel = false;
            this.horizontalFlipButton.SuperTip = "図形を横に反転します。";
            this.horizontalFlipButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.horizontalFlipButton_Click);
            // 
            // verticalFlipButton
            // 
            this.verticalFlipButton.Label = "縦反転";
            this.verticalFlipButton.Name = "verticalFlipButton";
            this.verticalFlipButton.OfficeImageId = "RowHeight";
            this.verticalFlipButton.ScreenTip = "縦反転";
            this.verticalFlipButton.ShowImage = true;
            this.verticalFlipButton.ShowLabel = false;
            this.verticalFlipButton.SuperTip = "図形を縦に反転します。";
            this.verticalFlipButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.verticalFlipButton_Click);
            // 
            // selectObjectButton
            // 
            this.selectObjectButton.Label = "図形全選択";
            this.selectObjectButton.Name = "selectObjectButton";
            this.selectObjectButton.OfficeImageId = "SkewerClick";
            this.selectObjectButton.ScreenTip = "図形全選択";
            this.selectObjectButton.ShowImage = true;
            this.selectObjectButton.ShowLabel = false;
            this.selectObjectButton.SuperTip = "カレントシート内の全図形を選択します。";
            this.selectObjectButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.selectObjectButton_Click);
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
            this.setHrefBtn.ScreenTip = "ハイパーリンク設定";
            this.setHrefBtn.SuperTip = "選択範囲のURLのセルにハイパーリンクを設定します。";
            this.setHrefBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.setHrefBtn_Click);
            // 
            // setPageTitleBtn
            // 
            this.setPageTitleBtn.Label = "title取得";
            this.setPageTitleBtn.Name = "setPageTitleBtn";
            this.setPageTitleBtn.ScreenTip = "ページタイトル取得";
            this.setPageTitleBtn.SuperTip = "選択範囲のURLのセルの隣列にページタイトル取得して自動記入します。";
            this.setPageTitleBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.setPageTitleBtn_Click);
            // 
            // saveAsTSVButton
            // 
            this.saveAsTSVButton.Label = "TSV保存";
            this.saveAsTSVButton.Name = "saveAsTSVButton";
            this.saveAsTSVButton.ScreenTip = "TSV保存";
            this.saveAsTSVButton.SuperTip = "選択範囲をタブ区切りテキストのファイルとして出力します。";
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
            this.openIEButton.SuperTip = "IEでURLをプレビュー";
            this.openIEButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.openIEButton_Click);
            // 
            // openFirefoxButton
            // 
            this.openFirefoxButton.Label = "Firefox";
            this.openFirefoxButton.Name = "openFirefoxButton";
            this.openFirefoxButton.SuperTip = "FirefoxでURLをプレビュー";
            this.openFirefoxButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.openFirefoxButton_Click);
            // 
            // openChromeButton
            // 
            this.openChromeButton.Label = "Chrome";
            this.openChromeButton.Name = "openChromeButton";
            this.openChromeButton.SuperTip = "ChromeでURLをプレビュー";
            this.openChromeButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.openChromeButton_Click);
            // 
            // openFirefoxDevButton
            // 
            this.openFirefoxDevButton.Label = "Firefox(dev)";
            this.openFirefoxDevButton.Name = "openFirefoxDevButton";
            this.openFirefoxDevButton.SuperTip = "Firefox DeveloperEditionでURLをプレビュー(インストールしている方のみ)";
            this.openFirefoxDevButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.openFirefoxDevButton_Click);
            // 
            // openChromeBetaButton
            // 
            this.openChromeBetaButton.Label = "Chrome(beta)";
            this.openChromeBetaButton.Name = "openChromeBetaButton";
            this.openChromeBetaButton.SuperTip = "Chrome ベータ版でURLをプレビュー(インストールしている方のみ)";
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
            this.buttonGroup1.ResumeLayout(false);
            this.buttonGroup1.PerformLayout();
            this.buttonGroup3.ResumeLayout(false);
            this.buttonGroup3.PerformLayout();
            this.buttonGroup5.ResumeLayout(false);
            this.buttonGroup5.PerformLayout();
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
            this.box11.ResumeLayout(false);
            this.box11.PerformLayout();
            this.box12.ResumeLayout(false);
            this.box12.PerformLayout();
            this.box13.ResumeLayout(false);
            this.box13.PerformLayout();
            this.group5.ResumeLayout(false);
            this.group5.PerformLayout();
            this.box9.ResumeLayout(false);
            this.box9.PerformLayout();
            this.box4.ResumeLayout(false);
            this.box4.PerformLayout();
            this.box10.ResumeLayout(false);
            this.box10.PerformLayout();
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
        internal Microsoft.Office.Tools.Ribbon.RibbonButton cellVerticalAlignToggleButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton cellLineBreakButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton autoNumberButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group5;
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
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box4;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox criteriaStringText;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton autoFilterAutoValSetButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box10;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox criteriaFazzyCheck;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton usedRangeSelectButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton libraPlusToggle;
        internal Microsoft.Office.Tools.Ribbon.RibbonSplitButton nearCellCopyButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton nearCellCopyFromLeftButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton insertRoundedRectButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton resetShapeStyleButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton insertLineArrowButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton insertArrowButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton insertCalloutButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton insertTextBoxButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton bringFrontButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton horizontalFlipButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton verticalFlipButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton insertBigTextButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton selectObjectButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton cellDropDownListButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton selectThisColumnRangeButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButtonGroup buttonGroup1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButtonGroup buttonGroup3;
        internal Microsoft.Office.Tools.Ribbon.RibbonButtonGroup buttonGroup5;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton svDataDisplayButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton CellViewButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box11;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box12;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box13;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton autoFilterDeleteButton;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
