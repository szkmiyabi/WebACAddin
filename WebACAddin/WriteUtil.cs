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
                if (groupLabelWithColorRadio.Checked == true)
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

        //語句を追記する
        private void do_add_comment_write()
        {
            var sa = excelObj.Application.Selection;
            var ash = excelObj.Application.ActiveSheet;

            Regex svpat = new Regex(@"(適合|不適合|適合\(注記\)|非適用)", RegexOptions.Compiled);
            string prefix = "\r\n↓\r\n";

            int r, c = 0;
            string src = writeCommentFlagCombo.Text;
            string buff = "";

            r = sa.Row;
            c = sa.Column;

            if (ash.Cells[r, c].Value == null) return;
            Type t = ash.Cells[r, c].Value.GetType();
            if (t.Equals(typeof(string)))
            {
                buff = ash.Cells[r, c].Value;
            }

            if(src != null && buff != "")
            {
                if (svpat.IsMatch(src))
                {
                    ash.Cells[r, c].Value = buff + prefix + src;
                }
                else
                {
                    ash.Cells[r, c].Value = buff + "\r\n\r\n" + src + "\r\n";
                }
            }

        }

        //印を付ける
        private void do_line_mark_write()
        {
            var sa = excelObj.Application.Selection;
            var ash = excelObj.Application.ActiveSheet;

            int r, c = 0;
            r = sa.Row;
            c = sa.Column;
            ash.Cells[r, c].Value = "*";

        }

    }
}
