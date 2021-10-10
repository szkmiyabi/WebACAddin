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
    public partial class RepoUpdForm : Form
    {
        private string tab_sp = "<bkmk:tab>";
        private string br_sp = "<bkmk:br>";

        //コンストラクタ
        public RepoUpdForm()
        {
            InitializeComponent();
            TopMost = true;
        }

        //Libraの判定ひな形をExcelに反映
        private void update_report_row()
        {
            Boolean isLibraPlus = Globals.Ribbons.Ribbon1.getIsLibraPlusOn();

            Excel.Range sa = Globals.ThisAddIn.Application.ActiveCell;
            Excel.Worksheet ash = Globals.ThisAddIn.Application.ActiveSheet;

            string src = srcText.Text;
            if (src == null || src == "") return;

            //デリゲート（改行デコード）
            Func<string, string> _text = delegate (string str)
            {
                if (str == "" || str == null) return "";
                return str.Replace(br_sp, "\n");
            };

            //デリゲート（新旧セルデータを判断した書き換え）
            Func<string, string, Boolean, string> _ov = delegate (string cell_val, string new_val, Boolean lbps_flg)
            {
                if (new_val == null && cell_val == null) return "";
                if (cell_val == null) return new_val;

                cell_val = cell_val.TrimStart().TrimEnd();
                new_val = new_val.TrimStart().TrimEnd();

                string ret = "";

                List<string> sv_hash;
                if (lbps_flg)
                {
                    sv_hash = new List<string>() { "はい", "いいえ", "なし", "はい(注記)", "未" };
                }
                else
                {
                    sv_hash = new List<string>() { "適合", "不適合", "非適用", "適合(注記)", "未" };

                }

                if (sv_hash.Contains(cell_val))
                {
                    if (cell_val == new_val) ret = cell_val;
                    else ret = cell_val + "\n↓\n" + new_val;
                }
                else
                {
                    if (cell_val == new_val) ret = cell_val;
                    else ret = cell_val + "\n\n↓修正後\n\n" + new_val;
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

            string excel_type = get_sheet_type();

            if(opt_type == "ov")
            {
                if (isLibraPlus)
                {
                    if(excel_type == "all-report")
                    {
                        ash.Cells[r, 6].Value = _ov((string)ash.Cells[r, 6].Value, sv, true);
                        ash.Cells[r, 8].Value = _ov((string)ash.Cells[r, 8].Value, comment, true);
                        ash.Cells[r, 9].Value = _ov((string)ash.Cells[r, 9].Value, description, true);
                        ash.Cells[r, 10].Value = _ov((string)ash.Cells[r, 10].Value, srccode, true);
                    }
                    else if(excel_type == "category-sv")
                    {
                        ash.Cells[r, 4].Value = _ov((string)ash.Cells[r, 4].Value, sv, true);
                        ash.Cells[r, 6].Value = _ov((string)ash.Cells[r, 6].Value, comment, true);
                        ash.Cells[r, 7].Value = _ov((string)ash.Cells[r, 7].Value, description, true);
                        ash.Cells[r, 8].Value = _ov((string)ash.Cells[r, 8].Value, srccode, true);
                    }
                    else if(excel_type == "fail-report")
                    {
                        ash.Cells[r, 6].Value = _ov((string)ash.Cells[r, 7].Value, comment, true);
                        ash.Cells[r, 7].Value = _ov((string)ash.Cells[r, 8].Value, description, true);
                        ash.Cells[r, 8].Value = _ov((string)ash.Cells[r, 9].Value, srccode, true);
                    }
                    else
                    {
                        MessageBox.Show("動作対象外のSheetです。");
                        return;
                    }

                }
                else
                {
                    if(excel_type == "my-excel")
                    {
                        ash.Cells[r, 6].Value = _ov((string)ash.Cells[r, 6].Value, sv, false);
                        ash.Cells[r, 8].Value = _ov((string)ash.Cells[r, 8].Value, comment, false);
                        ash.Cells[r, 9].Value = _ov((string)ash.Cells[r, 9].Value, description, false);
                        ash.Cells[r, 10].Value = _ov((string)ash.Cells[r, 10].Value, srccode, false);
                    }
                    else
                    {
                        MessageBox.Show("動作対象外のSheetです。");
                        return;
                    }

                }

            }
            else if(opt_type == "new")
            {
                if (isLibraPlus)
                {
                    if(excel_type == "all-report")
                    {
                        ash.Cells[r, 6].Value = _ov((string)ash.Cells[r, 6].Value, sv, true);
                        ash.Cells[r, 8].Value = comment;
                        ash.Cells[r, 9].Value = description;
                        ash.Cells[r, 10].Value = srccode;
                    }
                    else if (excel_type == "category-sv")
                    {
                        ash.Cells[r, 4].Value = _ov((string)ash.Cells[r, 4].Value, sv, true);
                        ash.Cells[r, 6].Value = comment;
                        ash.Cells[r, 7].Value = description;
                        ash.Cells[r, 8].Value = srccode;
                    }
                    else if(excel_type == "fail-report")
                    {
                        ash.Cells[r, 7].Value = comment;
                        ash.Cells[r, 8].Value = description;
                        ash.Cells[r, 9].Value = srccode;
                    }
                    else
                    {
                        MessageBox.Show("動作対象外のSheetです。");
                        return;
                    }

                }
                else
                {
                    if (excel_type == "my-excel")
                    {
                        ash.Cells[r, 6].Value = _ov((string)ash.Cells[r, 6].Value, sv, false);
                        ash.Cells[r, 8].Value = comment;
                        ash.Cells[r, 9].Value = description;
                        ash.Cells[r, 10].Value = srccode;
                    }
                    else
                    {
                        MessageBox.Show("動作対象外のSheetです。");
                        return;
                    }

                }

            }

        }

        //変更を反映をクリック
        private void repoUpdateButton_Click(object sender, EventArgs e)
        {
            update_report_row();
            this.Dispose();
        }

        //表種類の判定
        private string get_sheet_type()
        {
            var ash = Globals.ThisAddIn.Application.ActiveSheet;
            string type_name = "";
            string[] lb_type_name = { "my-excel", "libra-excel" };
            string[] lbps_type_name = { "fail-report", "all-report", "category-sv" };

            if (Globals.Ribbons.Ribbon1.getIsLibraPlusOn())
            {
                if ((string)ash.Cells[1, 13].Value == "検査番号")
                {
                    type_name = lbps_type_name[0];
                }
                else if ((string)ash.Cells[1, 12].Value == "更新者")
                {
                    type_name = lbps_type_name[1];
                }
                else if ((string)ash.Cells[1, 1].Value == "検査番号")
                {
                    type_name = lbps_type_name[2];
                }
            }
            else
            {
                if ((string)ash.Cells[1, 3].Value == "達成基準")
                {
                    type_name = lb_type_name[0];
                }
                else if ((string)ash.Cells[1, 3].Value == "行番号")
                {
                    type_name = lb_type_name[1];
                }
            }
            return type_name;
        }
    }
}
