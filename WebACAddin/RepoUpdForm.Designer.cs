namespace WebACAddin
{
    partial class RepoUpdForm
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
            this.srcText = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.repoUpdateButton = new System.Windows.Forms.Button();
            this.overWriteCheck = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.srcText, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.72289F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.27711F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(372, 179);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // srcText
            // 
            this.srcText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.srcText.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.srcText.Location = new System.Drawing.Point(3, 3);
            this.srcText.MaxLength = 0;
            this.srcText.Multiline = true;
            this.srcText.Name = "srcText";
            this.srcText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.srcText.Size = new System.Drawing.Size(366, 138);
            this.srcText.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.repoUpdateButton);
            this.flowLayoutPanel1.Controls.Add(this.overWriteCheck);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(121, 147);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(248, 29);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // repoUpdateButton
            // 
            this.repoUpdateButton.Location = new System.Drawing.Point(3, 3);
            this.repoUpdateButton.Name = "repoUpdateButton";
            this.repoUpdateButton.Size = new System.Drawing.Size(86, 23);
            this.repoUpdateButton.TabIndex = 0;
            this.repoUpdateButton.Text = "変更を反映";
            this.repoUpdateButton.UseVisualStyleBackColor = true;
            this.repoUpdateButton.Click += new System.EventHandler(this.repoUpdateButton_Click);
            // 
            // overWriteCheck
            // 
            this.overWriteCheck.AutoSize = true;
            this.overWriteCheck.Location = new System.Drawing.Point(95, 6);
            this.overWriteCheck.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.overWriteCheck.Name = "overWriteCheck";
            this.overWriteCheck.Size = new System.Drawing.Size(48, 16);
            this.overWriteCheck.TabIndex = 1;
            this.overWriteCheck.Text = "追記";
            this.overWriteCheck.UseVisualStyleBackColor = true;
            // 
            // RepoUpdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 179);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RepoUpdForm";
            this.ShowIcon = false;
            this.Text = "レポート行修正";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox srcText;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button repoUpdateButton;
        private System.Windows.Forms.CheckBox overWriteCheck;
    }
}