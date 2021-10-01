using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebACAddin
{
    public partial class CellViewForm : Form
    {
        //アクティブシート
        private Microsoft.Office.Interop.Excel.Worksheet ash;
        private bool isSyncronized;

        //コンストラクタ
        public CellViewForm()
        {
            InitializeComponent();
            TopMostCheckBox.Checked = true;
            SyncronizedCheckBox.Checked = true;
            isSyncronized = true;
            TopMost = true;
            ash = Globals.ThisAddIn.Application.ActiveSheet;
            FirstTake();
            ash.SelectionChange += SelectionChanged;
            //ash.SelectionChange += new Microsoft.Office.Interop.Excel.DocEvents_SelectionChangeEventHandler(SelectionChanged);
        }

        //初期挙動
        private void FirstTake()
        {
            Microsoft.Office.Interop.Excel.Range sa = Globals.ThisAddIn.Application.ActiveCell;
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
            ContentTextBox.Text = body;
        }

        //選択切替後のセルのデータを表示する（デリゲート）
        private void SelectionChanged(Microsoft.Office.Interop.Excel.Range target)
        {
            if (isSyncronized)
            {
                int r = target.Row;
                int c = target.Column;
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
                ContentTextBox.Text = body;
            }

        }

        //フォームを閉じたときにデリゲートを削除する
        private void CellViewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ash.SelectionChange -= SelectionChanged;
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

        //常に前面表示のトグル
        private void TopMostCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = !TopMost;
        }

        //同期有効のトグル
        private void SyncronizedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            isSyncronized = !isSyncronized;
        }

        //コピー
        private void CopyButton_Click(object sender, EventArgs e)
        {
            string src = ContentTextBox.Text;
            try
            {
                Clipboard.SetDataObject(src, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("コピー失敗しました。\n" + "詳細：" + ex.Message);
            }
        }

        //Ctrl+A実装
        private void ContentTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            //Ctrl + A
            if (e.Control && e.KeyCode == Keys.A)
            {
                e.SuppressKeyPress = true; //beep disabled
                ContentTextBox.SelectAll();
            }
        }
    }
}
