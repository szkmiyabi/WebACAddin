namespace WebACAddin
{
    partial class BrowserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.browserControl = new System.Windows.Forms.WebBrowser();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.previewHtmlUpdateButton = new System.Windows.Forms.Button();
            this.docStructParagraphRadio = new System.Windows.Forms.CheckBox();
            this.docStructBrRadio = new System.Windows.Forms.CheckBox();
            this.docStructHeadingRadio = new System.Windows.Forms.CheckBox();
            this.docStructListRadio = new System.Windows.Forms.CheckBox();
            this.docStructTableRadio = new System.Windows.Forms.CheckBox();
            this.docStructSemanticRadio = new System.Windows.Forms.CheckBox();
            this.docStructSurveyButton = new System.Windows.Forms.Button();
            this.doLabelCheckTitleRadio = new System.Windows.Forms.CheckBox();
            this.doLabelCheckButton = new System.Windows.Forms.Button();
            this.docSemanticsClearButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.BrowserFormTopMostCheck = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.browserControl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.52631F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.473684F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(801, 423);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // browserControl
            // 
            this.browserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browserControl.Location = new System.Drawing.Point(3, 3);
            this.browserControl.MinimumSize = new System.Drawing.Size(20, 20);
            this.browserControl.Name = "browserControl";
            this.browserControl.Size = new System.Drawing.Size(795, 347);
            this.browserControl.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.previewHtmlUpdateButton);
            this.flowLayoutPanel1.Controls.Add(this.docStructParagraphRadio);
            this.flowLayoutPanel1.Controls.Add(this.docStructBrRadio);
            this.flowLayoutPanel1.Controls.Add(this.docStructHeadingRadio);
            this.flowLayoutPanel1.Controls.Add(this.docStructListRadio);
            this.flowLayoutPanel1.Controls.Add(this.docStructTableRadio);
            this.flowLayoutPanel1.Controls.Add(this.docStructSemanticRadio);
            this.flowLayoutPanel1.Controls.Add(this.docStructSurveyButton);
            this.flowLayoutPanel1.Controls.Add(this.doLabelCheckTitleRadio);
            this.flowLayoutPanel1.Controls.Add(this.doLabelCheckButton);
            this.flowLayoutPanel1.Controls.Add(this.docSemanticsClearButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 356);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(786, 28);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // previewHtmlUpdateButton
            // 
            this.previewHtmlUpdateButton.Location = new System.Drawing.Point(3, 3);
            this.previewHtmlUpdateButton.Name = "previewHtmlUpdateButton";
            this.previewHtmlUpdateButton.Size = new System.Drawing.Size(128, 23);
            this.previewHtmlUpdateButton.TabIndex = 0;
            this.previewHtmlUpdateButton.Text = "セル値でプレビュー更新";
            this.previewHtmlUpdateButton.UseVisualStyleBackColor = true;
            this.previewHtmlUpdateButton.Click += new System.EventHandler(this.previewHtmlUpdateButton_Click);
            // 
            // docStructParagraphRadio
            // 
            this.docStructParagraphRadio.AutoSize = true;
            this.docStructParagraphRadio.Location = new System.Drawing.Point(137, 6);
            this.docStructParagraphRadio.Margin = new System.Windows.Forms.Padding(3, 6, 0, 3);
            this.docStructParagraphRadio.Name = "docStructParagraphRadio";
            this.docStructParagraphRadio.Size = new System.Drawing.Size(48, 16);
            this.docStructParagraphRadio.TabIndex = 3;
            this.docStructParagraphRadio.Text = "段落";
            this.docStructParagraphRadio.UseVisualStyleBackColor = true;
            // 
            // docStructBrRadio
            // 
            this.docStructBrRadio.AutoSize = true;
            this.docStructBrRadio.Location = new System.Drawing.Point(188, 6);
            this.docStructBrRadio.Margin = new System.Windows.Forms.Padding(3, 6, 0, 3);
            this.docStructBrRadio.Name = "docStructBrRadio";
            this.docStructBrRadio.Size = new System.Drawing.Size(48, 16);
            this.docStructBrRadio.TabIndex = 8;
            this.docStructBrRadio.Text = "改行";
            this.docStructBrRadio.UseVisualStyleBackColor = true;
            // 
            // docStructHeadingRadio
            // 
            this.docStructHeadingRadio.AutoSize = true;
            this.docStructHeadingRadio.Location = new System.Drawing.Point(239, 6);
            this.docStructHeadingRadio.Margin = new System.Windows.Forms.Padding(3, 6, 0, 3);
            this.docStructHeadingRadio.Name = "docStructHeadingRadio";
            this.docStructHeadingRadio.Size = new System.Drawing.Size(57, 16);
            this.docStructHeadingRadio.TabIndex = 4;
            this.docStructHeadingRadio.Text = "見出し";
            this.docStructHeadingRadio.UseVisualStyleBackColor = true;
            // 
            // docStructListRadio
            // 
            this.docStructListRadio.AutoSize = true;
            this.docStructListRadio.Location = new System.Drawing.Point(299, 6);
            this.docStructListRadio.Margin = new System.Windows.Forms.Padding(3, 6, 0, 3);
            this.docStructListRadio.Name = "docStructListRadio";
            this.docStructListRadio.Size = new System.Drawing.Size(48, 16);
            this.docStructListRadio.TabIndex = 2;
            this.docStructListRadio.Text = "リスト";
            this.docStructListRadio.UseVisualStyleBackColor = true;
            // 
            // docStructTableRadio
            // 
            this.docStructTableRadio.AutoSize = true;
            this.docStructTableRadio.Location = new System.Drawing.Point(350, 6);
            this.docStructTableRadio.Margin = new System.Windows.Forms.Padding(3, 6, 0, 3);
            this.docStructTableRadio.Name = "docStructTableRadio";
            this.docStructTableRadio.Size = new System.Drawing.Size(36, 16);
            this.docStructTableRadio.TabIndex = 5;
            this.docStructTableRadio.Text = "表";
            this.docStructTableRadio.UseVisualStyleBackColor = true;
            // 
            // docStructSemanticRadio
            // 
            this.docStructSemanticRadio.AutoSize = true;
            this.docStructSemanticRadio.Location = new System.Drawing.Point(389, 6);
            this.docStructSemanticRadio.Margin = new System.Windows.Forms.Padding(3, 6, 0, 3);
            this.docStructSemanticRadio.Name = "docStructSemanticRadio";
            this.docStructSemanticRadio.Size = new System.Drawing.Size(60, 16);
            this.docStructSemanticRadio.TabIndex = 10;
            this.docStructSemanticRadio.Text = "強調等";
            this.docStructSemanticRadio.UseVisualStyleBackColor = true;
            // 
            // docStructSurveyButton
            // 
            this.docStructSurveyButton.Location = new System.Drawing.Point(452, 3);
            this.docStructSurveyButton.Name = "docStructSurveyButton";
            this.docStructSurveyButton.Size = new System.Drawing.Size(88, 23);
            this.docStructSurveyButton.TabIndex = 1;
            this.docStructSurveyButton.Text = "文書構造解析";
            this.docStructSurveyButton.UseVisualStyleBackColor = true;
            this.docStructSurveyButton.Click += new System.EventHandler(this.docStructSurveyButton_Click);
            // 
            // doLabelCheckTitleRadio
            // 
            this.doLabelCheckTitleRadio.AutoSize = true;
            this.doLabelCheckTitleRadio.Location = new System.Drawing.Point(546, 6);
            this.doLabelCheckTitleRadio.Margin = new System.Windows.Forms.Padding(3, 6, 0, 3);
            this.doLabelCheckTitleRadio.Name = "doLabelCheckTitleRadio";
            this.doLabelCheckTitleRadio.Size = new System.Drawing.Size(68, 16);
            this.doLabelCheckTitleRadio.TabIndex = 9;
            this.doLabelCheckTitleRadio.Text = "title属性";
            this.doLabelCheckTitleRadio.UseVisualStyleBackColor = true;
            // 
            // doLabelCheckButton
            // 
            this.doLabelCheckButton.Location = new System.Drawing.Point(617, 3);
            this.doLabelCheckButton.Name = "doLabelCheckButton";
            this.doLabelCheckButton.Size = new System.Drawing.Size(75, 23);
            this.doLabelCheckButton.TabIndex = 7;
            this.doLabelCheckButton.Text = "ラベル解析";
            this.doLabelCheckButton.UseVisualStyleBackColor = true;
            this.doLabelCheckButton.Click += new System.EventHandler(this.doLabelCheckButton_Click);
            // 
            // docSemanticsClearButton
            // 
            this.docSemanticsClearButton.Location = new System.Drawing.Point(698, 3);
            this.docSemanticsClearButton.Name = "docSemanticsClearButton";
            this.docSemanticsClearButton.Size = new System.Drawing.Size(75, 23);
            this.docSemanticsClearButton.TabIndex = 6;
            this.docSemanticsClearButton.Text = "クリア";
            this.docSemanticsClearButton.UseVisualStyleBackColor = true;
            this.docSemanticsClearButton.Click += new System.EventHandler(this.docSemanticsClearButton_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.BrowserFormTopMostCheck);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 392);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(786, 28);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // BrowserFormTopMostCheck
            // 
            this.BrowserFormTopMostCheck.AutoSize = true;
            this.BrowserFormTopMostCheck.Location = new System.Drawing.Point(3, 3);
            this.BrowserFormTopMostCheck.Name = "BrowserFormTopMostCheck";
            this.BrowserFormTopMostCheck.Size = new System.Drawing.Size(93, 16);
            this.BrowserFormTopMostCheck.TabIndex = 0;
            this.BrowserFormTopMostCheck.Text = "常に前面表示";
            this.BrowserFormTopMostCheck.UseVisualStyleBackColor = true;
            this.BrowserFormTopMostCheck.Click += new System.EventHandler(this.BrowserFormTopMostCheck_Click);
            // 
            // BrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 423);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BrowserForm";
            this.Text = "簡易ブラウザー";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.WebBrowser browserControl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button previewHtmlUpdateButton;
        private System.Windows.Forms.CheckBox docStructListRadio;
        private System.Windows.Forms.CheckBox docStructParagraphRadio;
        private System.Windows.Forms.CheckBox docStructHeadingRadio;
        private System.Windows.Forms.CheckBox docStructTableRadio;
        private System.Windows.Forms.Button docStructSurveyButton;
        private System.Windows.Forms.Button docSemanticsClearButton;
        private System.Windows.Forms.Button doLabelCheckButton;
        private System.Windows.Forms.CheckBox docStructBrRadio;
        private System.Windows.Forms.CheckBox docStructSemanticRadio;
        private System.Windows.Forms.CheckBox doLabelCheckTitleRadio;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.CheckBox BrowserFormTopMostCheck;
    }
}