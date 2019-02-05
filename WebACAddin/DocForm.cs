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
    public partial class DocForm : Form
    {
        public DocForm()
        {
            InitializeComponent();
        }

        //Ctrl + A の実装
        private void docFormText_KeyDown(object sender, KeyEventArgs e)
        {
            //Ctrl + A を実装
            if (e.Control && e.KeyCode == Keys.A)
            {
                e.SuppressKeyPress = true; //beep禁止
                docFormText.SelectAll();
            }
        }

        //urlを見つける
        private string get_current_url(Excel.Worksheet ash, int rn, int cn)
        {
            string ret = "";
            do
            {
                rn--;
            } while (ash.Cells[rn, cn].Value == null);

            Type t = ash.Cells[rn, cn].Value.GetType();
            if(t.Equals(typeof(string))) {
                ret = (string)ash.Cells[rn, cn].Value;
            }
            return ret;
        }

        //検査報告書からWord貼り付けひな形を抽出
        private void load_cell_data()
        {
            Excel.Range sa = Globals.ThisAddIn.Application.ActiveCell;
            Excel.Worksheet ash = Globals.ThisAddIn.Application.ActiveSheet;

            int r1, r2, c1, c2 = 0;
            int dt = 0;
            string buf = "";
            string alltxt = "";
            string pid = "";
            string url = "";
            string techid = "";
            string comment = "";
            string description = "";
            string srccode = "";

            if (failCategoryFieldCheck.Checked == true) dt++;

            r1 = sa.Row;
            r2 = sa.Rows[sa.Rows.Count].Row;
            c1 = sa.Column;
            c2 = sa.Columns[sa.Columns.Count].Column;

            buf = ash.Cells[r1, c1].Value;
            if (buf != null) pid = buf;

            buf = get_current_url(ash, r1, c1 + 1);
            if (buf != "") url = buf;

            buf = ash.Cells[r1, c1 + dt + 3].Value;
            if (buf != null) comment = buf;

            buf = ash.Cells[r1, c1 + dt + 2].Value;
            if (buf != null) description = buf;

            buf = ash.Cells[r1, c1 + dt + 4].Value;
            if (buf != null) srccode = buf;

            buf = ash.Cells[r1, c1 + dt + 5].Value;
            if (buf != null) techid = buf;

            if (pageNumIncludeCheck.Checked == true) alltxt += pid + "\r\n\r\n";
            if (urlstrIncludeCheck.Checked == true) alltxt += url + "\r\n\r\n";

            alltxt += "達成基準/実装番号" + "\r\n" + techid + "\r\n\r\n";
            alltxt += "判定コメント" + "\r\n" + comment + "\r\n\r\n";
            alltxt += "対象ソースコード" + "\r\n" + description + "\r\n\r\n";
            alltxt += "修正案" + "\r\n" + srccode + "\r\n\r\n";

            docFormText.Text = alltxt;


        }

        //セル読込
        private void docLoadCellDataButton_Click(object sender, EventArgs e)
        {
            load_cell_data();
        }
    }
}
