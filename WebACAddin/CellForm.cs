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
    public partial class CellForm : Form
    {
        //コンストラクタ
        public CellForm()
        {
            InitializeComponent();
            TopMost = true;
            topMostCheck.Checked = true;
        }

        //Ctrl+A実装
        private void cellReportText_KeyDown(object sender, KeyEventArgs e)
        {
            //Ctrl + A
            if (e.Control && e.KeyCode == Keys.A)
            {
                e.SuppressKeyPress = true; //beep disabled
                cellReportText.SelectAll();
            }
        }

        //常に前面表示のトグル
        private void topMostCheck_Click(object sender, EventArgs e)
        {
            TopMost = !TopMost;
        }

        //カラーコード取得
        private void get_color_code()
        {
            try
            {
                colorCodeText.Text = "";
                string color_code = "";

                Excel.Range acl = Globals.ThisAddIn.Application.ActiveCell;
                color_code = acl.Interior.ColorIndex.ToString();
                colorCodeText.Text = color_code;
            }
            catch (Exception ex)
            {
                MessageBox.Show("システムエラー");
            }

        }

        //この色のセルを取得
        private void get_this_color_cell_list()
        {
            var sa = Globals.ThisAddIn.Application.Selection;
            var ash = Globals.ThisAddIn.Application.ActiveSheet;

            string ret = "";
            string cell_val = "";
            int r1, r2, c = 0;
            int cc = 0;

            cell_val = colorCodeText.Text;
            if (cell_val.Equals(""))
            {
                MessageBox.Show("セル色コード欄が空です!");
                return;
            }

            cc = Int32.Parse(colorCodeText.Text);
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
                else if (t.Equals(typeof(double)))
                {
                    double cr_val_ref = ash.Cells[i, c].Value;
                    cr_val = cr_val_ref.ToString();
                }
                if (cc == cr_cc)
                {
                    ret += cr_val + "\r\n";
                }
            }

            cellReportText.Clear();
            cellReportText.Text = ret;
        }

        //リストに一致するセルに色を付ける
        private void do_coloring_match_list()
        {
            string ta = "";
            string cell_val = "";
            var sa = Globals.ThisAddIn.Application.Selection;
            var ash = Globals.ThisAddIn.Application.ActiveSheet;
            int r1, r2, c = 0;
            int cc = 0;

            ta = cellReportText.Text;
            cell_val = colorCodeText.Text;

            if (cell_val.Equals(""))
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
                        else if (t.Equals(typeof(double)))
                        {
                            double tmp = ash.Cells[j, c].Value;
                            string cr_val = tmp.ToString();
                            if (cr_val.Equals(line))
                            {
                                ash.Cells[j, c].Interior.ColorIndex = cc;
                            }
                        }

                    }
                }
                MessageBox.Show("色付け完了しました。");
            }
        }

        //一覧を反転
        private void do_reverse_list()
        {
            string ta = "";
            string new_ta = "";

            ta = cellReportText.Text;
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

                    cellReportText.Text = new_ta.TrimStart();
                }
                else
                {
                    MessageBox.Show("リストが1項目なので反転は不要です！");
                }
            }

        }

        //カンマ区切りに切り替え
        private void do_comvert_csv()
        {
            string ta = cellReportText.Text;
            string new_ta = "";
            if (ta.Equals(""))
            {
                MessageBox.Show("フォーム内のデータが空です!");
            }
            else
            {
                string[] sep = { "\r\n" };
                string[] arr = ta.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                int cnt = 0;
                foreach(string row in arr)
                {
                    new_ta += row;
                    if(cnt < (arr.Length - 1)) new_ta += ", ";
                    cnt++;
                }
                cellReportText.Text = new_ta;

            }
        }

        //オートフィルタ抽出行を表示
        private void do_auto_filtered_rows_lookup()
        {
            Excel.Range sa = Globals.ThisAddIn.Application.Selection;

            int r1, r2 = 0;
            r1 = sa.Row;
            r2 = sa.Rows[sa.Rows.Count].Row;
            string text = "";

            for (int i = r1; i <= r2; i++)
            {
                if (sa.Cells[i, 1].EntireRow.Hidden == true) continue;
                text += i.ToString() + "\r\n";
            }
            cellReportText.Clear();
            cellReportText.Text = text;
        }

        //色値取得
        private void getColorCodeButton_Click(object sender, EventArgs e)
        {
            get_color_code();
        }

        //色に一致
        private void matchColorListupButton_Click(object sender, EventArgs e)
        {
            get_this_color_cell_list();
        }

        //一覧一致セル色付
        private void matchListColoringButton_Click(object sender, EventArgs e)
        {
            do_coloring_match_list();
        }

        //コピー
        private void copyButton_Click(object sender, EventArgs e)
        {
            string src = cellReportText.Text;
            try
            {
                Clipboard.SetDataObject(src, false);
            }
            catch(Exception ex)
            {
                MessageBox.Show("コピー失敗しました。\n" + "詳細：" + ex.Message);
            }
            MessageBox.Show("クリップボードにコピーしました。");
        }

        //クリア
        private void clearButton_Click(object sender, EventArgs e)
        {
            cellReportText.Clear();
        }

        //閉じる
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //一覧を反転
        private void listReverseButton_Click(object sender, EventArgs e)
        {
            do_reverse_list();
        }

        //フィルタ抽出行
        private void matchFilteredRowButton_Click(object sender, EventArgs e)
        {
            do_auto_filtered_rows_lookup();
        }

        //カンマ区切り
        private void csvButton_Click(object sender, EventArgs e)
        {
            do_comvert_csv();
        }
    }
}
