﻿using System;
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
    public partial class RepoUpdForm : Form
    {
        private string tab_sp = "<bkmk:tab>";
        private string br_sp = "<bkmk:br>";

        //コンストラクタ
        public RepoUpdForm()
        {
            InitializeComponent();
        }

        //Libraの判定ひな形をExcelに反映
        private void update_report_row()
        {
            Excel.Range sa = Globals.ThisAddIn.Application.ActiveCell;
            Excel.Worksheet ash = Globals.ThisAddIn.Application.ActiveSheet;

            if (ash.Name != "検査結果") return;
            string src = srcText.Text;
            if (src == null || src == "") return;

            //デリゲート（改行デコード）
            Func<string, string> _text = delegate (string str)
            {
                if (str == "" || str == null) return "";
                return str.Replace(br_sp, "\n");
            };

            //デリゲート（新旧セルデータを判断した書き換え）
            Func<string, string, string> _ov = delegate (string cell_val, string new_val)
            {
                if (new_val == null && cell_val == null) return "";
                if (cell_val == null) return new_val;

                cell_val = cell_val.TrimStart().TrimEnd();
                new_val = new_val.TrimStart().TrimEnd();

                string ret = "";

                List<string> sv_hash = new List<string>() { "適合", "不適合", "非適用", "適合(注記)", "未" };
                if (sv_hash.Contains(cell_val))
                {
                    if (cell_val == new_val) ret = cell_val;
                    else ret = cell_val + "\n↓\n" + new_val;
                }
                else
                {
                    if (cell_val == new_val) ret = cell_val;
                    else ret = cell_val + "\n\n" + new_val;
                }
                return ret;
            };

            string opt_type = (overWriteCheck.Checked == true) ? "ov" : "new";

            int r = sa.Row;
            string[] cols = Regex.Split(src, tab_sp);
            string sv = cols[1];
            string comment = _text(cols[4]);
            string description = _text(cols[5]);
            string srccode = _text(cols[6]);

            if(opt_type == "ov")
            {
                ash.Cells[r, 6].Value = _ov((string)ash.Cells[r, 6].Value, sv);
                ash.Cells[r, 8].Value = _ov((string)ash.Cells[r, 8].Value, comment);
                ash.Cells[r, 9].Value = _ov((string)ash.Cells[r, 9].Value, description);
                ash.Cells[r, 10].Value = _ov((string)ash.Cells[r, 10].Value, srccode);
            }
            else if(opt_type == "new")
            {
                ash.Cells[r, 6].Value = _ov((string)ash.Cells[r, 6].Value, sv);
                ash.Cells[r, 8].Value = comment;
                ash.Cells[r, 9].Value = description;
                ash.Cells[r, 10].Value = srccode;
            }

        }

        //変更を反映をクリック
        private void repoUpdateButton_Click(object sender, EventArgs e)
        {
            update_report_row();
            this.Dispose();
        }
    }
}
