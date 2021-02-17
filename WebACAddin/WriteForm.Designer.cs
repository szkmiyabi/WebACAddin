namespace WebACAddin
{
    partial class WriteForm
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
            this.writeFormText = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.writeFormSnipetCombo = new System.Windows.Forms.ComboBox();
            this.writeFormSnipetInputButton = new System.Windows.Forms.Button();
            this.BrInputButton = new System.Windows.Forms.Button();
            this.tabStringDeleteButton = new System.Windows.Forms.Button();
            this.pullFromCellDataButton = new System.Windows.Forms.Button();
            this.pushToCellDataButton = new System.Windows.Forms.Button();
            this.browseBaseCellDataButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.addCommentPreClearCheck = new System.Windows.Forms.CheckBox();
            this.writeFormSnipetAddButton = new System.Windows.Forms.Button();
            this.writeFormSnipetAddFromRibbonButton = new System.Windows.Forms.Button();
            this.writeFormSnipetAddFromFileButton = new System.Windows.Forms.Button();
            this.delCommentSingleButton = new System.Windows.Forms.Button();
            this.delCommentAllButton = new System.Windows.Forms.Button();
            this.writeFormSnipetSaveButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.writeFormRegxCheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.writeSearchText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.writeReplaceText = new System.Windows.Forms.TextBox();
            this.writeReplaceButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.writeFormTopMostCheck = new System.Windows.Forms.CheckBox();
            this.opacityCheck = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.writeFormText, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel4, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.46154F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.53846F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(694, 509);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // writeFormText
            // 
            this.writeFormText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.writeFormText.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.writeFormText.Location = new System.Drawing.Point(3, 3);
            this.writeFormText.Multiline = true;
            this.writeFormText.Name = "writeFormText";
            this.writeFormText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.writeFormText.Size = new System.Drawing.Size(688, 339);
            this.writeFormText.TabIndex = 0;
            this.writeFormText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.writeFormText_KeyDown);
            this.writeFormText.Leave += new System.EventHandler(this.writeFormText_Leave);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.writeFormSnipetCombo);
            this.flowLayoutPanel1.Controls.Add(this.writeFormSnipetInputButton);
            this.flowLayoutPanel1.Controls.Add(this.BrInputButton);
            this.flowLayoutPanel1.Controls.Add(this.tabStringDeleteButton);
            this.flowLayoutPanel1.Controls.Add(this.pullFromCellDataButton);
            this.flowLayoutPanel1.Controls.Add(this.pushToCellDataButton);
            this.flowLayoutPanel1.Controls.Add(this.browseBaseCellDataButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 348);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(688, 38);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // writeFormSnipetCombo
            // 
            this.writeFormSnipetCombo.FormattingEnabled = true;
            this.writeFormSnipetCombo.Items.AddRange(new object[] {
            "※追記",
            "※削除",
            "※修正",
            "(<p.*?>)(.+?)(</p>)",
            "(alt=\")(.+?)(\")"});
            this.writeFormSnipetCombo.Location = new System.Drawing.Point(7, 3);
            this.writeFormSnipetCombo.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.writeFormSnipetCombo.Name = "writeFormSnipetCombo";
            this.writeFormSnipetCombo.Size = new System.Drawing.Size(171, 22);
            this.writeFormSnipetCombo.TabIndex = 3;
            // 
            // writeFormSnipetInputButton
            // 
            this.writeFormSnipetInputButton.Location = new System.Drawing.Point(184, 3);
            this.writeFormSnipetInputButton.Name = "writeFormSnipetInputButton";
            this.writeFormSnipetInputButton.Size = new System.Drawing.Size(78, 27);
            this.writeFormSnipetInputButton.TabIndex = 4;
            this.writeFormSnipetInputButton.Text = "語句挿入";
            this.writeFormSnipetInputButton.UseVisualStyleBackColor = true;
            this.writeFormSnipetInputButton.Click += new System.EventHandler(this.writeFormSnipetInputButton_Click);
            // 
            // BrInputButton
            // 
            this.BrInputButton.Location = new System.Drawing.Point(268, 3);
            this.BrInputButton.Name = "BrInputButton";
            this.BrInputButton.Size = new System.Drawing.Size(54, 27);
            this.BrInputButton.TabIndex = 5;
            this.BrInputButton.Text = "改行";
            this.BrInputButton.UseVisualStyleBackColor = true;
            this.BrInputButton.Click += new System.EventHandler(this.BrInputButton_Click);
            // 
            // tabStringDeleteButton
            // 
            this.tabStringDeleteButton.Location = new System.Drawing.Point(328, 3);
            this.tabStringDeleteButton.Name = "tabStringDeleteButton";
            this.tabStringDeleteButton.Size = new System.Drawing.Size(69, 27);
            this.tabStringDeleteButton.TabIndex = 2;
            this.tabStringDeleteButton.Text = "タブ除去";
            this.tabStringDeleteButton.UseVisualStyleBackColor = true;
            this.tabStringDeleteButton.Click += new System.EventHandler(this.tabStringDeleteButton_Click);
            // 
            // pullFromCellDataButton
            // 
            this.pullFromCellDataButton.Location = new System.Drawing.Point(426, 3);
            this.pullFromCellDataButton.Margin = new System.Windows.Forms.Padding(26, 3, 3, 3);
            this.pullFromCellDataButton.Name = "pullFromCellDataButton";
            this.pullFromCellDataButton.Size = new System.Drawing.Size(69, 27);
            this.pullFromCellDataButton.TabIndex = 0;
            this.pullFromCellDataButton.Text = "読込";
            this.pullFromCellDataButton.UseVisualStyleBackColor = true;
            this.pullFromCellDataButton.Click += new System.EventHandler(this.pullFromCellDataButton_Click);
            // 
            // pushToCellDataButton
            // 
            this.pushToCellDataButton.Location = new System.Drawing.Point(501, 3);
            this.pushToCellDataButton.Name = "pushToCellDataButton";
            this.pushToCellDataButton.Size = new System.Drawing.Size(65, 27);
            this.pushToCellDataButton.TabIndex = 1;
            this.pushToCellDataButton.Text = "送信";
            this.pushToCellDataButton.UseVisualStyleBackColor = true;
            this.pushToCellDataButton.Click += new System.EventHandler(this.pushToCellDataButton_Click);
            // 
            // browseBaseCellDataButton
            // 
            this.browseBaseCellDataButton.Location = new System.Drawing.Point(572, 3);
            this.browseBaseCellDataButton.Name = "browseBaseCellDataButton";
            this.browseBaseCellDataButton.Size = new System.Drawing.Size(99, 27);
            this.browseBaseCellDataButton.TabIndex = 6;
            this.browseBaseCellDataButton.Text = "省略行表示";
            this.browseBaseCellDataButton.UseVisualStyleBackColor = true;
            this.browseBaseCellDataButton.Click += new System.EventHandler(this.browseBaseCellDataButton_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.addCommentPreClearCheck);
            this.flowLayoutPanel2.Controls.Add(this.writeFormSnipetAddButton);
            this.flowLayoutPanel2.Controls.Add(this.writeFormSnipetAddFromRibbonButton);
            this.flowLayoutPanel2.Controls.Add(this.writeFormSnipetAddFromFileButton);
            this.flowLayoutPanel2.Controls.Add(this.delCommentSingleButton);
            this.flowLayoutPanel2.Controls.Add(this.delCommentAllButton);
            this.flowLayoutPanel2.Controls.Add(this.writeFormSnipetSaveButton);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 392);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(688, 37);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // addCommentPreClearCheck
            // 
            this.addCommentPreClearCheck.AutoSize = true;
            this.addCommentPreClearCheck.Location = new System.Drawing.Point(7, 7);
            this.addCommentPreClearCheck.Margin = new System.Windows.Forms.Padding(7, 7, 0, 3);
            this.addCommentPreClearCheck.Name = "addCommentPreClearCheck";
            this.addCommentPreClearCheck.Size = new System.Drawing.Size(124, 19);
            this.addCommentPreClearCheck.TabIndex = 6;
            this.addCommentPreClearCheck.Text = "全クリアして追加";
            this.addCommentPreClearCheck.UseVisualStyleBackColor = true;
            // 
            // writeFormSnipetAddButton
            // 
            this.writeFormSnipetAddButton.Location = new System.Drawing.Point(134, 3);
            this.writeFormSnipetAddButton.Name = "writeFormSnipetAddButton";
            this.writeFormSnipetAddButton.Size = new System.Drawing.Size(131, 27);
            this.writeFormSnipetAddButton.TabIndex = 5;
            this.writeFormSnipetAddButton.Text = "選択範囲から追加";
            this.writeFormSnipetAddButton.UseVisualStyleBackColor = true;
            this.writeFormSnipetAddButton.Click += new System.EventHandler(this.writeFormSnipetAddButton_Click);
            // 
            // writeFormSnipetAddFromRibbonButton
            // 
            this.writeFormSnipetAddFromRibbonButton.Location = new System.Drawing.Point(271, 3);
            this.writeFormSnipetAddFromRibbonButton.Name = "writeFormSnipetAddFromRibbonButton";
            this.writeFormSnipetAddFromRibbonButton.Size = new System.Drawing.Size(68, 27);
            this.writeFormSnipetAddFromRibbonButton.TabIndex = 8;
            this.writeFormSnipetAddFromRibbonButton.Text = "リボンから";
            this.writeFormSnipetAddFromRibbonButton.UseVisualStyleBackColor = true;
            this.writeFormSnipetAddFromRibbonButton.Click += new System.EventHandler(this.writeFormSnipetAddFromRibbonButton_Click);
            // 
            // writeFormSnipetAddFromFileButton
            // 
            this.writeFormSnipetAddFromFileButton.Location = new System.Drawing.Point(345, 3);
            this.writeFormSnipetAddFromFileButton.Name = "writeFormSnipetAddFromFileButton";
            this.writeFormSnipetAddFromFileButton.Size = new System.Drawing.Size(80, 27);
            this.writeFormSnipetAddFromFileButton.TabIndex = 7;
            this.writeFormSnipetAddFromFileButton.Text = "ファイルから";
            this.writeFormSnipetAddFromFileButton.UseVisualStyleBackColor = true;
            this.writeFormSnipetAddFromFileButton.Click += new System.EventHandler(this.writeFormSnipetAddFromFileButton_Click);
            // 
            // delCommentSingleButton
            // 
            this.delCommentSingleButton.Location = new System.Drawing.Point(431, 3);
            this.delCommentSingleButton.Name = "delCommentSingleButton";
            this.delCommentSingleButton.Size = new System.Drawing.Size(49, 27);
            this.delCommentSingleButton.TabIndex = 9;
            this.delCommentSingleButton.Text = "削除";
            this.delCommentSingleButton.UseVisualStyleBackColor = true;
            this.delCommentSingleButton.Click += new System.EventHandler(this.delCommentSingleButton_Click);
            // 
            // delCommentAllButton
            // 
            this.delCommentAllButton.Location = new System.Drawing.Point(486, 3);
            this.delCommentAllButton.Name = "delCommentAllButton";
            this.delCommentAllButton.Size = new System.Drawing.Size(73, 27);
            this.delCommentAllButton.TabIndex = 10;
            this.delCommentAllButton.Text = "全件削除";
            this.delCommentAllButton.UseVisualStyleBackColor = true;
            this.delCommentAllButton.Click += new System.EventHandler(this.delCommentAllButton_Click);
            // 
            // writeFormSnipetSaveButton
            // 
            this.writeFormSnipetSaveButton.Location = new System.Drawing.Point(565, 3);
            this.writeFormSnipetSaveButton.Name = "writeFormSnipetSaveButton";
            this.writeFormSnipetSaveButton.Size = new System.Drawing.Size(55, 27);
            this.writeFormSnipetSaveButton.TabIndex = 11;
            this.writeFormSnipetSaveButton.Text = "保存";
            this.writeFormSnipetSaveButton.UseVisualStyleBackColor = true;
            this.writeFormSnipetSaveButton.Click += new System.EventHandler(this.writeFormSnipetSaveButton_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.writeFormRegxCheck);
            this.flowLayoutPanel3.Controls.Add(this.label1);
            this.flowLayoutPanel3.Controls.Add(this.writeSearchText);
            this.flowLayoutPanel3.Controls.Add(this.label2);
            this.flowLayoutPanel3.Controls.Add(this.writeReplaceText);
            this.flowLayoutPanel3.Controls.Add(this.writeReplaceButton);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 435);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(688, 37);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // writeFormRegxCheck
            // 
            this.writeFormRegxCheck.AutoSize = true;
            this.writeFormRegxCheck.Location = new System.Drawing.Point(7, 7);
            this.writeFormRegxCheck.Margin = new System.Windows.Forms.Padding(7, 7, 3, 3);
            this.writeFormRegxCheck.Name = "writeFormRegxCheck";
            this.writeFormRegxCheck.Size = new System.Drawing.Size(86, 19);
            this.writeFormRegxCheck.TabIndex = 0;
            this.writeFormRegxCheck.Text = "正規表現";
            this.writeFormRegxCheck.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 9, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "検索:";
            // 
            // writeSearchText
            // 
            this.writeSearchText.Location = new System.Drawing.Point(142, 5);
            this.writeSearchText.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.writeSearchText.Name = "writeSearchText";
            this.writeSearchText.Size = new System.Drawing.Size(167, 21);
            this.writeSearchText.TabIndex = 1;
            this.writeSearchText.Leave += new System.EventHandler(this.writeSearchText_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 9, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "置換:";
            // 
            // writeReplaceText
            // 
            this.writeReplaceText.Location = new System.Drawing.Point(358, 5);
            this.writeReplaceText.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.writeReplaceText.Name = "writeReplaceText";
            this.writeReplaceText.Size = new System.Drawing.Size(166, 21);
            this.writeReplaceText.TabIndex = 2;
            this.writeReplaceText.Leave += new System.EventHandler(this.writeReplaceText_Leave);
            // 
            // writeReplaceButton
            // 
            this.writeReplaceButton.Location = new System.Drawing.Point(530, 3);
            this.writeReplaceButton.Name = "writeReplaceButton";
            this.writeReplaceButton.Size = new System.Drawing.Size(78, 27);
            this.writeReplaceButton.TabIndex = 3;
            this.writeReplaceButton.Text = "置換";
            this.writeReplaceButton.UseVisualStyleBackColor = true;
            this.writeReplaceButton.Click += new System.EventHandler(this.writeReplaceButton_Click);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.writeFormTopMostCheck);
            this.flowLayoutPanel4.Controls.Add(this.opacityCheck);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 478);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(233, 27);
            this.flowLayoutPanel4.TabIndex = 4;
            // 
            // writeFormTopMostCheck
            // 
            this.writeFormTopMostCheck.AutoSize = true;
            this.writeFormTopMostCheck.Location = new System.Drawing.Point(3, 3);
            this.writeFormTopMostCheck.Name = "writeFormTopMostCheck";
            this.writeFormTopMostCheck.Size = new System.Drawing.Size(113, 19);
            this.writeFormTopMostCheck.TabIndex = 0;
            this.writeFormTopMostCheck.Text = "常に前面表示";
            this.writeFormTopMostCheck.UseVisualStyleBackColor = true;
            this.writeFormTopMostCheck.Click += new System.EventHandler(this.writeFormTopMostCheck_Click);
            // 
            // opacityCheck
            // 
            this.opacityCheck.AutoSize = true;
            this.opacityCheck.Location = new System.Drawing.Point(122, 3);
            this.opacityCheck.Name = "opacityCheck";
            this.opacityCheck.Size = new System.Drawing.Size(56, 19);
            this.opacityCheck.TabIndex = 1;
            this.opacityCheck.Text = "透過";
            this.opacityCheck.UseVisualStyleBackColor = true;
            // 
            // WriteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 509);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "WriteForm";
            this.ShowIcon = false;
            this.Text = "セル編集";
            this.Activated += new System.EventHandler(this.WriteForm_Activated);
            this.Deactivate += new System.EventHandler(this.WriteForm_Deactivate);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button pullFromCellDataButton;
        private System.Windows.Forms.Button pushToCellDataButton;
        private System.Windows.Forms.CheckBox writeFormRegxCheck;
        private System.Windows.Forms.TextBox writeSearchText;
        private System.Windows.Forms.Button writeReplaceButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox writeReplaceText;
        public System.Windows.Forms.TextBox writeFormText;
        private System.Windows.Forms.Button tabStringDeleteButton;
        private System.Windows.Forms.ComboBox writeFormSnipetCombo;
        private System.Windows.Forms.Button writeFormSnipetInputButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button writeFormSnipetAddButton;
        private System.Windows.Forms.CheckBox addCommentPreClearCheck;
        private System.Windows.Forms.Button writeFormSnipetAddFromFileButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button BrInputButton;
        private System.Windows.Forms.Button writeFormSnipetAddFromRibbonButton;
        private System.Windows.Forms.Button delCommentSingleButton;
        private System.Windows.Forms.Button delCommentAllButton;
        private System.Windows.Forms.Button writeFormSnipetSaveButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.CheckBox writeFormTopMostCheck;
        private System.Windows.Forms.Button browseBaseCellDataButton;
        private System.Windows.Forms.CheckBox opacityCheck;
    }
}