namespace WebACAddin
{
    partial class CtrlForm
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
            this.cellGoTopButton = new System.Windows.Forms.Button();
            this.cellGoLeftButton = new System.Windows.Forms.Button();
            this.cellGoRightButton = new System.Windows.Forms.Button();
            this.cellGoBottomButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.opacityCheck = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cellGoTopButton
            // 
            this.cellGoTopButton.Location = new System.Drawing.Point(45, 0);
            this.cellGoTopButton.Margin = new System.Windows.Forms.Padding(0);
            this.cellGoTopButton.Name = "cellGoTopButton";
            this.cellGoTopButton.Size = new System.Drawing.Size(35, 30);
            this.cellGoTopButton.TabIndex = 0;
            this.cellGoTopButton.Text = "↑";
            this.cellGoTopButton.UseVisualStyleBackColor = true;
            this.cellGoTopButton.Click += new System.EventHandler(this.cellGoTopButton_Click);
            // 
            // cellGoLeftButton
            // 
            this.cellGoLeftButton.Location = new System.Drawing.Point(21, 30);
            this.cellGoLeftButton.Margin = new System.Windows.Forms.Padding(0);
            this.cellGoLeftButton.Name = "cellGoLeftButton";
            this.cellGoLeftButton.Size = new System.Drawing.Size(35, 30);
            this.cellGoLeftButton.TabIndex = 1;
            this.cellGoLeftButton.Text = "←";
            this.cellGoLeftButton.UseVisualStyleBackColor = true;
            this.cellGoLeftButton.Click += new System.EventHandler(this.cellGoLeftButton_Click);
            // 
            // cellGoRightButton
            // 
            this.cellGoRightButton.Location = new System.Drawing.Point(66, 30);
            this.cellGoRightButton.Margin = new System.Windows.Forms.Padding(0);
            this.cellGoRightButton.Name = "cellGoRightButton";
            this.cellGoRightButton.Size = new System.Drawing.Size(35, 30);
            this.cellGoRightButton.TabIndex = 2;
            this.cellGoRightButton.Text = "→";
            this.cellGoRightButton.UseVisualStyleBackColor = true;
            this.cellGoRightButton.Click += new System.EventHandler(this.cellGoRightButton_Click);
            // 
            // cellGoBottomButton
            // 
            this.cellGoBottomButton.Location = new System.Drawing.Point(45, 60);
            this.cellGoBottomButton.Margin = new System.Windows.Forms.Padding(0);
            this.cellGoBottomButton.Name = "cellGoBottomButton";
            this.cellGoBottomButton.Size = new System.Drawing.Size(35, 30);
            this.cellGoBottomButton.TabIndex = 3;
            this.cellGoBottomButton.Text = "↓";
            this.cellGoBottomButton.UseVisualStyleBackColor = true;
            this.cellGoBottomButton.Click += new System.EventHandler(this.cellGoBottomButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.opacityCheck);
            this.panel1.Controls.Add(this.cellGoBottomButton);
            this.panel1.Controls.Add(this.cellGoRightButton);
            this.panel1.Controls.Add(this.cellGoLeftButton);
            this.panel1.Controls.Add(this.cellGoTopButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(122, 116);
            this.panel1.TabIndex = 1;
            // 
            // opacityCheck
            // 
            this.opacityCheck.AutoSize = true;
            this.opacityCheck.Location = new System.Drawing.Point(29, 97);
            this.opacityCheck.Name = "opacityCheck";
            this.opacityCheck.Size = new System.Drawing.Size(72, 16);
            this.opacityCheck.TabIndex = 4;
            this.opacityCheck.Text = "透過表示";
            this.opacityCheck.UseVisualStyleBackColor = true;
            this.opacityCheck.Click += new System.EventHandler(this.opacityCheck_Click);
            // 
            // CtrlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(122, 117);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CtrlForm";
            this.ShowIcon = false;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cellGoTopButton;
        private System.Windows.Forms.Button cellGoLeftButton;
        private System.Windows.Forms.Button cellGoRightButton;
        private System.Windows.Forms.Button cellGoBottomButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox opacityCheck;
    }
}