
namespace WebACAddin
{
    partial class CellViewForm
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.88889F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.111111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(530, 367);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ContentTextBox
            // 
            this.ContentTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentTextBox.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ContentTextBox.Location = new System.Drawing.Point(3, 3);
            this.ContentTextBox.MaxLength = 0;
            this.ContentTextBox.Multiline = true;
            this.ContentTextBox.Name = "ContentTextBox";
            this.ContentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ContentTextBox.Size = new System.Drawing.Size(524, 327);
            this.ContentTextBox.TabIndex = 0;
            this.ContentTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ContentTextBox_KeyDown);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.TopMostCheckBox);
            this.flowLayoutPanel1.Controls.Add(this.SyncronizedCheckBox);
            this.flowLayoutPanel1.Controls.Add(this.CopyButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 336);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(329, 28);
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
            this.CopyButton.Size = new System.Drawing.Size(120, 23);
            this.CopyButton.TabIndex = 2;
            this.CopyButton.Text = "クリップボードにコピー";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // CellViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 367);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CellViewForm";
            this.ShowIcon = false;
            this.Text = "セルプレビュー";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CellViewForm_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox ContentTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox TopMostCheckBox;
        private System.Windows.Forms.CheckBox SyncronizedCheckBox;
        private System.Windows.Forms.Button CopyButton;
    }
}