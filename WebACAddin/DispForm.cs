using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebACAddin
{
    public partial class DispForm : Form
    {
        private Microsoft.Office.Interop.Excel.Worksheet ash;
        private bool isSyncronized;
        private float fontSize;

        //コンストラクタ
        public DispForm()
        {
            InitializeComponent();
            TopMostCheckBox.Checked = true;
            SyncronizedCheckBox.Checked = true;
            isSyncronized = true;
            TopMost = true;
            ash = Globals.ThisAddIn.Application.ActiveSheet;
            ash.SelectionChange += SelectionChanged;
            //ash.SelectionChange += new Microsoft.Office.Interop.Excel.DocEvents_SelectionChangeEventHandler(SelectionChanged);
            fontSize = 10.5f;
            this.ContentTextBox.Font = new Font("ＭＳ Ｐゴシック", fontSize);
            this.Text = "判定結果を整形表示（" + Globals.ThisAddIn.Application.ActiveCell.Address[false, false] + "）";
        }

        //フォームタイトル変更
        private void setTitle(Microsoft.Office.Interop.Excel.Range target)
        {
            this.Text = "判定結果を整形表示（" + target.Address[false, false] + "）";
        }

        //選択切替後アクティブ行の判定結果を整形表示（デリゲート）
        private void SelectionChanged(Microsoft.Office.Interop.Excel.Range target)
        {
            if (isSyncronized)
            {
                int r = target.Row;
                int c = target.Column;
                setTitle(target);
                Globals.Ribbons.Ribbon1.get_survey_disp_wrapper();
            }
        }

        //フォームを閉じたときにデリゲートを削除する
        private void DispForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ash.SelectionChange -= SelectionChanged;
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

        //文字サイズ大
        private void fontSizeLargeButton_Click(object sender, EventArgs e)
        {
            fontSize += 1;
            this.ContentTextBox.Font = new Font("ＭＳ Ｐゴシック", fontSize);
        }

        //文字サイズ小
        private void fontSizeMinusButton_Click(object sender, EventArgs e)
        {
            if (fontSize == 10.5f)
            {
                MessageBox.Show("これ以上小さく出来ません");
                return;
            }
            fontSize -= 1;
            this.ContentTextBox.Font = new Font("ＭＳ Ｐゴシック", fontSize);
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
