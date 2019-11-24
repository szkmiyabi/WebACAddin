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
            this.MemoryBackButton = new System.Windows.Forms.Button();
            this.locationMemoryButton = new System.Windows.Forms.Button();
            this.opacityCheck = new System.Windows.Forms.CheckBox();
            this.CtrlFormCloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cellGoTopButton
            // 
            this.cellGoTopButton.Location = new System.Drawing.Point(45, 8);
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
            this.cellGoLeftButton.Location = new System.Drawing.Point(10, 38);
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
            this.cellGoRightButton.Location = new System.Drawing.Point(80, 38);
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
            this.cellGoBottomButton.Location = new System.Drawing.Point(45, 68);
            this.cellGoBottomButton.Margin = new System.Windows.Forms.Padding(0);
            this.cellGoBottomButton.Name = "cellGoBottomButton";
            this.cellGoBottomButton.Size = new System.Drawing.Size(35, 30);
            this.cellGoBottomButton.TabIndex = 3;
            this.cellGoBottomButton.Text = "↓";
            this.cellGoBottomButton.UseVisualStyleBackColor = true;
            this.cellGoBottomButton.Click += new System.EventHandler(this.cellGoBottomButton_Click);
            // 
            // MemoryBackButton
            // 
            this.MemoryBackButton.Location = new System.Drawing.Point(63, 101);
            this.MemoryBackButton.Name = "MemoryBackButton";
            this.MemoryBackButton.Size = new System.Drawing.Size(61, 30);
            this.MemoryBackButton.TabIndex = 6;
            this.MemoryBackButton.Text = "Back";
            this.MemoryBackButton.UseVisualStyleBackColor = true;
            this.MemoryBackButton.Click += new System.EventHandler(this.MemoryBackButton_Click);
            // 
            // locationMemoryButton
            // 
            this.locationMemoryButton.Location = new System.Drawing.Point(45, 38);
            this.locationMemoryButton.Margin = new System.Windows.Forms.Padding(0);
            this.locationMemoryButton.Name = "locationMemoryButton";
            this.locationMemoryButton.Size = new System.Drawing.Size(35, 30);
            this.locationMemoryButton.TabIndex = 5;
            this.locationMemoryButton.Text = "M";
            this.locationMemoryButton.UseVisualStyleBackColor = true;
            this.locationMemoryButton.Click += new System.EventHandler(this.locationMemoryButton_Click);
            // 
            // opacityCheck
            // 
            this.opacityCheck.AutoSize = true;
            this.opacityCheck.Location = new System.Drawing.Point(9, 109);
            this.opacityCheck.Name = "opacityCheck";
            this.opacityCheck.Size = new System.Drawing.Size(48, 16);
            this.opacityCheck.TabIndex = 4;
            this.opacityCheck.Text = "透過";
            this.opacityCheck.UseVisualStyleBackColor = true;
            this.opacityCheck.Click += new System.EventHandler(this.opacityCheck_Click);
            // 
            // CtrlFormCloseButton
            // 
            this.CtrlFormCloseButton.BackColor = System.Drawing.SystemColors.Control;
            this.CtrlFormCloseButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CtrlFormCloseButton.Location = new System.Drawing.Point(97, 0);
            this.CtrlFormCloseButton.Name = "CtrlFormCloseButton";
            this.CtrlFormCloseButton.Size = new System.Drawing.Size(27, 27);
            this.CtrlFormCloseButton.TabIndex = 7;
            this.CtrlFormCloseButton.Text = "x";
            this.CtrlFormCloseButton.UseVisualStyleBackColor = false;
            this.CtrlFormCloseButton.Click += new System.EventHandler(this.CtrlFormCloseButton_Click);
            // 
            // CtrlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(124, 133);
            this.ControlBox = false;
            this.Controls.Add(this.opacityCheck);
            this.Controls.Add(this.MemoryBackButton);
            this.Controls.Add(this.CtrlFormCloseButton);
            this.Controls.Add(this.cellGoTopButton);
            this.Controls.Add(this.locationMemoryButton);
            this.Controls.Add(this.cellGoRightButton);
            this.Controls.Add(this.cellGoBottomButton);
            this.Controls.Add(this.cellGoLeftButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CtrlForm";
            this.ShowIcon = false;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CtrlForm_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cellGoTopButton;
        private System.Windows.Forms.Button cellGoLeftButton;
        private System.Windows.Forms.Button cellGoRightButton;
        private System.Windows.Forms.Button cellGoBottomButton;
        private System.Windows.Forms.CheckBox opacityCheck;
        private System.Windows.Forms.Button MemoryBackButton;
        private System.Windows.Forms.Button locationMemoryButton;
        private System.Windows.Forms.Button CtrlFormCloseButton;
    }
}