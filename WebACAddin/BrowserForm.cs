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
        public BrowserForm()
        {
            InitializeComponent();
        }

        //アクティブセルのデータを取得
        private void preview_update()
        {
            Excel.Range sa = Globals.ThisAddIn.Application.ActiveCell;
            Excel.Worksheet ash = Globals.ThisAddIn.Application.ActiveSheet;

            string prefix = "<!doctype html><html lang='ja'><head><meta charset='utf-8'></head><body>";
            string body = "";
            string sufix = "</body></html>";

            int r, c = 0;
            r = sa.Row;
            c = sa.Column;
            if (ash.Cells[r, c].Value == null) return;
            Type t = ash.Cells[r, c].Value.GetType();
            if (t.Equals(typeof(string)))
            {
                body = (string)ash.Cells[r, c].Value;
            }
            browserControl.DocumentText = prefix + body + sufix;
        }

        //セル値から更新ボタンをクリック
        private void previewHtmlUpdateButton_Click(object sender, EventArgs e)
        {
            preview_update();
        }
    }
}
