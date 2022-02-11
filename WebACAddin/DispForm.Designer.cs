
namespace WebACAddin
{
    partial class DispForm
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
            this.ContentTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.TopMostCheckBox = new System.Windows.Forms.CheckBox();
            this.SyncronizedCheckBox = new System.Windows.Forms.CheckBox();
            this.CopyButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fontSizeLargeButton = new System.Windows.Forms.Button();
            this.fontSizeMinusButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ContentTextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.26941F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.73059F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(502, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ContentTextBox
            // 
            this.ContentTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentTextBox.Location = new System.Drawing.Point(3, 3);
            this.ContentTextBox.Multiline = true;
            this.ContentTextBox.Name = "ContentTextBox";
            this.ContentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ContentTextBox.Size = new System.Drawing.Size(496, 395);
            this.ContentTextBox.TabIndex = 0;
            this.ContentTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ContentTextBox_KeyDown);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.TopMostCheckBox);
            this.flowLayoutPanel1.Controls.Add(this.SyncronizedCheckBox);
            this.flowLayoutPanel1.Controls.Add(this.CopyButton);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.fontSizeLargeButton);
            this.flowLayoutPanel1.Controls.Add(this.fontSizeMinusButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 404);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(484, 43);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // TopMostCheckBox
            // 
            this.TopMostCheckBox.AutoSize = true;
            this.TopMostCheckBox.Location = new System.Drawing.Point(3, 8);
            this.TopMostCheckBox.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.TopMostCheckBox.Name = "TopMostCheckBox";
            this.TopMostCheckBox.Size = new System.Drawing.Size(93, 16);
            this.TopMostCheckBox.TabIndex = 0;
            this.TopMostCheckBox.Text = "常に前面表示";
            this.TopMostCheckBox.UseVisualStyleBackColor = true;
            this.TopMostCheckBox.CheckedChanged += new System.EventHandler(this.TopMostCheckBox_CheckedChanged);
            // 
            // SyncronizedCheckBox
            // 
            this.SyncronizedCheckBox.AutoSize = true;
            this.SyncronizedCheckBox.Location = new System.Drawing.Point(102, 8);
            this.SyncronizedCheckBox.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.SyncronizedCheckBox.Name = "SyncronizedCheckBox";
            this.SyncronizedCheckBox.Size = new System.Drawing.Size(72, 16);
            this.SyncronizedCheckBox.TabIndex = 1;
            this.SyncronizedCheckBox.Text = "同期有効";
            this.SyncronizedCheckBox.UseVisualStyleBackColor = true;
            this.SyncronizedCheckBox.CheckedChanged += new System.EventHandler(this.SyncronizedCheckBox_CheckedChanged);
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(180, 3);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(139, 23);
            this.CopyButton.TabIndex = 2;
            this.CopyButton.Text = "クリップボードにコピー";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "文字サイズ";
            // 
            // fontSizeLargeButton
            // 
            this.fontSizeLargeButton.Location = new System.Drawing.Point(389, 3);
            this.fontSizeLargeButton.Name = "fontSizeLargeButton";
            this.fontSizeLargeButton.Size = new System.Drawing.Size(31, 23);
            this.fontSizeLargeButton.TabIndex = 4;
            this.fontSizeLargeButton.Text = "＋";
            this.fontSizeLargeButton.UseVisualStyleBackColor = true;
            this.fontSizeLargeButton.Click += new System.EventHandler(this.fontSizeLargeButton_Click);
            // 
            // fontSizeMinusButton
            // 
            this.fontSizeMinusButton.Location = new System.Drawing.Point(426, 3);
            this.fontSizeMinusButton.Name = "fontSizeMinusButton";
            this.fontSizeMinusButton.Size = new System.Drawing.Size(31, 23);
            this.fontSizeMinusButton.TabIndex = 5;
            this.fontSizeMinusButton.Text = "－";
            this.fontSizeMinusButton.UseVisualStyleBackColor = true;
            this.fontSizeMinusButton.Click += new System.EventHandler(this.fontSizeMinusButton_Click);
            // 
            // DispForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DispForm";
            this.ShowIcon = false;
            this.Text = "判定結果を整形表示";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DispForm_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox TopMostCheckBox;
        private System.Windows.Forms.CheckBox SyncronizedCheckBox;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button fontSizeLargeButton;
        private System.Windows.Forms.Button fontSizeMinusButton;
        public System.Windows.Forms.TextBox ContentTextBox;
    }
}