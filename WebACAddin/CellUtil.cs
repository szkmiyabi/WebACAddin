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

        private string tab_sp = "<bkmk:tab>";
        private string br_sp = "<bkmk:br>";


        //カラーコード取得
        private void get_color_code()
        {
            try
            {
                cellValText.Text = "";
                string color_code = "";
                var acl = excelObj.Application.ActiveCell;
                color_code = acl.Interior.ColorIndex.ToString();
                cellValText.Text = color_code;
            }
            catch (Exception ex)
            {
                MessageBox.Show("システムエラー");
            }

        }

        //この色のセルを取得
        private void get_this_color_cell_list()
        {
            var sa = excelObj.Application.Selection;
            var ash = excelObj.Application.ActiveSheet;

            string ret = "";
            string cell_val = "";
            int r1, r2, c = 0;
            int cc = 0;

            cell_val = cellValText.Text;
            if (cell_val.Equals(""))
            {
                MessageBox.Show("セル色コード欄が空です!");
                return;
            }

            cc = Int32.Parse(cellValText.Text);
            r1 = sa.Row;
            r2 = sa.Rows[sa.Rows.Count].Row;
            c = sa.Column;

            for (int i = r1; i <= r2; i++)
            {
                int cr_cc = 0;
                string cr_val = "";
                cr_cc = ash.Cells[i, c].Interior.ColorIndex;

                if (ash.Cells[i, c].Value == null) continue;

                Type t = ash.Cells[i, c].Value.GetType();
                if (t.Equals(typeof(string)))
                {
                    cr_val = (string)ash.Cells[i, c].Value;
                }
                else if(t.Equals(typeof(double)))
                {
                    double cr_val_ref = ash.Cells[i, c].Value;
                    cr_val = cr_val_ref.ToString();
                }
                if (cc == cr_cc)
                {
                    ret += cr_val + "\r\n";
                }
            }

            if(frmObj.Visible == false) frmObj.Show();
            frmObj.reportText.Text = ret;
        }

        //リストに一致するセルに色を付ける
        private void do_coloring_match_list()
        {
            string ta = "";
            string cell_val = "";
            var sa = excelObj.Application.Selection;
            var ash = excelObj.Application.ActiveSheet;
            int r1, r2, c = 0;
            int cc = 0;

            if(frmObj.Visible == false)
            {
                MessageBox.Show("フォームが開かれていません!");
                frmObj.Show();
                return;
            }

            ta = frmObj.reportText.Text;
            cell_val = cellValText.Text;

            if(cell_val.Equals(""))
            {
                MessageBox.Show("セル色コード欄が空です!");
                return;
            }

            cc = Int32.Parse(cell_val);
  
            if (ta.Equals(""))
            {
                MessageBox.Show("フォーム内のデータが空です!");
            }
            else
            {
                string[] sep = { "\r\n" };
                string[] arr = ta.Split(sep, StringSplitOptions.None);

                r1 = sa.Row;
                r2 = sa.Rows[sa.Rows.Count].Row;
                c = sa.Column;

                for (int i = 0; i < arr.Length; i++)
                {
                    string line = arr[i].ToString();

                    for (int j = r1; j <= r2; j++)
                    {
                        if (ash.Cells[j, c].Value == null) continue;

                        Type t = ash.Cells[j, c].Value.GetType();
                        if (t.Equals(typeof(string)))
                        {
                            string cr_val = ash.Cells[j, c].Value;
                            if (cr_val.Equals(line))
                            {
                                ash.Cells[j, c].Interior.ColorIndex = cc;
                            }
                        }

                    }
                }
            }
        }

        //生成されたリストを反転
        private void do_reverse_list()
        {
            string ta = "";
            string new_ta = "";

            if(frmObj.Visible == false)
            {
                MessageBox.Show("フォームが開かれていません!");
                frmObj.Show();
                return;
            }

            ta = frmObj.reportText.Text;

            if (ta.Equals(""))
            {
                MessageBox.Show("フォーム内のデータが空です!");
            }
            else
            {
                string[] sep = { "\r\n" };
                string[] arr = ta.Split(sep, StringSplitOptions.RemoveEmptyEntries);

                int max_cnt = arr.Length;
                if (max_cnt > 1)
                {
                    for (int i = max_cnt; i != -1; i--)
                    {
                        string line = "";
                        try
                        {
                            line = arr[i].ToString();
                        }
                        catch (Exception ex)
                        {
                        }

                        new_ta += line + "\r\n";
                    }

                    frmObj.reportText.Text = new_ta.TrimStart();
                    MessageBox.Show("リストの反転が完了しました！");

                }
                else
                {
                    MessageBox.Show("リストが1項目なので反転は不要です！");
                }
            }

        }

        //判定ひな形を作成
        private void get_survey_base()
        {
            if(frmObj.Visible == false)
            {
                frmObj.Show();
            }

            string ret = "";
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

            //libra検査報告書Excelは未対応
            if(opt_type == "libra-excel")
            {
                MessageBox.Show("Libraの検査報告書Excelには、まだ対応していません");
                frmObj.Dispose();
                return;
            }

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

                ret = techID + tab_sp + sv_flag + tab_sp + sv_copy_flag + tab_sp + "who" + tab_sp;
                ret += comment + tab_sp + description + tab_sp + srccode;

            }

            frmObj.reportText.Clear();
            frmObj.reportText.Text = ret;

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
        private void get_wa_check_comment_base()
        {
            if (frmObj.Visible == false)
            {
                frmObj.Show();
            }

            string ret = "";
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

                    ret += pageID + "\r\n";
                    ret += "達成基準: " + guideline + "\r\n";
                    ret += "達成方法番号: " + techID + "\r\n";
                    ret += "判定: " + sv_flag + "\r\n";
                    ret += "判定コメント:" + "\r\n" + comment + "\r\n";
                    ret += "対象ソース:" + "\r\n" + description + "\r\n\r\n";
                    ret += "修正ソース:" + "\r\n" + srccode + "\r\n\r\n\r\n";
                }
                //libra-excel
                else if(opt_type == "libra-excel")
                {
                    string guidelineAndtechID = (string)ash.Cells[i, 6].Value;
                    string pageID = (string)ash.Cells[i, 1].Value;
                    string comment = _text_clean((string)ash.Cells[i, 4].Value);
                    string description = _br_encode((string)ash.Cells[i, 3].Value);
                    string srccode = _text_clean((string)ash.Cells[i, 5].Value);

                    ret += pageID + "\r\n";
                    ret += "達成基準/実装番号:\r\n" + guidelineAndtechID + "\r\n";
                    ret += "判定コメント:" + "\r\n" + comment + "\r\n";
                    ret += "対象ソース:" + "\r\n" + description + "\r\n\r\n";
                    ret += "修正ソース:" + "\r\n" + srccode + "\r\n\r\n\r\n";
                }

            }

            frmObj.Show();
            frmObj.reportText.Clear();
            frmObj.reportText.Text = ret;

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
        }

    }
}
