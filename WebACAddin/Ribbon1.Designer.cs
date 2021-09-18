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
            this.group4 = this.Factory.CreateRibbonGroup();
            this.box3 = this.Factory.CreateRibbonBox();
            this.libraPlusToggle = this.Factory.CreateRibbonToggleButton();
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
            this.autoNumberButton = this.Factory.CreateRibbonButton();
            this.doRandomNumsButton = this.Factory.CreateRibbonButton();
            this.selectedAutoFillButton = this.Factory.CreateRibbonButton();
            this.box7 = this.Factory.CreateRibbonBox();
            this.markerDropdown = this.Factory.CreateRibbonComboBox();
            this.markerInputButton = this.Factory.CreateRibbonButton();
            this.criteriaStringText = this.Factory.CreateRibbonEditBox();
            this.autoFilterAutoValSetButton = this.Factory.CreateRibbonButton();
            this.criteriaFazzyCheck = this.Factory.CreateRibbonCheckBox();
            this.buttonGroup2 = this.Factory.CreateRibbonButtonGroup();
            this.nearCellCopyButton = this.Factory.CreateRibbonSplitButton();
            this.nearCellCopyFromLeftButton = this.Factory.CreateRibbonButton();
            this.ccEmptyButton = this.Factory.CreateRibbonButton();
            this.ccYellowButton = this.Factory.CreateRibbonButton();
            this.ccBlueButton = this.Factory.CreateRibbonButton();
            this.ccGreenButton = this.Factory.CreateRibbonButton();
            this.ccPinkButton = this.Factory.CreateRibbonButton();
            this.ccPurpleButton = this.Factory.CreateRibbonButton();
            this.ccRedButton = this.Factory.CreateRibbonButton();
            this.CursolControlFormButton = this.Factory.CreateRibbonButton();
            this.writeFormOpenButton = this.Factory.CreateRibbonButton();
            this.buttonGroup4 = this.Factory.CreateRibbonButtonGroup();
            this.fontBoldButton = this.Factory.CreateRibbonButton();
            this.fontRedButton = this.Factory.CreateRibbonButton();
            this.cellVerticalAlignToggleButton = this.Factory.CreateRibbonButton();
            this.cellLineBreakButton = this.Factory.CreateRibbonButton();
            this.cellStrDeleteButton = this.Factory.CreateRibbonButton();
            this.borderMatrixButton = this.Factory.CreateRibbonButton();
            this.borderClearButton = this.Factory.CreateRibbonButton();
            this.group5 = this.Factory.CreateRibbonGroup();
            this.box9 = this.Factory.CreateRibbonBox();
            this.readActiveBookSheetsButton = this.Factory.CreateRibbonButton();
            this.activeBookSheetsCombo = this.Factory.CreateRibbonComboBox();
            this.autoFilteredQueryButton = this.Factory.CreateRibbonButton();
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
            this.cellAnalysisButton.Label = "データ解析";
            this.cellAnalysisButton.Name = "cellAnalysisButton";
            this.cellAnalysisButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cellAnalysisButton_Click);
            // 
            // svDataForPasteButton
            // 
            this.svDataForPasteButton.Label = "判定ひな形";
            this.svDataForPasteButton.Name = "svDataForPasteButton";
            this.svDataForPasteButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.svDataForPasteButton_Click);
            // 
            // repoRowUpdateButton
            // 
            this.repoRowUpdateButton.Label = "レポート修正";
            this.repoRowUpdateButton.Name = "repoRowUpdateButton";
            this.repoRowUpdateButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.repoRowUpdateButton_Click);
            // 
            // customConditionFormatButton
            // 
            this.customConditionFormatButton.Label = "条件書式";
            this.customConditionFormatButton.Name = "customConditionFormatButton";
            this.customConditionFormatButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.customConditionFormatButton_Click);
            // 
            // dispEasyHtmlDocButton
            // 
            this.dispEasyHtmlDocButton.Label = "HTML表示";
            this.dispEasyHtmlDocButton.Name = "dispEasyHtmlDocButton";
            this.dispEasyHtmlDocButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.dispEasyHtmlDocButton_Click);
            // 
            // dispContrastRepFormButton
            // 
            this.dispContrastRepFormButton.Label = "コントラスト";
            this.dispContrastRepFormButton.Name = "dispContrastRepFormButton";
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
            this.group4.Label = "表編集";
            this.group4.Name = "group4";
            // 
            // box3
            // 
            this.box3.Items.Add(this.libraPlusToggle);
            this.box3.Items.Add(this.svRedimFlagCombo);
            this.box3.Items.Add(this.svRedimInputButton);
            this.box3.Name = "box3";
            // 
            // libraPlusToggle
            // 
            this.libraPlusToggle.Label = "PS";
            this.libraPlusToggle.Name = "libraPlusToggle";
            this.libraPlusToggle.OfficeImageId = "SetPertWeights";
            this.libraPlusToggle.ShowImage = true;
            this.libraPlusToggle.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.libraPlusToggle_Click);
            // 
            // svRedimFlagCombo
            // 
            this.svRedimFlagCombo.Label = "判定";
            this.svRedimFlagCombo.Name = "svRedimFlagCombo";
            this.svRedimFlagCombo.SizeString = "AAAAAAAA";
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
            this.writeCommentCombo.Label = "語句";
            this.writeCommentCombo.Name = "writeCommentCombo";
            this.writeCommentCombo.SizeString = "AAAAAAAAAAAAAA";
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
            this.writeCommentAddButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.writeCommentAddButton_Click);
            // 
            // writeCommentAddFromFormButton
            // 
            this.writeCommentAddFromFormButton.Label = "フォーム";
            this.writeCommentAddFromFormButton.Name = "writeCommentAddFromFormButton";
            this.writeCommentAddFromFormButton.OfficeImageId = "FormControlInsertMenu";
            this.writeCommentAddFromFormButton.ShowImage = true;
            this.writeCommentAddFromFormButton.ShowLabel = false;
            this.writeCommentAddFromFormButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.writeCommentAddFromFormButton_Click);
            // 
            // writeCommentAddFromFileButton
            // 
            this.writeCommentAddFromFileButton.Label = "ファイル";
            this.writeCommentAddFromFileButton.Name = "writeCommentAddFromFileButton";
            this.writeCommentAddFromFileButton.OfficeImageId = "CreateDocumentLibrary";
            this.writeCommentAddFromFileButton.ShowImage = true;
            this.writeCommentAddFromFileButton.ShowLabel = false;
            this.writeCommentAddFromFileButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.writeCommentAddFromFileButton_Click);
            // 
            // addCommentPreClearCheck
            // 
            this.addCommentPreClearCheck.Label = "全削除";
            this.addCommentPreClearCheck.Name = "addCommentPreClearCheck";
            // 
            // box2
            // 
            this.box2.Items.Add(this.delCommentSingleButton);
            this.box2.Items.Add(this.delCommentAllButton);
            this.box2.Items.Add(this.doEditComboButton);
            this.box2.Items.Add(this.writeCommentComboSaveButton);
            this.box2.Items.Add(this.usedRangeSelectButton);
            this.box2.Items.Add(this.autoNumberButton);
            this.box2.Items.Add(this.doRandomNumsButton);
            this.box2.Items.Add(this.selectedAutoFillButton);
            this.box2.Name = "box2";
            // 
            // delCommentSingleButton
            // 
            this.delCommentSingleButton.Label = "1件削除";
            this.delCommentSingleButton.Name = "delCommentSingleButton";
            this.delCommentSingleButton.OfficeImageId = "SectionMergeWithPrevious";
            this.delCommentSingleButton.ShowImage = true;
            this.delCommentSingleButton.ShowLabel = false;
            this.delCommentSingleButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.delCommentSingleButton_Click);
            // 
            // delCommentAllButton
            // 
            this.delCommentAllButton.Label = "全削除";
            this.delCommentAllButton.Name = "delCommentAllButton";
            this.delCommentAllButton.OfficeImageId = "SectionRemoveAll";
            this.delCommentAllButton.ShowImage = true;
            this.delCommentAllButton.ShowLabel = false;
            this.delCommentAllButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.delCommentAllButton_Click);
            // 
            // doEditComboButton
            // 
            this.doEditComboButton.Label = "値編集";
            this.doEditComboButton.Name = "doEditComboButton";
            this.doEditComboButton.OfficeImageId = "SearchTools";
            this.doEditComboButton.ShowImage = true;
            this.doEditComboButton.ShowLabel = false;
            this.doEditComboButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.doEditComboButton_Click);
            // 
            // writeCommentComboSaveButton
            // 
            this.writeCommentComboSaveButton.Label = "保存";
            this.writeCommentComboSaveButton.Name = "writeCommentComboSaveButton";
            this.writeCommentComboSaveButton.OfficeImageId = "SaveHollow";
            this.writeCommentComboSaveButton.ShowImage = true;
            this.writeCommentComboSaveButton.ShowLabel = false;
            this.writeCommentComboSaveButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.writeCommentComboSaveButton_Click);
            // 
            // usedRangeSelectButton
            // 
            this.usedRangeSelectButton.Label = "全選択";
            this.usedRangeSelectButton.Name = "usedRangeSelectButton";
            this.usedRangeSelectButton.OfficeImageId = "ControlPaddingNone";
            this.usedRangeSelectButton.ShowImage = true;
            this.usedRangeSelectButton.ShowLabel = false;
            this.usedRangeSelectButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.usedRangeSelectButton_Click);
            // 
            // autoNumberButton
            // 
            this.autoNumberButton.Label = "通番";
            this.autoNumberButton.Name = "autoNumberButton";
            this.autoNumberButton.OfficeImageId = "CalculatedNumber";
            this.autoNumberButton.ShowImage = true;
            this.autoNumberButton.ShowLabel = false;
            this.autoNumberButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.autoNumberButton_Click);
            // 
            // doRandomNumsButton
            // 
            this.doRandomNumsButton.Label = "乱数";
            this.doRandomNumsButton.Name = "doRandomNumsButton";
            this.doRandomNumsButton.OfficeImageId = "R";
            this.doRandomNumsButton.ShowImage = true;
            this.doRandomNumsButton.ShowLabel = false;
            this.doRandomNumsButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.doRandomNumsButton_Click);
            // 
            // selectedAutoFillButton
            // 
            this.selectedAutoFillButton.Label = "自動フィル";
            this.selectedAutoFillButton.Name = "selectedAutoFillButton";
            this.selectedAutoFillButton.OfficeImageId = "ArrangementGallery";
            this.selectedAutoFillButton.ShowImage = true;
            this.selectedAutoFillButton.ShowLabel = false;
            this.selectedAutoFillButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.selectedAutoFillButton_Click);
            // 
            // box7
            // 
            this.box7.Items.Add(this.markerDropdown);
            this.box7.Items.Add(this.markerInputButton);
            this.box7.Items.Add(this.criteriaStringText);
            this.box7.Items.Add(this.autoFilterAutoValSetButton);
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
            this.markerDropdown.SizeString = "AAAA";
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
            // criteriaStringText
            // 
            this.criteriaStringText.Label = "絞込";
            this.criteriaStringText.Name = "criteriaStringText";
            this.criteriaStringText.ShowLabel = false;
            this.criteriaStringText.SizeString = "AAAAAAA";
            this.criteriaStringText.Text = null;
            // 
            // autoFilterAutoValSetButton
            // 
            this.autoFilterAutoValSetButton.Label = "絞込";
            this.autoFilterAutoValSetButton.Name = "autoFilterAutoValSetButton";
            this.autoFilterAutoValSetButton.OfficeImageId = "InsertTimeline";
            this.autoFilterAutoValSetButton.ShowImage = true;
            this.autoFilterAutoValSetButton.ShowLabel = false;
            this.autoFilterAutoValSetButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.autoFilterAutoValSetButton_Click);
            // 
            // criteriaFazzyCheck
            // 
            this.criteriaFazzyCheck.Label = "曖昧";
            this.criteriaFazzyCheck.Name = "criteriaFazzyCheck";
            // 
            // buttonGroup2
            // 
            this.buttonGroup2.Items.Add(this.nearCellCopyButton);
            this.buttonGroup2.Items.Add(this.ccEmptyButton);
            this.buttonGroup2.Items.Add(this.ccYellowButton);
            this.buttonGroup2.Items.Add(this.ccBlueButton);
            this.buttonGroup2.Items.Add(this.ccGreenButton);
            this.buttonGroup2.Items.Add(this.ccPinkButton);
            this.buttonGroup2.Items.Add(this.ccPurpleButton);
            this.buttonGroup2.Items.Add(this.ccRedButton);
            this.buttonGroup2.Items.Add(this.CursolControlFormButton);
            this.buttonGroup2.Items.Add(this.writeFormOpenButton);
            this.buttonGroup2.Name = "buttonGroup2";
            // 
            // nearCellCopyButton
            // 
            this.nearCellCopyButton.Items.Add(this.nearCellCopyFromLeftButton);
            this.nearCellCopyButton.Label = "splitButton1";
            this.nearCellCopyButton.Name = "nearCellCopyButton";
            this.nearCellCopyButton.OfficeImageId = "ChangeAssignmentDatesToComplyWithEngagementsVisibleByContext";
            this.nearCellCopyButton.ShowLabel = false;
            // 
            // nearCellCopyFromLeftButton
            // 
            this.nearCellCopyFromLeftButton.Label = "左から";
            this.nearCellCopyFromLeftButton.Name = "nearCellCopyFromLeftButton";
            this.nearCellCopyFromLeftButton.ShowImage = true;
            this.nearCellCopyFromLeftButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.nearCellCopyFromLeftButton_Click);
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
            // CursolControlFormButton
            // 
            this.CursolControlFormButton.Label = "カーソル";
            this.CursolControlFormButton.Name = "CursolControlFormButton";
            this.CursolControlFormButton.OfficeImageId = "LeftButtonIconColor";
            this.CursolControlFormButton.ShowImage = true;
            this.CursolControlFormButton.ShowLabel = false;
            this.CursolControlFormButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.CursolControlFormButton_Click);
            // 
            // writeFormOpenButton
            // 
            this.writeFormOpenButton.Label = "セル編集";
            this.writeFormOpenButton.Name = "writeFormOpenButton";
            this.writeFormOpenButton.OfficeImageId = "CatalogMergeEditList";
            this.writeFormOpenButton.ShowImage = true;
            this.writeFormOpenButton.ShowLabel = false;
            this.writeFormOpenButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.writeFormOpenButton_Click);
            // 
            // buttonGroup4
            // 
            this.buttonGroup4.Items.Add(this.fontBoldButton);
            this.buttonGroup4.Items.Add(this.fontRedButton);
            this.buttonGroup4.Items.Add(this.cellVerticalAlignToggleButton);
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
            this.box9.Items.Add(this.autoFilteredQueryButton);
            this.box9.Name = "box9";
            // 
            // readActiveBookSheetsButton
            // 
            this.readActiveBookSheetsButton.Label = "読込";
            this.readActiveBookSheetsButton.Name = "readActiveBookSheetsButton";
            this.readActiveBookSheetsButton.OfficeImageId = "TablesGallery";
            this.readActiveBookSheetsButton.ShowImage = true;
            this.readActiveBookSheetsButton.ShowLabel = false;
            this.readActiveBookSheetsButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.readActiveBookSheetsButton_Click);
            // 
            // activeBookSheetsCombo
            // 
            this.activeBookSheetsCombo.Label = "シート切換";
            this.activeBookSheetsCombo.Name = "activeBookSheetsCombo";
            this.activeBookSheetsCombo.ShowLabel = false;
            this.activeBookSheetsCombo.SizeString = "AAAAAAAAA";
            this.activeBookSheetsCombo.Text = null;
            this.activeBookSheetsCombo.TextChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.activeBookSheetsCombo_TextChanged);
            // 
            // autoFilteredQueryButton
            // 
            this.autoFilteredQueryButton.Label = "抽出行出力";
            this.autoFilteredQueryButton.Name = "autoFilteredQueryButton";
            this.autoFilteredQueryButton.OfficeImageId = "FilterBySelection";
            this.autoFilteredQueryButton.ShowImage = true;
            this.autoFilteredQueryButton.ShowLabel = false;
            this.autoFilteredQueryButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.autoFilteredQueryButton_Click);
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
            this.insertRoundedRectButton.ShowImage = true;
            this.insertRoundedRectButton.ShowLabel = false;
            this.insertRoundedRectButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.insertRoundedRectButton_Click);
            // 
            // insertLineArrowButton
            // 
            this.insertLineArrowButton.Label = "矢印";
            this.insertLineArrowButton.Name = "insertLineArrowButton";
            this.insertLineArrowButton.OfficeImageId = "Arrow";
            this.insertLineArrowButton.ShowImage = true;
            this.insertLineArrowButton.ShowLabel = false;
            this.insertLineArrowButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.insertLineArrowButton_Click);
            // 
            // insertArrowButton
            // 
            this.insertArrowButton.Label = "図矢印";
            this.insertArrowButton.Name = "insertArrowButton";
            this.insertArrowButton.OfficeImageId = "MultipleSelect";
            this.insertArrowButton.ShowImage = true;
            this.insertArrowButton.ShowLabel = false;
            this.insertArrowButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.insertArrowButton_Click);
            // 
            // insertCalloutButton
            // 
            this.insertCalloutButton.Label = "吹出";
            this.insertCalloutButton.Name = "insertCalloutButton";
            this.insertCalloutButton.OfficeImageId = "Callout";
            this.insertCalloutButton.ShowImage = true;
            this.insertCalloutButton.ShowLabel = false;
            this.insertCalloutButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.insertCalloutButton_Click);
            // 
            // insertTextBoxButton
            // 
            this.insertTextBoxButton.Label = "透明枠";
            this.insertTextBoxButton.Name = "insertTextBoxButton";
            this.insertTextBoxButton.OfficeImageId = "DrawTextBox";
            this.insertTextBoxButton.ShowImage = true;
            this.insertTextBoxButton.ShowLabel = false;
            this.insertTextBoxButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.insertTextBoxButton_Click);
            // 
            // insertBigTextButton
            // 
            this.insertBigTextButton.Label = "大きな文字";
            this.insertBigTextButton.Name = "insertBigTextButton";
            this.insertBigTextButton.OfficeImageId = "AddToContentStore";
            this.insertBigTextButton.ShowImage = true;
            this.insertBigTextButton.ShowLabel = false;
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
            this.resetShapeStyleButton.ShowImage = true;
            this.resetShapeStyleButton.ShowLabel = false;
            this.resetShapeStyleButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.resetShapeStyleButton_Click);
            // 
            // bringFrontButton
            // 
            this.bringFrontButton.Label = "最前面";
            this.bringFrontButton.Name = "bringFrontButton";
            this.bringFrontButton.OfficeImageId = "CircularReferences";
            this.bringFrontButton.ShowImage = true;
            this.bringFrontButton.ShowLabel = false;
            this.bringFrontButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.bringFrontButton_Click);
            // 
            // horizontalFlipButton
            // 
            this.horizontalFlipButton.Label = "横反転";
            this.horizontalFlipButton.Name = "horizontalFlipButton";
            this.horizontalFlipButton.OfficeImageId = "ReviewCompareTwoVersions";
            this.horizontalFlipButton.ShowImage = true;
            this.horizontalFlipButton.ShowLabel = false;
            this.horizontalFlipButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.horizontalFlipButton_Click);
            // 
            // verticalFlipButton
            // 
            this.verticalFlipButton.Label = "縦反転";
            this.verticalFlipButton.Name = "verticalFlipButton";
            this.verticalFlipButton.OfficeImageId = "RowHeight";
            this.verticalFlipButton.ShowImage = true;
            this.verticalFlipButton.ShowLabel = false;
            this.verticalFlipButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.verticalFlipButton_Click);
            // 
            // selectObjectButton
            // 
            this.selectObjectButton.Label = "図形全選択";
            this.selectObjectButton.Name = "selectObjectButton";
            this.selectObjectButton.OfficeImageId = "SkewerClick";
            this.selectObjectButton.ShowImage = true;
            this.selectObjectButton.ShowLabel = false;
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
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
