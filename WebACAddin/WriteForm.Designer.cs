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
            this.tabStringDeleteButton = new System.Windows.Forms.Button();
            this.writeFormSnipetCombo = new System.Windows.Forms.ComboBox();
            this.writeFormSnipetInputButton = new System.Windows.Forms.Button();
            this.writeFormSnipetAddButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.writeFormRegxCheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.writeSearchText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.writeReplaceText = new System.Windows.Forms.TextBox();
            this.writeReplaceButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.writeFormText, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.7347F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.26531F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(555, 291);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // writeFormText
            // 
            this.writeFormText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.writeFormText.Location = new System.Drawing.Point(3, 3);
            this.writeFormText.Multiline = true;
            this.writeFormText.Name = "writeFormText";
            this.writeFormText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.writeFormText.Size = new System.Drawing.Size(549, 218);
            this.writeFormText.TabIndex = 0;
            this.writeFormText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.writeFormText_KeyDown);
            this.writeFormText.Leave += new System.EventHandler(this.writeFormText_Leave);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pullFromCellDataButton);
            this.flowLayoutPanel1.Controls.Add(this.pushToCellDataButton);
            this.flowLayoutPanel1.Controls.Add(this.tabStringDeleteButton);
            this.flowLayoutPanel1.Controls.Add(this.writeFormSnipetCombo);
            this.flowLayoutPanel1.Controls.Add(this.writeFormSnipetInputButton);
            this.flowLayoutPanel1.Controls.Add(this.writeFormSnipetAddButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 227);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(549, 28);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // pullFromCellDataButton
            // 
            this.pullFromCellDataButton.Location = new System.Drawing.Point(3, 3);
            this.pullFromCellDataButton.Name = "pullFromCellDataButton";
            this.pullFromCellDataButton.Size = new System.Drawing.Size(89, 23);
            this.pullFromCellDataButton.TabIndex = 0;
            this.pullFromCellDataButton.Text = "セルから読込";
            this.pullFromCellDataButton.UseVisualStyleBackColor = true;
            this.pullFromCellDataButton.Click += new System.EventHandler(this.pullFromCellDataButton_Click);
            // 
            // pushToCellDataButton
            // 
            this.pushToCellDataButton.Location = new System.Drawing.Point(98, 3);
            this.pushToCellDataButton.Name = "pushToCellDataButton";
            this.pushToCellDataButton.Size = new System.Drawing.Size(75, 23);
            this.pushToCellDataButton.TabIndex = 1;
            this.pushToCellDataButton.Text = "セルに送信";
            this.pushToCellDataButton.UseVisualStyleBackColor = true;
            this.pushToCellDataButton.Click += new System.EventHandler(this.pushToCellDataButton_Click);
            // 
            // tabStringDeleteButton
            // 
            this.tabStringDeleteButton.Location = new System.Drawing.Point(179, 3);
            this.tabStringDeleteButton.Name = "tabStringDeleteButton";
            this.tabStringDeleteButton.Size = new System.Drawing.Size(59, 23);
            this.tabStringDeleteButton.TabIndex = 2;
            this.tabStringDeleteButton.Text = "タブ除去";
            this.tabStringDeleteButton.UseVisualStyleBackColor = true;
            this.tabStringDeleteButton.Click += new System.EventHandler(this.tabStringDeleteButton_Click);
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
            this.writeFormSnipetCombo.Location = new System.Drawing.Point(244, 3);
            this.writeFormSnipetCombo.Name = "writeFormSnipetCombo";
            this.writeFormSnipetCombo.Size = new System.Drawing.Size(147, 20);
            this.writeFormSnipetCombo.TabIndex = 3;
            // 
            // writeFormSnipetInputButton
            // 
            this.writeFormSnipetInputButton.Location = new System.Drawing.Point(397, 3);
            this.writeFormSnipetInputButton.Name = "writeFormSnipetInputButton";
            this.writeFormSnipetInputButton.Size = new System.Drawing.Size(67, 23);
            this.writeFormSnipetInputButton.TabIndex = 4;
            this.writeFormSnipetInputButton.Text = "語句挿入";
            this.writeFormSnipetInputButton.UseVisualStyleBackColor = true;
            this.writeFormSnipetInputButton.Click += new System.EventHandler(this.writeFormSnipetInputButton_Click);
            // 
            // writeFormSnipetAddButton
            // 
            this.writeFormSnipetAddButton.Location = new System.Drawing.Point(470, 3);
            this.writeFormSnipetAddButton.Name = "writeFormSnipetAddButton";
            this.writeFormSnipetAddButton.Size = new System.Drawing.Size(55, 23);
            this.writeFormSnipetAddButton.TabIndex = 5;
            this.writeFormSnipetAddButton.Text = "値追加";
            this.writeFormSnipetAddButton.UseVisualStyleBackColor = true;
            this.writeFormSnipetAddButton.Click += new System.EventHandler(this.writeFormSnipetAddButton_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.writeFormRegxCheck);
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.writeSearchText);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.writeReplaceText);
            this.flowLayoutPanel2.Controls.Add(this.writeReplaceButton);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 261);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(549, 27);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // writeFormRegxCheck
            // 
            this.writeFormRegxCheck.AutoSize = true;
            this.writeFormRegxCheck.Location = new System.Drawing.Point(15, 6);
            this.writeFormRegxCheck.Margin = new System.Windows.Forms.Padding(15, 6, 3, 3);
            this.writeFormRegxCheck.Name = "writeFormRegxCheck";
            this.writeFormRegxCheck.Size = new System.Drawing.Size(72, 16);
            this.writeFormRegxCheck.TabIndex = 0;
            this.writeFormRegxCheck.Text = "正規表現";
            this.writeFormRegxCheck.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 8, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "検索:";
            // 
            // writeSearchText
            // 
            this.writeSearchText.Location = new System.Drawing.Point(127, 4);
            this.writeSearchText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.writeSearchText.Name = "writeSearchText";
            this.writeSearchText.Size = new System.Drawing.Size(144, 19);
            this.writeSearchText.TabIndex = 1;
            this.writeSearchText.Leave += new System.EventHandler(this.writeSearchText_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 8, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "置換:";
            // 
            // writeReplaceText
            // 
            this.writeReplaceText.Location = new System.Drawing.Point(311, 4);
            this.writeReplaceText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.writeReplaceText.Name = "writeReplaceText";
            this.writeReplaceText.Size = new System.Drawing.Size(143, 19);
            this.writeReplaceText.TabIndex = 2;
            this.writeReplaceText.Leave += new System.EventHandler(this.writeReplaceText_Leave);
            // 
            // writeReplaceButton
            // 
            this.writeReplaceButton.Location = new System.Drawing.Point(460, 3);
            this.writeReplaceButton.Name = "writeReplaceButton";
            this.writeReplaceButton.Size = new System.Drawing.Size(67, 23);
            this.writeReplaceButton.TabIndex = 3;
            this.writeReplaceButton.Text = "置換";
            this.writeReplaceButton.UseVisualStyleBackColor = true;
            this.writeReplaceButton.Click += new System.EventHandler(this.writeReplaceButton_Click);
            // 
            // WriteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 291);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "WriteForm";
            this.Text = "セル編集";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
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
    }
}