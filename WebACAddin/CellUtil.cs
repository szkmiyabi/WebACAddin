﻿using System;
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
            try
            {
                string ret = "";

                var sa = excelObj.Application.Selection;
                var ash = excelObj.Application.ActiveSheet;

                int cc = Int32.Parse(cellValText.Text);
                int r1, r2, c = 0;

                r1 = sa.Row;
                r2 = sa.Rows[sa.Rows.Count].Row;
                c = sa.Column;

                for (int i = r1; i <= r2; i++)
                {
                    int cr_cc = 0;
                    string cr_val = "";

                    if (ash.Cells[i, c].Value == null) continue;

                    Type t = ash.Cells[i, c].Value.GetType();
                    if (t.Equals(typeof(string)))
                    {
                        cr_cc = ash.Cells[i, c].Interior.ColorIndex;
                        cr_val = (string)ash.Cells[i, c].Value;
                    }
                    if (cc == cr_cc)
                    {
                        ret += cr_val + "\r\n";
                    }
                }

                frmObj.Show();
                frmObj.reportText.Text = ret;
            }
            catch (Exception ex)
            {
                MessageBox.Show("システムエラー");
            }

        }

        //リストに一致するセルに色を付ける
        private void do_coloring_match_list()
        {
            try
            {
                string ta = frmObj.reportText.Text;
                int cc = Int32.Parse(cellValText.Text);

                var sa = excelObj.Application.Selection;
                var ash = excelObj.Application.ActiveSheet;

                int r1, r2, c = 0;

                if (!ta.Equals(""))
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
                else
                {
                    MessageBox.Show("リストのダイアログが開かれていません");
                    frmObj.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("システムエラー");
            }


        }

        //生成されたリストを反転
        private void do_reverse_list()
        {
            try
            {
                string ta = frmObj.reportText.Text;
                string new_ta = "";

                if (!ta.Equals(""))
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
                else
                {
                    MessageBox.Show("レポートフォームからリストを取得できません！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("システムエラー！");
            }

        }

        //品質チェック指摘コメントのひな形を作成
        private void get_wa_check_comment_base()
        {

            string ret = "";
            Regex mt = new Regex(@"http.*//.+");

            var sa = excelObj.Application.Selection;
            var ash = excelObj.Application.ActiveSheet;

            int r1, r2, c1, c2;

            r1 = sa.Row;
            r2 = sa.Rows[sa.Rows.Count].Row;
            c1 = sa.Column;
            c2 = sa.Columns[sa.Columns.Count].Column;

            for(int i=r1; i<=r2; i++)
            {
                int di = 0;
                string tmp = ash.Cells[i, 3].Value;
                if (mt.IsMatch(tmp)) di++;

                string guideline = ash.Cells[i, 2].Value;
                string pageID = ash.Cells[i, 1].Value;
                string techID = ash.Cells[i, 4 + di].Value;
                string sv_flag = ash.Cells[i, 5 + di].Value;
                string comment = ash.Cells[i, 7 + di].Value;
                string description = _text_clean(ash.Cells[i, 8 + di].Value);
                string srccode = _text_clean(ash.Cells[i, 9 + di].Value);

                ret += pageID + "\r\n";
                ret += "達成基準: " + guideline + "\r\n";
                ret += "達成方法番号: " + techID + "\r\n";
                ret += "判定: " + sv_flag + "\r\n";
                ret += "判定コメント:" + "\r\n" + comment + "\r\n";
                ret += "対象ソース:" + "\r\n" + description + "\r\n\r\n";
                ret += "修正ソース:" + "\r\n" + srccode + "\r\n\r\n\r\n";

                frmObj.Show();
                frmObj.reportText.Clear();
                frmObj.reportText.Text = ret;
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
            if(t.Equals(typeof(string)))
            {
                grp_first_code = (string)ash.Cells[r1, c2].Value;
            }
            else if(t.Equals(typeof(int)) || t.Equals(typeof(double)))
            {
                grp_first_code = ash.Cells[r1, c2].Value.ToString();
            }

            grp_first_code = "グループ" + grp_first_code;
            int[] rgbs = get_random_colode_idx();

            for (int i=r1; i <= r2; i++)
            {
                ash.Cells[i, c1].Value = grp_first_code;
                if(groupLabelWithColorRadio.Checked == true)
                {
                    ash.Cells[i, c1].Interior.Color = Color.FromArgb(rgbs[0], rgbs[1], rgbs[2]);
                }

            }
            if(globalAlertOKNGRadio.Checked != true) MessageBox.Show("処理が完了しました!");

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
    }
}
