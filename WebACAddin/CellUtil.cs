using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using System.IO;

namespace WebACAddin
{
    partial class Ribbon1
    {

        //独自改行タグ
        private string tab_sp = "<bkmk:tab>";
        private string br_sp = "<bkmk:br>";

        //メソッドが使用するプライベートな広域変数
        private string get_wa_check_comment_base_body = "";
        private string get_survey_base_body = "";

        //判定ひな形を作成
        private void get_survey_base_wrapper()
        {
            if (frmObj.Visible == false)
            {
                frmObj.Show();
            }

            if(get_survey_base_body != "")
            {
                get_survey_base_body = "";
            }

            Excel.Range sa = Globals.ThisAddIn.Application.ActiveCell;
            Excel.Worksheet ash = Globals.ThisAddIn.Application.ActiveSheet;
            Excel.Areas areas = Globals.ThisAddIn.Application.Selection.Areas;

            List<string> selectionList = new List<string>();
            foreach (Excel.Range item in areas)
            {
                selectionList.Add(item.Address);
            }
            ash.Range[selectionList[0]].Select();
            for (int i = 0; i < selectionList.Count; i++)
            {
                ash.Range[selectionList[i]].Select();
                get_survey_base();
            }
            frmObj.reportText.Clear();
            frmObj.reportText.Text = get_survey_base_body;
            frmObj.WindowState = FormWindowState.Normal;
            frmObj.Activate();

        }
        private void get_survey_base()
        {

            var sa = excelObj.Application.Selection;
            var ash = excelObj.Application.ActiveSheet;

            int r1, r2, c1, c2;
            string excel_type = "";
            string opt_type = "";

            r1 = sa.Row;
            r2 = sa.Rows[sa.Rows.Count].Row;
            c1 = sa.Column;
            c2 = sa.Columns[sa.Columns.Count].Column;

            try
            {
                excel_type = (string)ash.Cells[1, 3].Value;
            }
            catch (Exception ex) {}
            if (excel_type == "達成基準" || excel_type == "") opt_type = "my-excel";
            else if (excel_type == "対象ソースコード") opt_type = "libra-excel";

            for (int i = r1; i <= r2; i++)
            {

                string guideline = "";
                string pageID = "";
                string techID = "";
                string sv_flag = "";
                string comment = "";
                string description = "";
                string srccode = "";
                string sv_copy_flag = "no";

                //my-excel
                if(opt_type == "my-excel")
                {
                    guideline = (string)ash.Cells[i, 3].Value;
                    pageID = (string)ash.Cells[i, 1].Value;
                    techID = (string)ash.Cells[i, 5].Value;
                    sv_flag = (string)ash.Cells[i, 6].Value;
                    comment = _br_encode((string)ash.Cells[i, 8].Value);
                    description = _br_encode((string)ash.Cells[i, 9].Value);
                    srccode = _br_encode((string)ash.Cells[i, 10].Value);
                }
                //libra-excel
                else if(opt_type == "libra-excel")
                {
                    string sheetName = ash.Name;
                    if(sheetName == "検査結果(ページ単位)" || sheetName == "検査結果(対象ソースコード単位)")
                    {
                        sv_flag = "不適合";
                    }
                    else if(sheetName == "検査結果(適合(注記))")
                    {
                        sv_flag = "適合(注記)";
                    }
                    guideline = (string)ash.Cells[i, 6].Value;
                    pageID = (string)ash.Cells[i, 1].Value;
                    techID = (string)ash.Cells[i, 6].Value; //guidelineと同じセル
                    comment = _text_clean((string)ash.Cells[i, 4].Value);
                    description = _br_encode((string)ash.Cells[i, 3].Value);
                    srccode = _text_clean((string)ash.Cells[i, 5].Value);
                }

                get_survey_base_body += techID + tab_sp + sv_flag + tab_sp + sv_copy_flag + tab_sp + "who" + tab_sp;
                get_survey_base_body += comment + tab_sp + description + tab_sp + srccode;
                get_survey_base_body += "\r\n\r\n";
                get_survey_base_body += "---------------------\r\n\r\n";

            }

        }
        private string _br_encode(string str)
        {
            if (str == "" || str == null)
            {
                return "";
            }
            return Regex.Replace(str, @"(\r\n|\r|\n)", br_sp, RegexOptions.Multiline);
        }

        //品質チェック指摘コメントのひな形を作成
        private void get_wa_check_comment_base_wrapper()
        {
            if (get_wa_check_comment_base_body != "")
            {
                get_wa_check_comment_base_body = "";
            }

            if (frmObj.Visible == false)
            {
                frmObj.Show();
            }

            Excel.Range sa = Globals.ThisAddIn.Application.ActiveCell;
            Excel.Worksheet ash = Globals.ThisAddIn.Application.ActiveSheet;
            Excel.Areas areas = Globals.ThisAddIn.Application.Selection.Areas;

            List<string> selectionList = new List<string>();
            foreach (Excel.Range item in areas)
            {
                selectionList.Add(item.Address);
            }
            ash.Range[selectionList[0]].Select();
            for (int i = 0; i < selectionList.Count; i++)
            {
                ash.Range[selectionList[i]].Select();
                get_wa_check_comment_base();
            }

            frmObj.reportText.Clear();
            frmObj.reportText.Text = get_wa_check_comment_base_body;
            frmObj.WindowState = FormWindowState.Normal;
            frmObj.Activate();

        }
        private void get_wa_check_comment_base()
        {

            var sa = excelObj.Application.Selection;
            var ash = excelObj.Application.ActiveSheet;

            int r1, r2, c1, c2;
            string excel_type = "";
            string opt_type = "";

            r1 = sa.Row;
            r2 = sa.Rows[sa.Rows.Count].Row;
            c1 = sa.Column;
            c2 = sa.Columns[sa.Columns.Count].Column;

            try
            {
                excel_type = (string)ash.Cells[1, 3].Value;
            }
            catch (Exception ex) { }
            if (excel_type == "達成基準" || excel_type == "") opt_type = "my-excel";
            else if (excel_type == "対象ソースコード") opt_type = "libra-excel";

            for (int i=r1; i<=r2; i++)
            {

                //my-excel
                if(opt_type == "my-excel" || opt_type == "")
                {
                    string guideline = (string)ash.Cells[i, 3].Value;
                    string pageID = (string)ash.Cells[i, 1].Value;
                    string techID = (string)ash.Cells[i, 5].Value;
                    string sv_flag = (string)ash.Cells[i, 6].Value;
                    string comment = _text_clean((string)ash.Cells[i, 8].Value);
                    string description = _text_clean((string)ash.Cells[i, 9].Value);
                    string srccode = _text_clean((string)ash.Cells[i, 10].Value);

                    get_wa_check_comment_base_body += pageID + "\r\n";
                    get_wa_check_comment_base_body += "達成基準: " + guideline + "\r\n";
                    get_wa_check_comment_base_body += "達成方法番号: " + techID + "\r\n";
                    get_wa_check_comment_base_body += "判定: " + sv_flag + "\r\n";
                    get_wa_check_comment_base_body += "判定コメント:" + "\r\n" + comment + "\r\n";
                    get_wa_check_comment_base_body += "対象ソース:" + "\r\n" + description + "\r\n\r\n";
                    get_wa_check_comment_base_body += "修正ソース:" + "\r\n" + srccode + "\r\n\r\n\r\n";
                }
                //libra-excel
                else if(opt_type == "libra-excel")
                {
                    string guidelineAndtechID = (string)ash.Cells[i, 6].Value;
                    string pageID = (string)ash.Cells[i, 1].Value;
                    string comment = _text_clean((string)ash.Cells[i, 4].Value);
                    string description = _text_clean((string)ash.Cells[i, 3].Value);
                    string srccode = _text_clean((string)ash.Cells[i, 5].Value);

                    get_wa_check_comment_base_body += pageID + "\r\n";
                    get_wa_check_comment_base_body += "達成基準/実装番号:\r\n" + guidelineAndtechID + "\r\n";
                    get_wa_check_comment_base_body += "判定コメント:" + "\r\n" + comment + "\r\n";
                    get_wa_check_comment_base_body += "対象ソース:" + "\r\n" + description + "\r\n\r\n";
                    get_wa_check_comment_base_body += "修正ソース:" + "\r\n" + srccode + "\r\n\r\n\r\n";
                }

            }

        }
        private string _text_clean(string str)
        {
            string ret = "";
            try
            {
                str = Regex.Replace(str, @"^ +", "", RegexOptions.Multiline);
                str = Regex.Replace(str, @"\t+", "", RegexOptions.Multiline);
                str = Regex.Replace(str, @"(\r\n|\r|\n)", "", RegexOptions.Multiline);
                ret = str;
            }
            catch(Exception ex)
            {
            }
            return ret;
        }

        //修正ソースコードを簡易的に表示
        private void do_disp_htmlcode()
        {
            var sa = excelObj.Application.Selection;
            var ash = excelObj.Application.ActiveSheet;

            int r, c = 0;
            string prefix = "<!doctype html><html lang='ja'><head><meta charset='utf-8'></head><body>";
            string body = "";
            string sufix = "</body></html>";

            r = sa.Row;
            c = sa.Column;

            if (ash.Cells[r, c].Value == null) return;
            Type t = ash.Cells[r, c].Value.GetType();
            if (t.Equals(typeof(string)))
            {
                body = (string)ash.Cells[r, c].Value;
            }
            brfrmObj.Show();
            brfrmObj.browserControl.DocumentText = prefix + body + sufix;
            brfrmObj.WindowState = FormWindowState.Normal;
            brfrmObj.Activate();

        }

        //コントラスト比検査結果を簡易的に表示
        private void do_disp_contrast_preview()
        {
            var sa = excelObj.Application.Selection;
            var ash = excelObj.Application.ActiveSheet;
            int r, c = 0;
            string body = "";
            r = sa.Row;
            c = sa.Column;
            if (ash.Cells[r, c].Value == null) return;
            Type t = ash.Cells[r, c].Value.GetType();
            if (t.Equals(typeof(string)))
            {
                body = (string)ash.Cells[r, c].Value;
            }
            cnfrmObj.Show();
            cnfrmObj.contrastRatioText.Text = body;
            cnfrmObj.WindowState = FormWindowState.Normal;
            cnfrmObj.Activate();
        }

    }
}
