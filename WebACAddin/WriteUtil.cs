using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WebACAddin
{
    partial class Ribbon1
    {
        //PIDのグループ名を自動入力
        private void do_groupname_insert()
        {
            var sa = excelObj.Application.Selection;
            var ash = excelObj.Application.ActiveSheet;

            int r1, r2, c1, c2 = 0;
            string grp_first_code = "";

            r1 = sa.Row;
            r2 = sa.Rows[sa.Rows.Count].Row;
            c1 = sa.Column;
            c2 = c1 - 1;

            if (ash.Cells[r1, c2].Value == null) return;
            Type t = ash.Cells[r1, c2].Value.GetType();
            if (t.Equals(typeof(string)))
            {
                grp_first_code = (string)ash.Cells[r1, c2].Value;
            }
            else if (t.Equals(typeof(int)) || t.Equals(typeof(double)))
            {
                grp_first_code = ash.Cells[r1, c2].Value.ToString();
            }

            grp_first_code = "グループ" + grp_first_code;
            int[] rgbs = get_random_colode_idx();

            for (int i = r1; i <= r2; i++)
            {
                ash.Cells[i, c1].Value = grp_first_code;
                if (addLabelColorCheck.Checked == true)
                {
                    ash.Cells[i, c1].Interior.Color = Color.FromArgb(rgbs[0], rgbs[1], rgbs[2]);
                }

            }
            if (globalAlertOKNGRadio.Checked != true) MessageBox.Show("処理が完了しました!");

        }

        //ランダムな色コードを返す
        private int[] get_random_colode_idx()
        {
            List<int[]> arr = new List<int[]>();
            arr.Add(new int[3] { 204, 255, 255 });
            arr.Add(new int[3] { 255, 204, 153 });
            arr.Add(new int[3] { 204, 255, 204 });
            arr.Add(new int[3] { 255, 255, 204 });
            int counter = rnd.Next(0, 3);
            return arr[counter];
        }

        //判定を追記する
        private void do_add_survey_write()
        {
            var sa = excelObj.Application.Selection;
            var ash = excelObj.Application.ActiveSheet;

            Regex svpat = new Regex(@"^(適合|不適合|適合\(注記\)|非適用)", RegexOptions.Compiled);
            string prefix = "\r\n↓\r\n";

            int r1, r2, c1, c2 = 0;

            string src = svRedimFlagCombo.Text;

            r1 = sa.Row;
            r2 = sa.Rows[sa.Rows.Count].Row;
            c1 = sa.Column;
            c2 = sa.Columns[sa.Columns.Count].Column;

            //行ループ
            for (int i = r1; i <= r2; i++)
            {

                string buff = "";

                //列のループ
                for (int j = c1; j <= c2; j++)
                {

                    if (ash.Cells[i, j].Value == null)
                    {
                        if (svpat.IsMatch(src))
                        {
                            ash.Cells[i, j].Value = buff + prefix + src;
                        }
                        else
                        {
                            if (writeCommentBreakCheck.Checked == true)
                            {
                                ash.Cells[i, j].Value = buff + "\r\n" + src + "\r\n";
                            }
                            else
                            {
                                ash.Cells[i, j].Value = buff + src;
                            }
                        }
                    }
                    else
                    {
                        Type t = ash.Cells[i, j].Value.GetType();
                        if (t.Equals(typeof(string)))
                        {
                            buff = ash.Cells[i, j].Value;
                        }

                        if (src != null)
                        {
                            if (svpat.IsMatch(src))
                            {
                                ash.Cells[i, j].Value = buff + prefix + src;
                            }
                            else
                            {
                                if (writeCommentBreakCheck.Checked == true)
                                {
                                    ash.Cells[i, j].Value = buff + "\r\n" + src + "\r\n";
                                }
                                else
                                {
                                    ash.Cells[i, j].Value = buff + src;
                                }

                            }
                        }
                    }

                }
            }
        }

        //語句を追記する
        private void do_add_comment_write()
        {
            var sa = excelObj.Application.Selection;
            var ash = excelObj.Application.ActiveSheet;

            int r1, r2, c1, c2 = 0;

            string src = writeCommentFlagCombo.Text;

            r1 = sa.Row;
            r2 = sa.Rows[sa.Rows.Count].Row;
            c1 = sa.Column;
            c2 = sa.Columns[sa.Columns.Count].Column;

            //行ループ
            for(int i=r1; i<=r2; i++)
            {

                string buff = "";

                //列のループ
                for(int j=c1; j<=c2; j++)
                {

                    if (ash.Cells[i, j].Value == null)
                    {
                        if(writeCommentOverrideCheck.Checked == false)
                        {
                            ash.Cells[i, j].Value = src;
                        }
                        else
                        {
                            if (writeCommentBreakCheck.Checked == true)
                            {
                                ash.Cells[i, j].Value = buff + "\r\n" + src + "\r\n";
                            }
                            else
                            {
                                ash.Cells[i, j].Value = buff + src;
                            }
                        }

                    }
                    else
                    {
                        Type t = ash.Cells[i, j].Value.GetType();
                        if (t.Equals(typeof(string)))
                        {
                            buff = ash.Cells[i, j].Value;
                        }

                        if (src != null)
                        {

                            if(writeCommentOverrideCheck.Checked == false)
                            {
                                ash.Cells[i, j].Value = src;
                            }
                            else
                            {
                                if (writeCommentBreakCheck.Checked == true)
                                {
                                    ash.Cells[i, j].Value = buff + "\r\n" + src + "\r\n";
                                }
                                else
                                {
                                    ash.Cells[i, j].Value = buff + src;
                                }
                            }
                        }
                    }

                }
            }

        }

        //ドロップダウンに値を追加する
        private void do_add_comment()
        {
            var sa = excelObj.Application.Selection;
            var ash = excelObj.Application.ActiveSheet;
            Regex pat = new Regex(@"(\r\n|\r|\n)+", RegexOptions.Compiled | RegexOptions.Multiline);

            int r, c = 0;
            string buff = "";

            r = sa.Row;
            c = sa.Column;
            if (ash.Cells[r, c].Value == null)
            {
                MessageBox.Show("セルの値が空です!");
                return;
            }
            Type t = ash.Cells[r, c].Value.GetType();
            if (t.Equals(typeof(string)))
            {
                buff = ash.Cells[r, c].Value;
                if(pat.IsMatch(buff))
                {
                    buff = pat.Replace(buff, "");
                }
            }
            if(buff != "")
            {
                RibbonDropDownItem item = Factory.CreateRibbonDropDownItem();
                item.Label = buff;
                writeCommentFlagCombo.Items.Add(item);
            }
            
        }

        //印を付ける
        private void do_line_mark_write()
        {
            var sa = excelObj.Application.Selection;
            var ash = excelObj.Application.ActiveSheet;
            int r1, r2, c = 0;
            string range_text = "";

            r1 = sa.Row;
            r2 = sa.Rows[sa.Rows.Count].Row;
            c = sa.Column;

            //行のループ
            for(int i= r1; i<=r2; i++)
            {

                range_text = i.ToString() + ":" + i.ToString();
                ash.Cells[i, c].Value = "*";
                if(addLabelColorCheck.Checked == true)
                {
                    ash.Rows[range_text].Interior.Color = 65535;
                }

            }
        }

        //セル文字編集フォームを表示
        private void do_write_form()
        {
            var sa = excelObj.Application.Selection;
            var ash = excelObj.Application.ActiveSheet;
            Regex unixbr = new Regex(@"\n", RegexOptions.Compiled | RegexOptions.Multiline);

            int r, c = 0;
            string body = "";
            r = sa.Row;
            c = sa.Column;
            if (ash.Cells[r, c].Value != null)
            {
                Type t = ash.Cells[r, c].Value.GetType();
                if (t.Equals(typeof(string)))
                {
                    body = (string)ash.Cells[r, c].Value;
                }
                body = unixbr.Replace(body, "\r\n");
            }
            wrfrmObj.Show();
            wrfrmObj.writeFormText.Text = body;
        }

    }
}
