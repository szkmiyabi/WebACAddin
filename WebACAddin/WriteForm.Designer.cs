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
            this.pullFromCellDataButton = new System.Windows.Forms.Button();
            this.pushToCellDataButton = new System.Windows.Forms.Button();
            this.browseBaseCellDataButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.writeFormTopMostCheck = new System.Windows.Forms.CheckBox();
            this.opacityCheck = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.writeFormSnipetCombo = new System.Windows.Forms.ComboBox();
            this.writeFormSnipetInputButton = new System.Windows.Forms.Button();
            this.addCommentPreClearCheck = new System.Windows.Forms.CheckBox();
            this.writeFormSnipetAddButton = new System.Windows.Forms.Button();
            this.writeFormSnipetAddFromRibbonButton = new System.Windows.Forms.Button();
            this.writeFormSnipetAddFromFileButton = new System.Windows.Forms.Button();
            this.writeFormSnipetSaveButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.BrInputButton = new System.Windows.Forms.Button();
            this.tabStringDeleteButton = new System.Windows.Forms.Button();
            this.dateInsertButton = new System.Windows.Forms.Button();
            this.writeFormRegxCheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.writeSearchText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.writeReplaceText = new System.Windows.Forms.TextBox();
            this.writeReplaceButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.fontSizeLargeButton = new System.Windows.Forms.Button();
            this.fontSizeMinusButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.writeFormText, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel5, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.50138F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.49862F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(612, 410);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // writeFormText
            // 
            this.writeFormText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.writeFormText.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.writeFormText.Location = new System.Drawing.Point(3, 73);
            this.writeFormText.Multiline = true;
            this.writeFormText.Name = "writeFormText";
            this.writeFormText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.writeFormText.Size = new System.Drawing.Size(606, 264);
            this.writeFormText.TabIndex = 0;
            this.writeFormText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.writeFormText_KeyDown);
            this.writeFormText.Leave += new System.EventHandler(this.writeFormText_Leave);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pullFromCellDataButton);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.fontSizeLargeButton);
            this.flowLayoutPanel1.Controls.Add(this.fontSizeMinusButton);
            this.flowLayoutPanel1.Controls.Add(this.browseBaseCellDataButton);
            this.flowLayoutPanel1.Controls.Add(this.pushToCellDataButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(202, 343);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(407, 36);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // pullFromCellDataButton
            // 
            this.pullFromCellDataButton.Location = new System.Drawing.Point(3, 3);
            this.pullFromCellDataButton.Name = "pullFromCellDataButton";
            this.pullFromCellDataButton.Size = new System.Drawing.Size(59, 29);
            this.pullFromCellDataButton.TabIndex = 0;
            this.pullFromCellDataButton.Text = "読込";
            this.pullFromCellDataButton.UseVisualStyleBackColor = true;
            this.pullFromCellDataButton.Click += new System.EventHandler(this.pullFromCellDataButton_Click);
            // 
            // pushToCellDataButton
            // 
            this.pushToCellDataButton.Location = new System.Drawing.Point(335, 3);
            this.pushToCellDataButton.Name = "pushToCellDataButton";
            this.pushToCellDataButton.Size = new System.Drawing.Size(56, 29);
            this.pushToCellDataButton.TabIndex = 1;
            this.pushToCellDataButton.Text = "送信";
            this.pushToCellDataButton.UseVisualStyleBackColor = true;
            this.pushToCellDataButton.Click += new System.EventHandler(this.pushToCellDataButton_Click);
            // 
            // browseBaseCellDataButton
            // 
            this.browseBaseCellDataButton.Location = new System.Drawing.Point(238, 3);
            this.browseBaseCellDataButton.Margin = new System.Windows.Forms.Padding(34, 3, 3, 3);
            this.browseBaseCellDataButton.Name = "browseBaseCellDataButton";
            this.browseBaseCellDataButton.Size = new System.Drawing.Size(91, 29);
            this.browseBaseCellDataButton.TabIndex = 6;
            this.browseBaseCellDataButton.Text = "省略行表示";
            this.browseBaseCellDataButton.UseVisualStyleBackColor = true;
            this.browseBaseCellDataButton.Click += new System.EventHandler(this.browseBaseCellDataButton_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.writeFormTopMostCheck);
            this.flowLayoutPanel3.Controls.Add(this.opacityCheck);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 385);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(606, 22);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // writeFormTopMostCheck
            // 
            this.writeFormTopMostCheck.AutoSize = true;
            this.writeFormTopMostCheck.Location = new System.Drawing.Point(3, 3);
            this.writeFormTopMostCheck.Name = "writeFormTopMostCheck";
            this.writeFormTopMostCheck.Size = new System.Drawing.Size(48, 16);
            this.writeFormTopMostCheck.TabIndex = 0;
            this.writeFormTopMostCheck.Text = "前面";
            this.writeFormTopMostCheck.UseVisualStyleBackColor = true;
            this.writeFormTopMostCheck.Click += new System.EventHandler(this.writeFormTopMostCheck_Click);
            // 
            // opacityCheck
            // 
            this.opacityCheck.AutoSize = true;
            this.opacityCheck.Location = new System.Drawing.Point(57, 3);
            this.opacityCheck.Name = "opacityCheck";
            this.opacityCheck.Size = new System.Drawing.Size(48, 16);
            this.opacityCheck.TabIndex = 1;
            this.opacityCheck.Text = "透過";
            this.opacityCheck.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.writeFormSnipetCombo);
            this.flowLayoutPanel4.Controls.Add(this.writeFormSnipetInputButton);
            this.flowLayoutPanel4.Controls.Add(this.addCommentPreClearCheck);
            this.flowLayoutPanel4.Controls.Add(this.writeFormSnipetAddButton);
            this.flowLayoutPanel4.Controls.Add(this.writeFormSnipetAddFromRibbonButton);
            this.flowLayoutPanel4.Controls.Add(this.writeFormSnipetAddFromFileButton);
            this.flowLayoutPanel4.Controls.Add(this.writeFormSnipetSaveButton);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(606, 28);
            this.flowLayoutPanel4.TabIndex = 4;
            // 
            // writeFormSnipetCombo
            // 
            this.writeFormSnipetCombo.FormattingEnabled = true;
            this.writeFormSnipetCombo.Location = new System.Drawing.Point(6, 3);
            this.writeFormSnipetCombo.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.writeFormSnipetCombo.Name = "writeFormSnipetCombo";
            this.writeFormSnipetCombo.Size = new System.Drawing.Size(147, 20);
            this.writeFormSnipetCombo.TabIndex = 3;
            // 
            // writeFormSnipetInputButton
            // 
            this.writeFormSnipetInputButton.Location = new System.Drawing.Point(159, 3);
            this.writeFormSnipetInputButton.Name = "writeFormSnipetInputButton";
            this.writeFormSnipetInputButton.Size = new System.Drawing.Size(67, 23);
            this.writeFormSnipetInputButton.TabIndex = 4;
            this.writeFormSnipetInputButton.Text = "語句挿入";
            this.writeFormSnipetInputButton.UseVisualStyleBackColor = true;
            this.writeFormSnipetInputButton.Click += new System.EventHandler(this.writeFormSnipetInputButton_Click);
            // 
            // addCommentPreClearCheck
            // 
            this.addCommentPreClearCheck.AutoSize = true;
            this.addCommentPreClearCheck.Location = new System.Drawing.Point(235, 6);
            this.addCommentPreClearCheck.Margin = new System.Windows.Forms.Padding(6, 6, 0, 3);
            this.addCommentPreClearCheck.Name = "addCommentPreClearCheck";
            this.addCommentPreClearCheck.Size = new System.Drawing.Size(102, 16);
            this.addCommentPreClearCheck.TabIndex = 6;
            this.addCommentPreClearCheck.Text = "全クリアして追加";
            this.addCommentPreClearCheck.UseVisualStyleBackColor = true;
            // 
            // writeFormSnipetAddButton
            // 
            this.writeFormSnipetAddButton.Location = new System.Drawing.Point(340, 3);
            this.writeFormSnipetAddButton.Name = "writeFormSnipetAddButton";
            this.writeFormSnipetAddButton.Size = new System.Drawing.Size(69, 23);
            this.writeFormSnipetAddButton.TabIndex = 5;
            this.writeFormSnipetAddButton.Text = "選択範囲";
            this.writeFormSnipetAddButton.UseVisualStyleBackColor = true;
            this.writeFormSnipetAddButton.Click += new System.EventHandler(this.writeFormSnipetAddButton_Click);
            // 
            // writeFormSnipetAddFromRibbonButton
            // 
            this.writeFormSnipetAddFromRibbonButton.Location = new System.Drawing.Point(415, 3);
            this.writeFormSnipetAddFromRibbonButton.Name = "writeFormSnipetAddFromRibbonButton";
            this.writeFormSnipetAddFromRibbonButton.Size = new System.Drawing.Size(48, 23);
            this.writeFormSnipetAddFromRibbonButton.TabIndex = 8;
            this.writeFormSnipetAddFromRibbonButton.Text = "リボン";
            this.writeFormSnipetAddFromRibbonButton.UseVisualStyleBackColor = true;
            this.writeFormSnipetAddFromRibbonButton.Click += new System.EventHandler(this.writeFormSnipetAddFromRibbonButton_Click);
            // 
            // writeFormSnipetAddFromFileButton
            // 
            this.writeFormSnipetAddFromFileButton.Location = new System.Drawing.Point(469, 3);
            this.writeFormSnipetAddFromFileButton.Name = "writeFormSnipetAddFromFileButton";
            this.writeFormSnipetAddFromFileButton.Size = new System.Drawing.Size(58, 23);
            this.writeFormSnipetAddFromFileButton.TabIndex = 7;
            this.writeFormSnipetAddFromFileButton.Text = "ファイル";
            this.writeFormSnipetAddFromFileButton.UseVisualStyleBackColor = true;
            this.writeFormSnipetAddFromFileButton.Click += new System.EventHandler(this.writeFormSnipetAddFromFileButton_Click);
            // 
            // writeFormSnipetSaveButton
            // 
            this.writeFormSnipetSaveButton.Location = new System.Drawing.Point(533, 3);
            this.writeFormSnipetSaveButton.Name = "writeFormSnipetSaveButton";
            this.writeFormSnipetSaveButton.Size = new System.Drawing.Size(47, 23);
            this.writeFormSnipetSaveButton.TabIndex = 11;
            this.writeFormSnipetSaveButton.Text = "保存";
            this.writeFormSnipetSaveButton.UseVisualStyleBackColor = true;
            this.writeFormSnipetSaveButton.Click += new System.EventHandler(this.writeFormSnipetSaveButton_Click);
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.BrInputButton);
            this.flowLayoutPanel5.Controls.Add(this.tabStringDeleteButton);
            this.flowLayoutPanel5.Controls.Add(this.dateInsertButton);
            this.flowLayoutPanel5.Controls.Add(this.writeFormRegxCheck);
            this.flowLayoutPanel5.Controls.Add(this.label1);
            this.flowLayoutPanel5.Controls.Add(this.writeSearchText);
            this.flowLayoutPanel5.Controls.Add(this.label2);
            this.flowLayoutPanel5.Controls.Add(this.writeReplaceText);
            this.flowLayoutPanel5.Controls.Add(this.writeReplaceButton);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 37);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(606, 30);
            this.flowLayoutPanel5.TabIndex = 5;
            // 
            // BrInputButton
            // 
            this.BrInputButton.Location = new System.Drawing.Point(3, 3);
            this.BrInputButton.Name = "BrInputButton";
            this.BrInputButton.Size = new System.Drawing.Size(46, 23);
            this.BrInputButton.TabIndex = 5;
            this.BrInputButton.Text = "改行";
            this.BrInputButton.UseVisualStyleBackColor = true;
            this.BrInputButton.Click += new System.EventHandler(this.BrInputButton_Click);
            // 
            // tabStringDeleteButton
            // 
            this.tabStringDeleteButton.Location = new System.Drawing.Point(55, 3);
            this.tabStringDeleteButton.Name = "tabStringDeleteButton";
            this.tabStringDeleteButton.Size = new System.Drawing.Size(59, 23);
            this.tabStringDeleteButton.TabIndex = 2;
            this.tabStringDeleteButton.Text = "タブ除去";
            this.tabStringDeleteButton.UseVisualStyleBackColor = true;
            this.tabStringDeleteButton.Click += new System.EventHandler(this.tabStringDeleteButton_Click);
            // 
            // dateInsertButton
            // 
            this.dateInsertButton.Location = new System.Drawing.Point(120, 3);
            this.dateInsertButton.Name = "dateInsertButton";
            this.dateInsertButton.Size = new System.Drawing.Size(41, 23);
            this.dateInsertButton.TabIndex = 8;
            this.dateInsertButton.Text = "日付";
            this.dateInsertButton.UseVisualStyleBackColor = true;
            this.dateInsertButton.Click += new System.EventHandler(this.dateInsertButton_Click);
            // 
            // writeFormRegxCheck
            // 
            this.writeFormRegxCheck.AutoSize = true;
            this.writeFormRegxCheck.Location = new System.Drawing.Point(170, 6);
            this.writeFormRegxCheck.Margin = new System.Windows.Forms.Padding(6, 6, 3, 3);
            this.writeFormRegxCheck.Name = "writeFormRegxCheck";
            this.writeFormRegxCheck.Size = new System.Drawing.Size(72, 16);
            this.writeFormRegxCheck.TabIndex = 0;
            this.writeFormRegxCheck.Text = "正規表現";
            this.writeFormRegxCheck.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 8, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "検索:";
            // 
            // writeSearchText
            // 
            this.writeSearchText.Location = new System.Drawing.Point(282, 4);
            this.writeSearchText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.writeSearchText.Name = "writeSearchText";
            this.writeSearchText.Size = new System.Drawing.Size(99, 19);
            this.writeSearchText.TabIndex = 1;
            this.writeSearchText.Leave += new System.EventHandler(this.writeSearchText_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 8, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "置換:";
            // 
            // writeReplaceText
            // 
            this.writeReplaceText.Location = new System.Drawing.Point(421, 4);
            this.writeReplaceText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.writeReplaceText.Name = "writeReplaceText";
            this.writeReplaceText.Size = new System.Drawing.Size(103, 19);
            this.writeReplaceText.TabIndex = 2;
            this.writeReplaceText.Leave += new System.EventHandler(this.writeReplaceText_Leave);
            // 
            // writeReplaceButton
            // 
            this.writeReplaceButton.Location = new System.Drawing.Point(530, 3);
            this.writeReplaceButton.Name = "writeReplaceButton";
            this.writeReplaceButton.Size = new System.Drawing.Size(55, 23);
            this.writeReplaceButton.TabIndex = 3;
            this.writeReplaceButton.Text = "置換";
            this.writeReplaceButton.UseVisualStyleBackColor = true;
            this.writeReplaceButton.Click += new System.EventHandler(this.writeReplaceButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 12, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "文字サイズ";
            // 
            // fontSizeLargeButton
            // 
            this.fontSizeLargeButton.Location = new System.Drawing.Point(137, 5);
            this.fontSizeLargeButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.fontSizeLargeButton.Name = "fontSizeLargeButton";
            this.fontSizeLargeButton.Size = new System.Drawing.Size(31, 23);
            this.fontSizeLargeButton.TabIndex = 8;
            this.fontSizeLargeButton.Text = "＋";
            this.fontSizeLargeButton.UseVisualStyleBackColor = true;
            this.fontSizeLargeButton.Click += new System.EventHandler(this.fontSizeLargeButton_Click);
            // 
            // fontSizeMinusButton
            // 
            this.fontSizeMinusButton.Location = new System.Drawing.Point(174, 5);
            this.fontSizeMinusButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.fontSizeMinusButton.Name = "fontSizeMinusButton";
            this.fontSizeMinusButton.Size = new System.Drawing.Size(27, 23);
            this.fontSizeMinusButton.TabIndex = 9;
            this.fontSizeMinusButton.Text = "－";
            this.fontSizeMinusButton.UseVisualStyleBackColor = true;
            this.fontSizeMinusButton.Click += new System.EventHandler(this.fontSizeMinusButton_Click);
            // 
            // WriteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 410);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "WriteForm";
            this.ShowIcon = false;
            this.Text = "セル編集";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
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
        private System.Windows.Forms.Button writeFormSnipetAddButton;
        private System.Windows.Forms.CheckBox addCommentPreClearCheck;
        private System.Windows.Forms.Button writeFormSnipetAddFromFileButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button BrInputButton;
        private System.Windows.Forms.Button writeFormSnipetAddFromRibbonButton;
        private System.Windows.Forms.Button writeFormSnipetSaveButton;
        private System.Windows.Forms.CheckBox writeFormTopMostCheck;
        private System.Windows.Forms.Button browseBaseCellDataButton;
        private System.Windows.Forms.CheckBox opacityCheck;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Button dateInsertButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button fontSizeLargeButton;
        private System.Windows.Forms.Button fontSizeMinusButton;
    }
}