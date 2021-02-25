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
using Microsoft.Office.Tools.Ribbon;
using System.Text.RegularExpressions;
using System.IO;

namespace WebACAddin
{
    public partial class WriteForm : Form
    {

        private string pre_focuced_control = "";
        private string br_sp = "<bkmk:br>";

        public WriteForm()
        {
            InitializeComponent();
            combobox_fetch();
            //常に前面表示
            TopMost = true;
            writeFormTopMostCheck.Checked = true;
            //透過有効
            opacityCheck.Checked = true;
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

        //win改行に変換
        private string _encode_return(string str)
        {
            string ret = str;
            Regex reg = new Regex(@"\n", RegexOptions.Multiline | RegexOptions.Compiled);
            try
            {
                ret = reg.Replace(ret, "\r\n");
            }
            catch (Exception ex) { }
            return ret;
        }

        //unix改行に変換
        private string _decode_return(string str)
        {
            string ret = str;
            Regex reg = new Regex(@"\r\n", RegexOptions.Multiline | RegexOptions.Compiled);
            try
            {
                ret = reg.Replace(ret, "\n");
            }
            catch (Exception ex) { }
            return ret;
        }

        //アクティブセルのデータを読み込み
        private void pull_from_cell_data()
        {
            Excel.Range sa = Globals.ThisAddIn.Application.ActiveCell;
            Excel.Worksheet ash = Globals.ThisAddIn.Application.ActiveSheet;

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
                body = _encode_return(body);
            }
            writeFormText.Text = body;

        }

        //アクティブセルの省略元セルのデータを読み込み
        private void browse_base_cell_data()
        {
            Excel.Range sa = Globals.ThisAddIn.Application.ActiveCell;
            Excel.Worksheet ash = Globals.ThisAddIn.Application.ActiveSheet;

            int r, c = 0;
            r = sa.Row;
            c = sa.Column;
            string body = "";
            while (_read_browse_cell_data(ash, r, c) == "〃〃")
            {
                r--;
            }

            body = _read_browse_cell_data(ash, r, c);
            writeFormText.Text = body;
        }
        private string _read_browse_cell_data(Excel.Worksheet ash, int r, int c)
        {
            string body = "";
            if (ash.Cells[r, c].Value != null)
            {
                Type t = ash.Cells[r, c].Value.GetType();
                if (t.Equals(typeof(string)))
                {
                    body = (string)ash.Cells[r, c].Value;
                }
                body = _encode_return(body);
            }
            return body;
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
            body = _decode_return(body);
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
                MessageBox.Show("Error!");
            }
        }

        private string _text_replace(string search, string replace, string src)
        {
            if (writeFormRegxCheck.Checked == true)
            {
                Regex pt = new Regex(search, RegexOptions.Compiled | RegexOptions.Multiline);
                if (pt.IsMatch(src) == false)
                {
                    MessageBox.Show("Regx Error! 検索条件を変えてお試しください!");
                    return src;
                }
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
            src = src.Replace(br_sp, "\r\n");

            TextBox cont = null;
            if (pre_focuced_control.Equals("writeFormText")) cont = writeFormText;
            else if (pre_focuced_control.Equals("writeSearchText")) cont = writeSearchText;
            else if (pre_focuced_control.Equals("writeReplaceText")) cont = writeReplaceText;

            string buff = cont.Text;
            int cnt = buff.Length;
            int st = cont.SelectionStart;
            int ed = cont.SelectionLength;
            string front_txt = buff.Substring(0, st);
            string back_txt = buff.Substring(st + ed);

            cont.Text = front_txt + src + back_txt;
            cont.Select(st + ed + src.Length, 0);
        }

        //改行を挿入
        private void do_insert_br()
        {
            string buff = writeFormText.Text;
            int cnt = buff.Length;
            int st = writeFormText.SelectionStart;
            int ed = writeFormText.SelectionLength;
            string front_txt = buff.Substring(0, st);
            string back_txt = buff.Substring(st + ed);

            writeFormText.Text = front_txt + "\r\n" + back_txt;
            writeFormText.Select(st + ed + "\r\n".Length, 0);
        }

        //選択範囲の文字列を取得
        private string get_selection()
        {
            int st = writeFormText.SelectionStart;
            int ed = writeFormText.SelectionLength;
            string src = writeFormText.Text;
            return src.Substring(st, ed);
        }

        //選択語句からドロップダウンに値を追加する
        private void do_add_snipet()
        {
            Regex pat = new Regex(@"\r\n", RegexOptions.Compiled | RegexOptions.Multiline);
            string txt = get_selection();
            if (txt.Equals("")) return;
            if (addCommentPreClearCheck.Checked == true) do_clear_combo_comment_all();
            if (pat.IsMatch(txt))
            {
                txt = pat.Replace(txt, br_sp);
            }
            writeFormSnipetCombo.Items.Add(txt);
            combobox_fetch();
            MessageBox.Show("値の追加に成功しました");
        }

        //テキストファイルからドロップダウンに値を追加する
        private void do_add_comment_from_file()
        {
            string filename = "";
            string body = "";
            List<string> arr = new List<string>();

            //check onなら全クリア
            if (addCommentPreClearCheck.Checked == true) do_clear_combo_comment_all();

            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "テキストファイル(*.txt)|*.txt";
            if (f.ShowDialog() == DialogResult.OK)
            {
                filename = f.FileName;
            }
            if (filename == "") return;
            StreamReader sr = new StreamReader(filename, System.Text.Encoding.GetEncoding("shift_jis"));
            while (sr.Peek() > -1)
            {
                string line = sr.ReadLine();
                arr.Add(line);
            }
            sr.Close();

            for (int i = 0; i < arr.Count; i++)
            {
                writeFormSnipetCombo.Items.Add(arr[i]);
            }
            MessageBox.Show("値の追加に成功しました");

        }

        //リボンからからドロップダウンに値を追加する
        private void do_add_comment_from_ribbon()
        {
            RibbonComboBox cmb = Globals.Ribbons.Ribbon1.writeCommentCombo;
            List<string> arr = new List<string>();
            if (addCommentPreClearCheck.Checked == true) do_clear_combo_comment_all();
            for (int i = 0; i < cmb.Items.Count; i++)
            {
                RibbonDropDownItem itm = cmb.Items[i];
                string cr = itm.Label;
                arr.Add(cr);
            }
            for (int i = 0; i < arr.Count; i++)
            {
                writeFormSnipetCombo.Items.Add(arr[i]);
            }
            MessageBox.Show("値の追加に成功しました");

        }

        //ドロップダウン選択項目削除
        private void do_clear_combo_comment_single()
        {
            int idx = 0;
            string cr = writeFormSnipetCombo.Text;

            for (int i = 0; i < writeFormSnipetCombo.Items.Count; i++)
            {
                if (writeFormSnipetCombo.Text.Equals(cr))
                {
                    writeFormSnipetCombo.Items.RemoveAt(idx);
                    break;
                }
                idx++;
            }
        }

        //ドロップダウン項目全削除
        private void do_clear_combo_comment_all()
        {
            writeFormSnipetCombo.Items.Clear();
            writeFormSnipetCombo.Text = "";
        }

        //ドロップダウンの値を保存
        private void do_save_val_comment()
        {
            int cnt = writeFormSnipetCombo.Items.Count;
            string body = "";
            for (int i = 0; i < cnt; i++)
            {
                string val = writeFormSnipetCombo.Items[i].ToString();
                body += val;
                if (i != (cnt - 1)) body += "\r\n";
            }
            string path = _get_txt_save_path();
            Encoding enc = Encoding.GetEncoding("Shift_JIS");
            StreamWriter sw = new StreamWriter(path, false, enc);
            sw.WriteLine(body);
            sw.Close();
            MessageBox.Show("保存できました!");
        }

        //TXTファイル保存先を取得
        private string _get_txt_save_path()
        {
            string path = "";
            SaveFileDialog fda = new SaveFileDialog();
            fda.Filter = "Textファイル(*.txt)|*.txt";
            fda.Title = "名前を付けて保存";
            if (fda.ShowDialog() == DialogResult.OK)
            {
                path = fda.FileName;
            }
            return path;
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


        //選択範囲から追加クリック
        private void writeFormSnipetAddButton_Click(object sender, EventArgs e)
        {
            do_add_snipet();
        }

        //ファイルから追加クリック
        private void writeFormSnipetAddFromFileButton_Click(object sender, EventArgs e)
        {
            do_add_comment_from_file();
        }

        //改行をクリック
        private void BrInputButton_Click(object sender, EventArgs e)
        {
            do_insert_br();
        }

        //リボンからクリック
        private void writeFormSnipetAddFromRibbonButton_Click(object sender, EventArgs e)
        {
            do_add_comment_from_ribbon();
        }

        //削除クリック
        private void delCommentSingleButton_Click(object sender, EventArgs e)
        {
            do_clear_combo_comment_single();
        }

        //全件削除クリック
        private void delCommentAllButton_Click(object sender, EventArgs e)
        {
            do_clear_combo_comment_all();
        }

        //保存クリック
        private void writeFormSnipetSaveButton_Click(object sender, EventArgs e)
        {
            do_save_val_comment();
        }

        //常に前面表示のトグル
        private void writeFormTopMostCheck_Click(object sender, EventArgs e)
        {
            TopMost = !TopMost;
        }

        //省略行表示クリック
        private void browseBaseCellDataButton_Click(object sender, EventArgs e)
        {
            browse_base_cell_data();
        }

    }


}
