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


        //判定ひな形を生成
        private void get_survey_base_wrapper()
        {
            //LibraPlusモード
            if (isLibraPlusOn)
            {
                lbps_sv_base_wrap();
            }
            //Libraモード
            else
            {
                lb_sv_base_wrap();
            }
        }

        //判定ひな形を作成（Libra）
        private void lb_sv_base_wrap()
        {
            if (frmObj.Visible == false)
                frmObj.Show();
            if(get_survey_base_body != "")
                get_survey_base_body = "";

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
                lb_sv_base();
            }
            frmObj.reportText.Clear();
            frmObj.setTitle("判定ひな形を生成");
            frmObj.reportText.Text = get_survey_base_body;
            frmObj.WindowState = FormWindowState.Normal;
            frmObj.Activate();
        }
        //ひな形生成実装（Libra）
        private void lb_sv_base()
        {
            var sa = excelObj.Application.Selection;
            var ash = excelObj.Application.ActiveSheet;
            int r1, r2, c1, c2;
            string excel_type = "";
            excel_type = get_sheet_type();
            r1 = sa.Row;
            r2 = sa.Rows[sa.Rows.Count].Row;
            c1 = sa.Column;
            c2 = sa.Columns[sa.Columns.Count].Column;

            for (int i = r1; i <= r2; i++)
            {
                string techID = "";
                string sv_flag = "";
                string comment = "";
                string description = "";
                string srccode = "";
                string sv_copy_flag = "no";

                //my-excel
                if(excel_type == "my-excel")
                {
                    techID = (string)ash.Cells[i, 5].Value;
                    sv_flag = (string)ash.Cells[i, 6].Value;
                    comment = _br_encode((string)ash.Cells[i, 8].Value);
                    description = _br_encode((string)ash.Cells[i, 9].Value);
                    srccode = _br_encode((string)ash.Cells[i, 10].Value);
                }
                //libra-excel
                else if(excel_type == "libra-excel")
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
                    techID = (string)ash.Cells[i, 7].Value;
                    comment = _br_encode((string)ash.Cells[i, 5].Value);
                    description = _br_encode((string)ash.Cells[i, 4].Value);
                    srccode = _br_encode((string)ash.Cells[i, 6].Value);
                }

                get_survey_base_body += techID + tab_sp + sv_flag + tab_sp + sv_copy_flag + tab_sp + "who" + tab_sp;
                get_survey_base_body += comment + tab_sp + description + tab_sp + srccode;
                get_survey_base_body += "\r\n\r\n";
                get_survey_base_body += "---------------------\r\n\r\n";
            }
        }

        //判定ひな形を作成（LibraPlus）
        private void lbps_sv_base_wrap()
        {
            if (frmObj.Visible == false)　frmObj.Show();
            if (get_survey_base_body != "")　get_survey_base_body = "";

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
                lbps_sv_base();
            }
            frmObj.reportText.Clear();
            frmObj.setTitle("判定ひな形を生成");
            frmObj.reportText.Text = get_survey_base_body;
            frmObj.WindowState = FormWindowState.Normal;
            frmObj.Activate();

        }
        //ひな形生成実装（LibraPlus）
        private void lbps_sv_base()
        {
            var sa = excelObj.Application.Selection;
            var ash = excelObj.Application.ActiveSheet;
            int r1, r2, c1, c2;
            string excel_type = "";
            excel_type = get_sheet_type();
            r1 = sa.Row;
            r2 = sa.Rows[sa.Rows.Count].Row;
            c1 = sa.Column;
            c2 = sa.Columns[sa.Columns.Count].Column;

            for (int i = r1; i <= r2; i++)
            {
                string sv_flag = "";
                string comment = "";
                string description = "";
                string srccode = "";

                //fail-report
                if (excel_type == "fail-report")
                {
                    string sheetName = ash.Name;
                    if (sheetName == "検査結果(不適合)")
                    {
                        sv_flag = "いいえ";
                    }
                    else if (sheetName == "検査結果(適合注記)")
                    {
                        sv_flag = "はい(注記)";
                    }
                    sv_flag = "いいえ";
                    comment = _br_encode((string)ash.Cells[i, 7].Value);
                    description = _br_encode((string)ash.Cells[i, 8].Value);
                    srccode = _br_encode((string)ash.Cells[i, 9].Value);
                }
                //all-report
                else if (excel_type == "all-report")
                {
                    sv_flag = _br_encode((string)ash.Cells[i, 6].Value);
                    comment = _br_encode((string)ash.Cells[i, 8].Value);
                    description = _br_encode((string)ash.Cells[i, 9].Value);
                    srccode = _br_encode((string)ash.Cells[i, 10].Value);
                }
                //category-sv
                else if(excel_type == "category-sv")
                {
                    sv_flag = _br_encode((string)ash.Cells[i, 4].Value);
                    comment = _br_encode((string)ash.Cells[i, 6].Value);
                    description = _br_encode((string)ash.Cells[i, 7].Value);
                    srccode = _br_encode((string)ash.Cells[i, 8].Value);
                }

                get_survey_base_body += "any" + tab_sp + sv_flag + tab_sp + "any" + tab_sp + "who" + tab_sp;
                get_survey_base_body += comment + tab_sp + description + tab_sp + srccode;
                get_survey_base_body += "\r\n\r\n";
                get_survey_base_body += "---------------------\r\n\r\n";
            }
        }

        //判定結果を整形表示
        public void get_survey_disp_wrapper()
        {
            //LibraPlusモード
            if (isLibraPlusOn)
            {
                lbps_sv_disp_wrap();
            }
            //Libraモード
            else
            {
                lb_sv_disp_wrap();
            }
        }

        //判定結果を整形表示（Libra）
        private void lb_sv_disp_wrap()
        {
            if (get_wa_check_comment_base_body != "") get_wa_check_comment_base_body = "";
            if (dpfrmObj.Visible == false) dpfrmObj.Show();

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
                lb_sv_disp();
            }

            dpfrmObj.ContentTextBox.Clear();
            dpfrmObj.ContentTextBox.Text = get_wa_check_comment_base_body;
            dpfrmObj.WindowState = FormWindowState.Normal;
            dpfrmObj.Activate();
            dpfrmObj.ContentTextBox.Select(0, 0);


        }
        //判定結果を整形表示実装（Libra）
        private void lb_sv_disp()
        {
            var sa = excelObj.Application.Selection;
            var ash = excelObj.Application.ActiveSheet;
            int r1, r2, c1, c2;
            string excel_type = "";
            excel_type = get_sheet_type();
            r1 = sa.Row;
            r2 = sa.Rows[sa.Rows.Count].Row;
            c1 = sa.Column;
            c2 = sa.Columns[sa.Columns.Count].Column;

            for (int i=r1; i<=r2; i++)
            {
                //my-excel
                if(excel_type == "my-excel")
                {
                    string guideline = (string)ash.Cells[i, 3].Value;
                    string pageID = (string)ash.Cells[i, 1].Value;
                    string techID = (string)ash.Cells[i, 5].Value;
                    string sv_flag = _text_clean((string)ash.Cells[i, 6].Value);
                    string comment = _sv_disp_text_clean((string)ash.Cells[i, 8].Value);
                    string description = _sv_disp_text_clean((string)ash.Cells[i, 9].Value);
                    string srccode = _sv_disp_text_clean((string)ash.Cells[i, 10].Value);

                    get_wa_check_comment_base_body += "■ページID: " + pageID + "\r\n";
                    get_wa_check_comment_base_body += "■達成基準: " + guideline + "\r\n";
                    get_wa_check_comment_base_body += "■達成方法番号: " + techID + "\r\n\r\n";
                    get_wa_check_comment_base_body += "■判定: " + sv_flag + "\r\n\r\n";
                    get_wa_check_comment_base_body += "■判定コメント:" + "\r\n" + comment + "\r\n\r\n";
                    get_wa_check_comment_base_body += "■対象ソースコード:" + "\r\n" + description + "\r\n\r\n";
                    get_wa_check_comment_base_body += "■修正ソースコード:" + "\r\n" + srccode + "\r\n\r\n\r\n";
                }
                //libra-excel
                else if(excel_type == "libra-excel")
                {
                    string sv_flag = "";
                    string sheetName = ash.Name;
                    if (sheetName == "検査結果(ページ単位)" || sheetName == "検査結果(対象ソースコード単位)")
                    {
                        sv_flag = "不適合";
                    }
                    else if (sheetName == "検査結果(適合(注記))")
                    {
                        sv_flag = "適合(注記)";
                    }
                    string guidelineAndtechID = (string)ash.Cells[i, 7].Value;
                    string pageID = (string)ash.Cells[i, 1].Value;
                    string comment = _sv_disp_text_clean((string)ash.Cells[i, 5].Value);
                    string description = _sv_disp_text_clean((string)ash.Cells[i, 4].Value);
                    string srccode = _sv_disp_text_clean((string)ash.Cells[i, 6].Value);

                    get_wa_check_comment_base_body += "■ページID: " + pageID + "\r\n";
                    get_wa_check_comment_base_body += "■達成基準/実装番号: " + guidelineAndtechID + "\r\n\r\n";
                    get_wa_check_comment_base_body += "■判定: " + sv_flag + "\r\n\r\n";
                    get_wa_check_comment_base_body += "■判定コメント:" + "\r\n" + comment + "\r\n\r\n";
                    get_wa_check_comment_base_body += "■対象ソースコード:" + "\r\n" + description + "\r\n\r\n";
                    get_wa_check_comment_base_body += "■修正ソースコード:" + "\r\n" + srccode + "\r\n\r\n\r\n";
                }

            }

        }

        //判定結果を整形表示（LibraPlus）
        private void lbps_sv_disp_wrap()
        {
            if (get_wa_check_comment_base_body != "") get_wa_check_comment_base_body = "";
            if (dpfrmObj.Visible == false) dpfrmObj.Show();

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
                lbps_sv_disp();
            }

            dpfrmObj.ContentTextBox.Clear();
            dpfrmObj.ContentTextBox.Text = get_wa_check_comment_base_body;
            dpfrmObj.WindowState = FormWindowState.Normal;
            dpfrmObj.Activate();
            dpfrmObj.ContentTextBox.Select(0, 0);
        }
        //判定結果を整形表示実装（LibraPlus）
        private void lbps_sv_disp()
        {
            var sa = excelObj.Application.Selection;
            var ash = excelObj.Application.ActiveSheet;
            int r1, r2, c1, c2;
            string excel_type = "";
            excel_type = get_sheet_type();
            r1 = sa.Row;
            r2 = sa.Rows[sa.Rows.Count].Row;
            c1 = sa.Column;
            c2 = sa.Columns[sa.Columns.Count].Column;

            for (int i = r1; i <= r2; i++)
            {
                //fail-report
                if (excel_type == "fail-report")
                {
                    string sv_flag = "";
                    string sheetName = ash.Name;
                    if (sheetName == "検査結果(不適合)")
                    {
                        sv_flag = "いいえ";
                    }
                    else if (sheetName == "検査結果(適合注記)")
                    {
                        sv_flag = "はい(注記)";
                    }
                    string svID = (string)ash.Cells[i, 13].Value;
                    string category = (string)ash.Cells[i, 3].Value;
                    string guideline = (string)ash.Cells[i, 5].Value;
                    string pageID = (string)ash.Cells[i, 1].Value;
                    string comment = _sv_disp_text_clean((string)ash.Cells[i, 7].Value);
                    string description = _sv_disp_text_clean((string)ash.Cells[i, 8].Value);
                    string srccode = _sv_disp_text_clean((string)ash.Cells[i, 9].Value);

                    get_wa_check_comment_base_body += "■ページID: " + pageID + "\r\n";
                    get_wa_check_comment_base_body += "■検査カテゴリ: " + category + "\r\n";
                    get_wa_check_comment_base_body += "■達成基準/達成方法: " + guideline + "\r\n";
                    get_wa_check_comment_base_body += "■検査番号: " + svID + "\r\n\r\n";
                    get_wa_check_comment_base_body += "■判定: " + sv_flag + "\r\n\r\n";
                    get_wa_check_comment_base_body += "■判定コメント:" + "\r\n" + comment + "\r\n\r\n";
                    get_wa_check_comment_base_body += "■対象ソースコード:" + "\r\n" + description + "\r\n\r\n";
                    get_wa_check_comment_base_body += "■修正ソースコード:" + "\r\n" + srccode + "\r\n\r\n\r\n";

                }
                //all-report
                else if (excel_type == "all-report")
                {
                    string category = (string)ash.Cells[i, 3].Value;
                    string guideline = (string)ash.Cells[i, 5].Value;
                    string pageID = (string)ash.Cells[i, 1].Value;
                    string sv_flag = _text_clean((string)ash.Cells[i, 6].Value);
                    string comment = _sv_disp_text_clean((string)ash.Cells[i, 8].Value);
                    string description = _sv_disp_text_clean((string)ash.Cells[i, 9].Value);
                    string srccode = _sv_disp_text_clean((string)ash.Cells[i, 10].Value);

                    get_wa_check_comment_base_body += "■ページID: " + pageID + "\r\n";
                    get_wa_check_comment_base_body += "■検査カテゴリ: " + category + "\r\n";
                    get_wa_check_comment_base_body += "■達成基準/達成方法: " + guideline + "\r\n\r\n";
                    get_wa_check_comment_base_body += "■判定: " + sv_flag + "\r\n\r\n";
                    get_wa_check_comment_base_body += "■判定コメント:" + "\r\n" + comment + "\r\n\r\n";
                    get_wa_check_comment_base_body += "■対象ソースコード:" + "\r\n" + description + "\r\n\r\n";
                    get_wa_check_comment_base_body += "■修正ソースコード:" + "\r\n" + srccode + "\r\n\r\n\r\n";
                }
                //category-sv
                else if (excel_type == "category-sv")
                {
                    string sv_flag = _text_clean((string)ash.Cells[i, 4].Value);
                    string guidelineAndtechID = (string)ash.Cells[i, 3].Value;
                    string svID = (string)ash.Cells[i, 1].Value;
                    string comment = _sv_disp_text_clean((string)ash.Cells[i, 6].Value);
                    string description = _sv_disp_text_clean((string)ash.Cells[i, 7].Value);
                    string srccode = _sv_disp_text_clean((string)ash.Cells[i, 8].Value);

                    get_wa_check_comment_base_body += "■検査番号: " + svID + "\r\n";
                    get_wa_check_comment_base_body += "■達成基準/達成方法: " + guidelineAndtechID + "\r\n\r\n";
                    get_wa_check_comment_base_body += "■判定: " + sv_flag + "\r\n\r\n";
                    get_wa_check_comment_base_body += "■判定コメント:" + "\r\n" + comment + "\r\n\r\n";
                    get_wa_check_comment_base_body += "■対象ソースコード:" + "\r\n" + description + "\r\n\r\n";
                    get_wa_check_comment_base_body += "■修正ソースコード:" + "\r\n" + srccode + "\r\n\r\n\r\n";
                }

            }

        }

        //改行をブックマークレット方式改行タグに変換
        private string _br_encode(string str)
        {
            if (str == "" || str == null)
            {
                return "";
            }
            return Regex.Replace(str, @"(\r\n|\r|\n)", br_sp, RegexOptions.Multiline);
        }

        //判定表示用テキストのお掃除
        private string _sv_disp_text_clean(string str)
        {
            string ret = "";
            try
            {
                str = Regex.Replace(str, @"^ +", "", RegexOptions.Multiline);
                str = Regex.Replace(str, @"\t+", "", RegexOptions.Multiline);
                str = Regex.Replace(str, @"(\r|\n)", "\r\n", RegexOptions.Multiline);
                ret = str;
            }
            catch (Exception ex)
            {
            }
            return ret;
        }

        //表種類の判定
        private string get_sheet_type()
        {
            var ash = excelObj.Application.ActiveSheet;
            string type_name = "";
            string[] lb_type_name = { "my-excel", "libra-excel" };
            string[] lbps_type_name = { "fail-report", "all-report", "category-sv" };


            if (isLibraPlusOn)
            {
                if ((string)ash.Cells[1, 1].Value == "管理番号" && (string)ash.Cells[1, 12].Value != "更新者")
                {
                        type_name = lbps_type_name[0];
                }
                else if((string)ash.Cells[1, 1].Value == "管理番号" && (string)ash.Cells[1, 12].Value == "更新者")
                {
                    type_name = lbps_type_name[1];
                }
                else if((string)ash.Cells[1,1].Value == "検査番号")
                {
                    type_name = lbps_type_name[2];
                }
            }
            else
            {
                if((string)ash.Cells[1,3].Value == "達成基準")
                {
                    type_name = lb_type_name[0];
                }
                else if((string)ash.Cells[1,3].Value == "行番号")
                {
                    type_name = lb_type_name[1];
                }
            }
            return type_name;
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
