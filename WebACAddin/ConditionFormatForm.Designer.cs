namespace WebACAddin
{
    partial class ConditionFormatForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.conditionKeyword = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.conditionType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bgcolorRgb = new System.Windows.Forms.TextBox();
            this.openConditionColorPalletButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.ConditionFormatFormTopMostCheck = new System.Windows.Forms.CheckBox();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(426, 147);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.conditionKeyword);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(420, 39);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 7, 17, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "条件";
            // 
            // conditionKeyword
            // 
            this.conditionKeyword.Location = new System.Drawing.Point(60, 3);
            this.conditionKeyword.Name = "conditionKeyword";
            this.conditionKeyword.Size = new System.Drawing.Size(349, 21);
            this.conditionKeyword.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.conditionType);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.bgcolorRgb);
            this.flowLayoutPanel2.Controls.Add(this.openConditionColorPalletButton);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 48);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(420, 48);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "検索方式";
            // 
            // conditionType
            // 
            this.conditionType.FormattingEnabled = true;
            this.conditionType.Items.AddRange(new object[] {
            "あいまい検索",
            "完全一致",
            "正規表現検索"});
            this.conditionType.Location = new System.Drawing.Point(76, 3);
            this.conditionType.Name = "conditionType";
            this.conditionType.Size = new System.Drawing.Size(117, 22);
            this.conditionType.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "背景色";
            // 
            // bgcolorRgb
            // 
            this.bgcolorRgb.Location = new System.Drawing.Point(257, 3);
            this.bgcolorRgb.Name = "bgcolorRgb";
            this.bgcolorRgb.Size = new System.Drawing.Size(98, 21);
            this.bgcolorRgb.TabIndex = 1;
            // 
            // openConditionColorPalletButton
            // 
            this.openConditionColorPalletButton.Location = new System.Drawing.Point(361, 3);
            this.openConditionColorPalletButton.Name = "openConditionColorPalletButton";
            this.openConditionColorPalletButton.Size = new System.Drawing.Size(50, 27);
            this.openConditionColorPalletButton.TabIndex = 2;
            this.openConditionColorPalletButton.Text = "選択";
            this.openConditionColorPalletButton.UseVisualStyleBackColor = true;
            this.openConditionColorPalletButton.Click += new System.EventHandler(this.openConditionColorPalletButton_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.ConditionFormatFormTopMostCheck);
            this.flowLayoutPanel3.Controls.Add(this.addButton);
            this.flowLayoutPanel3.Controls.Add(this.deleteButton);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 102);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(420, 42);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // ConditionFormatFormTopMostCheck
            // 
            this.ConditionFormatFormTopMostCheck.AutoSize = true;
            this.ConditionFormatFormTopMostCheck.Location = new System.Drawing.Point(3, 10);
            this.ConditionFormatFormTopMostCheck.Margin = new System.Windows.Forms.Padding(3, 10, 13, 3);
            this.ConditionFormatFormTopMostCheck.Name = "ConditionFormatFormTopMostCheck";
            this.ConditionFormatFormTopMostCheck.Size = new System.Drawing.Size(113, 19);
            this.ConditionFormatFormTopMostCheck.TabIndex = 2;
            this.ConditionFormatFormTopMostCheck.Text = "常に前面表示";
            this.ConditionFormatFormTopMostCheck.UseVisualStyleBackColor = true;
            this.ConditionFormatFormTopMostCheck.Click += new System.EventHandler(this.ConditionFormatFormTopMostCheck_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(132, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(73, 27);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "追加";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(211, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(71, 27);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "削除";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // ConditionFormatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 147);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConditionFormatForm";
            this.ShowIcon = false;
            this.Text = "カスタム条件書式";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox conditionKeyword;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bgcolorRgb;
        private System.Windows.Forms.Button openConditionColorPalletButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ComboBox conditionType;
        private System.Windows.Forms.CheckBox ConditionFormatFormTopMostCheck;
        private System.Windows.Forms.Label label3;
    }
}