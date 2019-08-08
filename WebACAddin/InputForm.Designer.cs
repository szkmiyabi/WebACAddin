namespace WebACAddin
{
    partial class InputForm
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
            this.InputFormText = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.InputFormAddButton = new System.Windows.Forms.Button();
            this.doInsertBrButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.InputFormText, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(326, 156);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // InputFormText
            // 
            this.InputFormText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputFormText.Location = new System.Drawing.Point(3, 3);
            this.InputFormText.Multiline = true;
            this.InputFormText.Name = "InputFormText";
            this.InputFormText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InputFormText.Size = new System.Drawing.Size(320, 111);
            this.InputFormText.TabIndex = 0;
            this.InputFormText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputFormText_KeyDown);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.InputFormAddButton);
            this.flowLayoutPanel1.Controls.Add(this.doInsertBrButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(123, 120);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 33);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // InputFormAddButton
            // 
            this.InputFormAddButton.Location = new System.Drawing.Point(3, 3);
            this.InputFormAddButton.Name = "InputFormAddButton";
            this.InputFormAddButton.Size = new System.Drawing.Size(75, 23);
            this.InputFormAddButton.TabIndex = 0;
            this.InputFormAddButton.Text = "追加する";
            this.InputFormAddButton.UseVisualStyleBackColor = true;
            this.InputFormAddButton.Click += new System.EventHandler(this.InputFormAddButton_Click);
            // 
            // doInsertBrButton
            // 
            this.doInsertBrButton.Location = new System.Drawing.Point(106, 3);
            this.doInsertBrButton.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.doInsertBrButton.Name = "doInsertBrButton";
            this.doInsertBrButton.Size = new System.Drawing.Size(85, 23);
            this.doInsertBrButton.TabIndex = 1;
            this.doInsertBrButton.Text = "改行タグ挿入";
            this.doInsertBrButton.UseVisualStyleBackColor = true;
            this.doInsertBrButton.Click += new System.EventHandler(this.doInsertBrButton_Click);
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 156);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "InputForm";
            this.Text = "値の追加";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button InputFormAddButton;
        private System.Windows.Forms.TextBox InputFormText;
        private System.Windows.Forms.Button doInsertBrButton;
    }
}