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
            this.conditionType = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.bgcolorRgb = new System.Windows.Forms.TextBox();
            this.openConditionColorPalletButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.ConditionFormatFormTopMostCheck = new System.Windows.Forms.CheckBox();
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(264, 126);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.conditionKeyword);
            this.flowLayoutPanel1.Controls.Add(this.conditionType);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(258, 32);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 6, 15, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "条件";
            // 
            // conditionKeyword
            // 
            this.conditionKeyword.Location = new System.Drawing.Point(50, 3);
            this.conditionKeyword.Name = "conditionKeyword";
            this.conditionKeyword.Size = new System.Drawing.Size(114, 19);
            this.conditionKeyword.TabIndex = 1;
            // 
            // conditionType
            // 
            this.conditionType.FormattingEnabled = true;
            this.conditionType.Items.AddRange(new object[] {
            "を含む",
            "を含まない",
            "で始まる",
            "で終わる"});
            this.conditionType.Location = new System.Drawing.Point(170, 3);
            this.conditionType.Name = "conditionType";
            this.conditionType.Size = new System.Drawing.Size(75, 20);
            this.conditionType.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.bgcolorRgb);
            this.flowLayoutPanel2.Controls.Add(this.openConditionColorPalletButton);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 41);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(258, 41);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "背景色";
            // 
            // bgcolorRgb
            // 
            this.bgcolorRgb.Location = new System.Drawing.Point(50, 3);
            this.bgcolorRgb.Name = "bgcolorRgb";
            this.bgcolorRgb.Size = new System.Drawing.Size(114, 19);
            this.bgcolorRgb.TabIndex = 1;
            // 
            // openConditionColorPalletButton
            // 
            this.openConditionColorPalletButton.Location = new System.Drawing.Point(170, 3);
            this.openConditionColorPalletButton.Name = "openConditionColorPalletButton";
            this.openConditionColorPalletButton.Size = new System.Drawing.Size(59, 23);
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
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 88);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(258, 35);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(110, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(63, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "追加";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(179, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(61, 23);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "削除";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // ConditionFormatFormTopMostCheck
            // 
            this.ConditionFormatFormTopMostCheck.AutoSize = true;
            this.ConditionFormatFormTopMostCheck.Location = new System.Drawing.Point(3, 9);
            this.ConditionFormatFormTopMostCheck.Margin = new System.Windows.Forms.Padding(3, 9, 11, 3);
            this.ConditionFormatFormTopMostCheck.Name = "ConditionFormatFormTopMostCheck";
            this.ConditionFormatFormTopMostCheck.Size = new System.Drawing.Size(93, 16);
            this.ConditionFormatFormTopMostCheck.TabIndex = 2;
            this.ConditionFormatFormTopMostCheck.Text = "常に前面表示";
            this.ConditionFormatFormTopMostCheck.UseVisualStyleBackColor = true;
            this.ConditionFormatFormTopMostCheck.Click += new System.EventHandler(this.ConditionFormatFormTopMostCheck_Click);
            // 
            // ConditionFormatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 126);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConditionFormatForm";
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
    }
}