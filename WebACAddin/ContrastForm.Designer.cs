namespace WebACAddin
{
    partial class ContrastForm
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
            this.contrastBrowser = new System.Windows.Forms.WebBrowser();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.contrastRatioText = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.contrastRatioTextClearButton = new System.Windows.Forms.Button();
            this.loadCellDataButton = new System.Windows.Forms.Button();
            this.contrastRatioPvButton = new System.Windows.Forms.Button();
            this.contrastRatioClearButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.contrastBrowser, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.49084F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.50916F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(470, 316);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // contrastBrowser
            // 
            this.contrastBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contrastBrowser.Location = new System.Drawing.Point(3, 3);
            this.contrastBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.contrastBrowser.Name = "contrastBrowser";
            this.contrastBrowser.Size = new System.Drawing.Size(464, 128);
            this.contrastBrowser.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.contrastRatioText, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 137);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(464, 176);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // contrastRatioText
            // 
            this.contrastRatioText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contrastRatioText.Location = new System.Drawing.Point(3, 3);
            this.contrastRatioText.Multiline = true;
            this.contrastRatioText.Name = "contrastRatioText";
            this.contrastRatioText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.contrastRatioText.Size = new System.Drawing.Size(458, 134);
            this.contrastRatioText.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.flowLayoutPanel1.Controls.Add(this.contrastRatioTextClearButton);
            this.flowLayoutPanel1.Controls.Add(this.loadCellDataButton);
            this.flowLayoutPanel1.Controls.Add(this.contrastRatioPvButton);
            this.flowLayoutPanel1.Controls.Add(this.contrastRatioClearButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(69, 143);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(392, 30);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // contrastRatioTextClearButton
            // 
            this.contrastRatioTextClearButton.Location = new System.Drawing.Point(3, 3);
            this.contrastRatioTextClearButton.Margin = new System.Windows.Forms.Padding(3, 3, 25, 3);
            this.contrastRatioTextClearButton.Name = "contrastRatioTextClearButton";
            this.contrastRatioTextClearButton.Size = new System.Drawing.Size(98, 23);
            this.contrastRatioTextClearButton.TabIndex = 3;
            this.contrastRatioTextClearButton.Text = "テキスト欄クリア";
            this.contrastRatioTextClearButton.UseVisualStyleBackColor = true;
            this.contrastRatioTextClearButton.Click += new System.EventHandler(this.contrastRatioTextClearButton_Click);
            // 
            // loadCellDataButton
            // 
            this.loadCellDataButton.Location = new System.Drawing.Point(129, 3);
            this.loadCellDataButton.Name = "loadCellDataButton";
            this.loadCellDataButton.Size = new System.Drawing.Size(90, 23);
            this.loadCellDataButton.TabIndex = 2;
            this.loadCellDataButton.Text = "セル値を取得";
            this.loadCellDataButton.UseVisualStyleBackColor = true;
            this.loadCellDataButton.Click += new System.EventHandler(this.loadCellDataButton_Click);
            // 
            // contrastRatioPvButton
            // 
            this.contrastRatioPvButton.Location = new System.Drawing.Point(225, 3);
            this.contrastRatioPvButton.Name = "contrastRatioPvButton";
            this.contrastRatioPvButton.Size = new System.Drawing.Size(75, 23);
            this.contrastRatioPvButton.TabIndex = 0;
            this.contrastRatioPvButton.Text = "プレビュー";
            this.contrastRatioPvButton.UseVisualStyleBackColor = true;
            this.contrastRatioPvButton.Click += new System.EventHandler(this.contrastRatioPvButton_Click);
            // 
            // contrastRatioClearButton
            // 
            this.contrastRatioClearButton.Location = new System.Drawing.Point(306, 3);
            this.contrastRatioClearButton.Name = "contrastRatioClearButton";
            this.contrastRatioClearButton.Size = new System.Drawing.Size(75, 23);
            this.contrastRatioClearButton.TabIndex = 1;
            this.contrastRatioClearButton.Text = "クリア";
            this.contrastRatioClearButton.UseVisualStyleBackColor = true;
            this.contrastRatioClearButton.Click += new System.EventHandler(this.contrastRatioClearButton_Click);
            // 
            // ContrastForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 316);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ContrastForm";
            this.Text = "コントラストブラウザー";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.WebBrowser contrastBrowser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button contrastRatioPvButton;
        private System.Windows.Forms.Button contrastRatioClearButton;
        public System.Windows.Forms.TextBox contrastRatioText;
        private System.Windows.Forms.Button loadCellDataButton;
        private System.Windows.Forms.Button contrastRatioTextClearButton;
    }
}