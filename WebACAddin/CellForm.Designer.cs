﻿namespace WebACAddin
{
    partial class CellForm
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
            this.cellReportText = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.colorCodeText = new System.Windows.Forms.TextBox();
            this.getColorCodeButton = new System.Windows.Forms.Button();
            this.matchColorListupButton = new System.Windows.Forms.Button();
            this.matchListColoringButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.listReverseButton = new System.Windows.Forms.Button();
            this.csvButton = new System.Windows.Forms.Button();
            this.matchFilteredRowButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.topMostCheck = new System.Windows.Forms.CheckBox();
            this.copyButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.Controls.Add(this.cellReportText, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.74274F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.25726F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(444, 365);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cellReportText
            // 
            this.cellReportText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cellReportText.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cellReportText.Location = new System.Drawing.Point(3, 3);
            this.cellReportText.MaxLength = 0;
            this.cellReportText.Multiline = true;
            this.cellReportText.Name = "cellReportText";
            this.cellReportText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cellReportText.Size = new System.Drawing.Size(438, 223);
            this.cellReportText.TabIndex = 0;
            this.cellReportText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cellReportText_KeyDown);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.colorCodeText);
            this.flowLayoutPanel1.Controls.Add(this.getColorCodeButton);
            this.flowLayoutPanel1.Controls.Add(this.matchColorListupButton);
            this.flowLayoutPanel1.Controls.Add(this.matchListColoringButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 232);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(438, 45);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // colorCodeText
            // 
            this.colorCodeText.Location = new System.Drawing.Point(3, 6);
            this.colorCodeText.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.colorCodeText.Name = "colorCodeText";
            this.colorCodeText.Size = new System.Drawing.Size(72, 21);
            this.colorCodeText.TabIndex = 3;
            // 
            // getColorCodeButton
            // 
            this.getColorCodeButton.Location = new System.Drawing.Point(81, 3);
            this.getColorCodeButton.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.getColorCodeButton.Name = "getColorCodeButton";
            this.getColorCodeButton.Size = new System.Drawing.Size(75, 27);
            this.getColorCodeButton.TabIndex = 4;
            this.getColorCodeButton.Text = "色値取得";
            this.getColorCodeButton.UseVisualStyleBackColor = true;
            this.getColorCodeButton.Click += new System.EventHandler(this.getColorCodeButton_Click);
            // 
            // matchColorListupButton
            // 
            this.matchColorListupButton.Location = new System.Drawing.Point(169, 3);
            this.matchColorListupButton.Name = "matchColorListupButton";
            this.matchColorListupButton.Size = new System.Drawing.Size(114, 27);
            this.matchColorListupButton.TabIndex = 0;
            this.matchColorListupButton.Text = "色一致セル抽出";
            this.matchColorListupButton.UseVisualStyleBackColor = true;
            this.matchColorListupButton.Click += new System.EventHandler(this.matchColorListupButton_Click);
            // 
            // matchListColoringButton
            // 
            this.matchListColoringButton.Location = new System.Drawing.Point(289, 3);
            this.matchListColoringButton.Name = "matchListColoringButton";
            this.matchListColoringButton.Size = new System.Drawing.Size(128, 27);
            this.matchListColoringButton.TabIndex = 1;
            this.matchListColoringButton.Text = "一覧一致セル色付";
            this.matchListColoringButton.UseVisualStyleBackColor = true;
            this.matchListColoringButton.Click += new System.EventHandler(this.matchListColoringButton_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.listReverseButton);
            this.flowLayoutPanel2.Controls.Add(this.csvButton);
            this.flowLayoutPanel2.Controls.Add(this.matchFilteredRowButton);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(63, 283);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(378, 35);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // listReverseButton
            // 
            this.listReverseButton.Location = new System.Drawing.Point(3, 3);
            this.listReverseButton.Name = "listReverseButton";
            this.listReverseButton.Size = new System.Drawing.Size(87, 27);
            this.listReverseButton.TabIndex = 3;
            this.listReverseButton.Text = "一覧を反転";
            this.listReverseButton.UseVisualStyleBackColor = true;
            this.listReverseButton.Click += new System.EventHandler(this.listReverseButton_Click);
            // 
            // csvButton
            // 
            this.csvButton.Location = new System.Drawing.Point(96, 3);
            this.csvButton.Margin = new System.Windows.Forms.Padding(3, 3, 14, 3);
            this.csvButton.Name = "csvButton";
            this.csvButton.Size = new System.Drawing.Size(85, 27);
            this.csvButton.TabIndex = 4;
            this.csvButton.Text = "カンマ区切";
            this.csvButton.UseVisualStyleBackColor = true;
            this.csvButton.Click += new System.EventHandler(this.csvButton_Click);
            // 
            // matchFilteredRowButton
            // 
            this.matchFilteredRowButton.Location = new System.Drawing.Point(198, 3);
            this.matchFilteredRowButton.Name = "matchFilteredRowButton";
            this.matchFilteredRowButton.Size = new System.Drawing.Size(104, 27);
            this.matchFilteredRowButton.TabIndex = 2;
            this.matchFilteredRowButton.Text = "フィルタ抽出行";
            this.matchFilteredRowButton.UseVisualStyleBackColor = true;
            this.matchFilteredRowButton.Click += new System.EventHandler(this.matchFilteredRowButton_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.topMostCheck);
            this.flowLayoutPanel3.Controls.Add(this.copyButton);
            this.flowLayoutPanel3.Controls.Add(this.clearButton);
            this.flowLayoutPanel3.Controls.Add(this.closeButton);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 324);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(438, 38);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // topMostCheck
            // 
            this.topMostCheck.AutoSize = true;
            this.topMostCheck.Location = new System.Drawing.Point(3, 3);
            this.topMostCheck.Margin = new System.Windows.Forms.Padding(3, 3, 17, 3);
            this.topMostCheck.Name = "topMostCheck";
            this.topMostCheck.Size = new System.Drawing.Size(113, 19);
            this.topMostCheck.TabIndex = 0;
            this.topMostCheck.Text = "常に前面表示";
            this.topMostCheck.UseVisualStyleBackColor = true;
            this.topMostCheck.Click += new System.EventHandler(this.topMostCheck_Click);
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(136, 3);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(58, 27);
            this.copyButton.TabIndex = 1;
            this.copyButton.Text = "コピー";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(200, 3);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(62, 27);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "クリア";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(268, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(63, 27);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "閉じる";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // CellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 365);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CellForm";
            this.ShowIcon = false;
            this.Text = "セル解析";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button matchColorListupButton;
        private System.Windows.Forms.Button matchListColoringButton;
        private System.Windows.Forms.Button matchFilteredRowButton;
        private System.Windows.Forms.TextBox colorCodeText;
        private System.Windows.Forms.Button getColorCodeButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button listReverseButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.CheckBox topMostCheck;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button clearButton;
        public System.Windows.Forms.TextBox cellReportText;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button csvButton;
    }
}