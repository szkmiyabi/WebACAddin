using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Microsoft.Office.Tools.Ribbon;
using System.Text.RegularExpressions;
using Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;

namespace WebACAddin
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }

        //ドロップダウンに値追加
        private void add_data()
        {
            if (InputFormText.Text == "")
            {
                MessageBox.Show("値が入力されていません!");
            }
            string buf = InputFormText.Text;
            string[] sep = { "\r\n" };
            string[] lines = buf.Split(sep, StringSplitOptions.None);
            string body = "";
            if (Globals.Ribbons.Ribbon1.addCommentPreClearCheck.Checked == true) do_clear_combo_comment_all();
            for (int i = 0; i < lines.Length; i++)
            {
                string row = lines[i];
                RibbonDropDownItem item = Globals.Ribbons.Ribbon1.Factory.CreateRibbonDropDownItem();
                item.Label = row;
                Globals.Ribbons.Ribbon1.writeCommentCombo.Items.Add(item);

            }
            MessageBox.Show("値の追加に成功しました");

        }

        //ドロップダウン項目全削除
        private void do_clear_combo_comment_all()
        {
            Globals.Ribbons.Ribbon1.writeCommentCombo.Items.Clear();
            Globals.Ribbons.Ribbon1.writeCommentCombo.Text = "";
        }

        //追加するボタンクリック
        private void InputFormAddButton_Click(object sender, EventArgs e)
        {
            add_data();
        }

        private void InputFormText_KeyDown(object sender, KeyEventArgs e)
        {
            //Ctrl + A
            if(e.Control && e.KeyCode == Keys.A)
            {
                e.SuppressKeyPress = true; //beep disabled
                InputFormText.SelectAll();
            }
        }
    }
}
