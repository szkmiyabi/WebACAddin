using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

    }
}
