using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WebACAddin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TopMostCheckBox.Checked = true;
            TopMost = true;
        }

        //フォームタイトルを変更
        public void setTitle(string title)
        {
            this.Text = title;
        }

        //Ctrl + A を実装
        private void reportText_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.A)
            {
                e.SuppressKeyPress = true; //beep解除
                reportText.SelectAll();
            }
        }

        //常に前面表示のトグル
        private void TopMostCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = !TopMost;
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            string src = reportText.Text;
            try
            {
                Clipboard.SetDataObject(src, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("コピー失敗しました。\n" + "詳細：" + ex.Message);
            }
        }
    }
}
