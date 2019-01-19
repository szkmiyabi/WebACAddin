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

namespace WebACAddin
{
    public partial class BrowserForm : Form
    {
        private string storage = "";
        private string prefix = "<!doctype html><html lang='ja'><head><meta charset='utf-8'></head><body>";
        private string sufix = "</body></html>";

        public BrowserForm()
        {
            InitializeComponent();
            //最初にチェックを入れておく
            docSemanticListRadio.Checked = true;
            docSemanticParagraphRadio.Checked = true;
            docSemanticHeadingRadio.Checked = true;
        }

        //アクティブセルのデータを取得
        private void preview_update()
        {
            Excel.Range sa = Globals.ThisAddIn.Application.ActiveCell;
            Excel.Worksheet ash = Globals.ThisAddIn.Application.ActiveSheet;

            int r, c = 0;
            r = sa.Row;
            c = sa.Column;
            string body = "";
            if (ash.Cells[r, c].Value == null) return;
            Type t = ash.Cells[r, c].Value.GetType();
            if (t.Equals(typeof(string)))
            {
                body = (string)ash.Cells[r, c].Value;
            }
            browserControl.DocumentText = prefix + body + sufix;
        }

        //表示をクリア
        private void preview_default()
        {
            browserControl.DocumentText = prefix + storage + sufix;
        }

        //セル値から更新ボタンをクリック
        private void previewHtmlUpdateButton_Click(object sender, EventArgs e)
        {
            preview_update();
        }

        //文書構造解析ボタンクリック
        private void docSemanticsSurveyButton_Click(object sender, EventArgs e)
        {
            storage = browserControl.DocumentText;
            PreservUtil pu = new PreservUtil(ref browserControl);
            if (docSemanticListRadio.Checked == true) pu.tag_list();
            if (docSemanticParagraphRadio.Checked == true) pu.tag_paragraph();
            if (docSemanticHeadingRadio.Checked == true) pu.tag_heading();
            if (docSemanticTableRadio.Checked == true) pu.tag_table();
        }

        //クリアボタンクリック
        private void docSemanticsClearButton_Click(object sender, EventArgs e)
        {
            preview_default();
        }
    }
}
