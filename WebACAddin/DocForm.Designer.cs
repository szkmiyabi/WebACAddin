namespace WebACAddin
{
    partial class DocForm
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
            this.docFormText = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.failCategoryFieldCheck = new System.Windows.Forms.CheckBox();
            this.pageNumIncludeCheck = new System.Windows.Forms.CheckBox();
            this.urlstrIncludeCheck = new System.Windows.Forms.CheckBox();
            this.docLoadCellDataButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.docFormText, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.04348F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.95652F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(533, 335);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // docFormText
            // 
            this.docFormText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.docFormText.Location = new System.Drawing.Point(3, 3);
            this.docFormText.Multiline = true;
            this.docFormText.Name = "docFormText";
            this.docFormText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.docFormText.Size = new System.Drawing.Size(527, 277);
            this.docFormText.TabIndex = 0;
            this.docFormText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.docFormText_KeyDown);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.failCategoryFieldCheck);
            this.flowLayoutPanel1.Controls.Add(this.pageNumIncludeCheck);
            this.flowLayoutPanel1.Controls.Add(this.urlstrIncludeCheck);
            this.flowLayoutPanel1.Controls.Add(this.docLoadCellDataButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 286);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(527, 32);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // failCategoryFieldCheck
            // 
            this.failCategoryFieldCheck.AutoSize = true;
            this.failCategoryFieldCheck.Location = new System.Drawing.Point(3, 3);
            this.failCategoryFieldCheck.Name = "failCategoryFieldCheck";
            this.failCategoryFieldCheck.Size = new System.Drawing.Size(60, 16);
            this.failCategoryFieldCheck.TabIndex = 1;
            this.failCategoryFieldCheck.Text = "区分有";
            this.failCategoryFieldCheck.UseVisualStyleBackColor = true;
            // 
            // pageNumIncludeCheck
            // 
            this.pageNumIncludeCheck.AutoSize = true;
            this.pageNumIncludeCheck.Location = new System.Drawing.Point(69, 3);
            this.pageNumIncludeCheck.Name = "pageNumIncludeCheck";
            this.pageNumIncludeCheck.Size = new System.Drawing.Size(54, 16);
            this.pageNumIncludeCheck.TabIndex = 2;
            this.pageNumIncludeCheck.Text = "PID有";
            this.pageNumIncludeCheck.UseVisualStyleBackColor = true;
            // 
            // urlstrIncludeCheck
            // 
            this.urlstrIncludeCheck.AutoSize = true;
            this.urlstrIncludeCheck.Location = new System.Drawing.Point(129, 3);
            this.urlstrIncludeCheck.Name = "urlstrIncludeCheck";
            this.urlstrIncludeCheck.Size = new System.Drawing.Size(58, 16);
            this.urlstrIncludeCheck.TabIndex = 3;
            this.urlstrIncludeCheck.Text = "URL有";
            this.urlstrIncludeCheck.UseVisualStyleBackColor = true;
            // 
            // docLoadCellDataButton
            // 
            this.docLoadCellDataButton.Location = new System.Drawing.Point(193, 3);
            this.docLoadCellDataButton.Name = "docLoadCellDataButton";
            this.docLoadCellDataButton.Size = new System.Drawing.Size(75, 23);
            this.docLoadCellDataButton.TabIndex = 0;
            this.docLoadCellDataButton.Text = "セル読込";
            this.docLoadCellDataButton.UseVisualStyleBackColor = true;
            this.docLoadCellDataButton.Click += new System.EventHandler(this.docLoadCellDataButton_Click);
            // 
            // DocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 335);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DocForm";
            this.Text = "文書フォーム";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button docLoadCellDataButton;
        private System.Windows.Forms.CheckBox failCategoryFieldCheck;
        public System.Windows.Forms.TextBox docFormText;
        private System.Windows.Forms.CheckBox pageNumIncludeCheck;
        private System.Windows.Forms.CheckBox urlstrIncludeCheck;
    }
}