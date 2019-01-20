using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using System.Text.RegularExpressions;

namespace WebACAddin
{
    public partial class WriteForm : Form
    {

        private string pre_focuced_control = "";

        public WriteForm()
        {
            InitializeComponent();
            combobox_fetch();
        }

        //コンボボックスのサイズを調整
        private void combobox_fetch()
        {
            int max = 0;
            Graphics g = writeFormSnipetCombo.CreateGraphics();
            foreach(string text in writeFormSnipetCombo.Items)
            {
                max = (int)Math.Max(max, g.MeasureString(text, writeFormSnipetCombo.Font).Width);
            }
            writeFormSnipetCombo.DropDownWidth = max;
        }

        //Ctrl + A の対応
        private void writeFormText_KeyDown(object sender, KeyEventArgs e)
        {
            //Ctrl + A を実装
            if (e.Control && e.KeyCode == Keys.A)
            {
                e.SuppressKeyPress = true; //beep禁止
                writeFormText.SelectAll();
            }
        }

        //フォーカス履歴の保持
        private void writeFormText_Leave(object sender, EventArgs e)
        {
            pre_focuced_control = "writeFormText";
        }

        private void writeSearchText_Leave(object sender, EventArgs e)
        {
            pre_focuced_control = "writeSearchText";
        }

        private void writeReplaceText_Leave(object sender, EventArgs e)
        {
            pre_focuced_control = "writeReplaceText";
        }

        //アクティブセルのデータを読み込み
        private void pull_from_cell_data()
        {
            Excel.Range sa = Globals.ThisAddIn.Application.ActiveCell;
            Excel.Worksheet ash = Globals.ThisAddIn.Application.ActiveSheet;
            Regex unixbr = new Regex(@"\n", RegexOptions.Compiled | RegexOptions.Multiline);

            int r, c = 0;
            r = sa.Row;
            c = sa.Column;
            string body = "";
            if (ash.Cells[r, c].Value != null)
            {
                Type t = ash.Cells[r, c].Value.GetType();
                if (t.Equals(typeof(string)))
                {
                    body = (string)ash.Cells[r, c].Value;
                }
                body = unixbr.Replace(body, "\r\n");
            }
            writeFormText.Text = body;

        }

        //アクティブセルにデータを送信
        private void push_to_cell_data()
        {
            Excel.Range sa = Globals.ThisAddIn.Application.ActiveCell;
            Excel.Worksheet ash = Globals.ThisAddIn.Application.ActiveSheet;

            int r, c = 0;
            r = sa.Row;
            c = sa.Column;
            string body = "";
            body = writeFormText.Text;
            if (body == "") return;
            ash.Cells[r, c].Value = body;

        }

        //テキストを置換
        private void do_text_replace()
        {
            string body = writeFormText.Text;
            string srch_wd = writeSearchText.Text;
            string repl_wd = writeReplaceText.Text;
            if (srch_wd == "" || srch_wd == null) return;
            try
            {
                writeFormText.Text = _text_replace(srch_wd, repl_wd, body);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Regex Error!");
            }
        }

        private string _text_replace(string search, string replace, string src)
        {
            if (writeFormRegxCheck.Checked == true)
            {
                Regex pt = new Regex(search, RegexOptions.Compiled | RegexOptions.Multiline);
                if (pt.IsMatch(src) == false) return null;
                return pt.Replace(src, replace);
            }
            else
            {
                return src.Replace(search, replace);
            }
        }

        //タブ除去
        private void do_tab_text_delete()
        {
            Regex pt = new Regex(@"\t", RegexOptions.Compiled | RegexOptions.Multiline);
            string body = writeFormText.Text;
            body = pt.Replace(body, "");
            writeFormText.Text = body;
        }

        //選択語句をフォーカスのある入力欄に追記
        private void do_insert_snipet()
        {
            string src = writeFormSnipetCombo.Text;
            Control cont = null;
            if (pre_focuced_control.Equals("writeFormText")) cont = writeFormText;
            else if (pre_focuced_control.Equals("writeSearchText")) cont = writeSearchText;
            else if (pre_focuced_control.Equals("writeReplaceText")) cont = writeReplaceText;
            if(cont == writeFormText)
            {
                string buff = cont.Text;
                cont.Text = buff + "\r\n\r\n" + src + "\r\n\r\n";
            }
            else
            {
                cont.Text = src;
            }
        }

        //選択語句を追加
        private void do_add_snipet()
        {
            Control cont = null;
            if (pre_focuced_control.Equals("writeFormText")) cont = writeFormText;
            else if (pre_focuced_control.Equals("writeSearchText")) cont = writeSearchText;
            else if (pre_focuced_control.Equals("writeReplaceText")) cont = writeReplaceText;
            if (cont.Name.Equals("writeFormText")) return;
            writeFormSnipetCombo.Items.Add(cont.Text);
            combobox_fetch();
        }

        //セルから読込みクリック
        private void pullFromCellDataButton_Click(object sender, EventArgs e)
        {
            pull_from_cell_data();
        }

        //セルに送信クリック
        private void pushToCellDataButton_Click(object sender, EventArgs e)
        {
            push_to_cell_data();
        }

        //置換ボタンクリック
        private void writeReplaceButton_Click(object sender, EventArgs e)
        {
            do_text_replace();
        }

        //タブ除去ボタンクリック
        private void tabStringDeleteButton_Click(object sender, EventArgs e)
        {
            do_tab_text_delete();
        }

        //語句を挿入クリック
        private void writeFormSnipetInputButton_Click(object sender, EventArgs e)
        {
            do_insert_snipet();
        }


        //値追加クリック
        private void writeFormSnipetAddButton_Click(object sender, EventArgs e)
        {
            do_add_snipet();
        }


    }


}
