using Microsoft.Office.Tools.Ribbon;
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
using System.Threading;

namespace WebACAddin
{
    partial class Ribbon1
    {
        //通番号
        private double autoNumberCnt = 0;

        private string horizon_sp = "<cell:tab>";
        private string vertical_sp = "<cell:br>";


        //win改行に変換
        private string _encode_return(string str)
        {
            string ret = str;
            Regex reg = new Regex(@"\n", RegexOptions.Multiline | RegexOptions.Compiled);
            try
            {
                ret = reg.Replace(ret, "\r\n");
            }
            catch (Exception ex) { }
            return ret;
        }

        //unix改行に変換
        private string _decode_return(string str)
        {
            string ret = str;
            Regex reg = new Regex(@"\r+\n+", RegexOptions.Multiline | RegexOptions.Compiled);
            try
            {
                ret = reg.Replace(ret, "\n");
            }
            catch (Exception ex) { }
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

        //乱数を発生させる
        private void do_random_nums()
        {
            var sa = excelObj.Application.Selection;
            var ash = excelObj.Application.ActiveSheet;
            int r1, r2, c1, c2 = 0;

            string src = svRedimFlagCombo.Text;

            r1 = sa.Row;
            r2 = sa.Rows[sa.Rows.Count].Row;
            c1 = sa.Column;
            c2 = sa.Columns[sa.Columns.Count].Column;

            //行ループ
            for (int i = r1; i <= r2; i++)
            {
                //列のループ
                for (int j = c1; j <= c2; j++)
                {
                    Random rnd_bs = new Random(seed++);
                    ash.Cells[i, j].Value = rnd.Next(1, 50000);
                }
            }
        }


        //判定を追記する
        private void do_add_survey_write_wrapper()
        {
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
                do_add_survey_write();
            }
        }
        private void do_add_survey_write()
        {
            var sa = excelObj.Application.Selection;
            var ash = excelObj.Application.ActiveSheet;

            Regex svpat = new Regex(@"^(はい|いいえ|はい\(注記\)|なし|適合|不適合|適合\(注記\)|非適用|未修正)", RegexOptions.Compiled);
            string prefix = "\n↓\n";

            Boolean resv_flg = writeCommentReSurveyCheck.Checked;

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
                            if(resv_flg == true)
                            {
                                ash.Cells[i, j].Value = src;
                            }
                            else
                            {
                                ash.Cells[i, j].Value = buff + prefix + src;

                            }
                        }
                        else
                        {
                            if (writeCommentBreakCheck.Checked == true)
                            {
                                ash.Cells[i, j].Value = buff + "\n" + src + "\n";
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
                                if (resv_flg == true)
                                {
                                    ash.Cells[i, j].Value = src;
                                }
                                else
                                {
                                    ash.Cells[i, j].Value = buff + prefix + src;

                                }
                            }
                            else
                            {
                                if (writeCommentBreakCheck.Checked == true)
                                {
                                    ash.Cells[i, j].Value = buff + "\n" + src + "\n";
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
            Excel.Range sa = Globals.ThisAddIn.Application.Selection;
            Excel.Worksheet ash = Globals.ThisAddIn.Application.ActiveSheet;
            string src = writeCommentCombo.Text;
            string operation = "";
            if (_contains_cell_tag_horizon(src) && gridPasteCheck.Checked) operation = "hr";
            else if (_contains_cell_tag_vertical(src) && gridPasteCheck.Checked) operation = "vr";
            else operation = "normal";

            switch (operation)
            {
                case "hr":
                    _insert_snippet_hr(sa, ash, src);
                    break;
                case "vr":
                    _insert_snippet_vr(sa, ash, src);
                    break;
                case "normal":
                    _insert_snippet_normal_wrapper();
                    break;
            }

        }
        private void _insert_snippet_normal_wrapper()
        {
            Excel.Range sa = Globals.ThisAddIn.Application.ActiveCell;
            Excel.Worksheet ash = Globals.ThisAddIn.Application.ActiveSheet;
            Excel.Areas areas = Globals.ThisAddIn.Application.Selection.Areas;

            List<string> selectionList = new List<string>();
            foreach(Excel.Range item in areas)
            {
                selectionList.Add(item.Address);
            }
            ash.Range[selectionList[0]].Select();
            for(int i=0; i<selectionList.Count; i++)
            {
                ash.Range[selectionList[i]].Select();
                _insert_snippet_normal();
            }
        }
        private void _insert_snippet_normal()
        {
            var sa = excelObj.Application.Selection;
            var ash = excelObj.Application.ActiveSheet;

            int r1, r2, c1, c2 = 0;

            string src = writeCommentCombo.Text;
            src = src.Replace(br_sp, "\n");

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
                                if (writeCommentInsertPositionCheck.Checked == true)
                                {
                                    ash.Cells[i, j].Value = src + "\n" + buff + "\n";

                                }
                                else
                                {
                                    ash.Cells[i, j].Value = buff + "\n" + src + "\n";
                                }
                            }
                            else
                            {
                                if (writeCommentInsertPositionCheck.Checked == true)
                                {
                                    ash.Cells[i, j].Value = src + buff;

                                }
                                else
                                {
                                    ash.Cells[i, j].Value = buff + src;
                                }
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
                                    if (writeCommentInsertPositionCheck.Checked == true)
                                    {
                                        ash.Cells[i, j].Value =  src + "\n" + buff + "\n";

                                    }
                                    else
                                    {
                                        ash.Cells[i, j].Value = buff + "\n" + src + "\n";
                                    }
                                }
                                else
                                {
                                    if (writeCommentInsertPositionCheck.Checked == true)
                                    {
                                        ash.Cells[i, j].Value = src + buff;

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

        }
        private void _insert_snippet_hr(Excel.Range sa, Excel.Worksheet ash, string src)
        {
            int r, c = 0;
            r = sa.Row;
            c = sa.Column;
            string[] cols = Regex.Split(src, horizon_sp);
            int cn = cols.Length;
            int counter = 0;
            int cx = c + cn;
            for (int j = c; j < cx; j++)
            {
                string aval = cols[counter].Replace(br_sp, "\n");
                if (writeCommentOverrideCheck.Checked)
                {
                    try
                    {
                        var old = ash.Cells[r, j].Value;
                        ash.Cells[r, j].Value = old + aval;
                        counter++;
                        continue;
                    }
                    catch (Exception ex) { }
                }
                ash.Cells[r, j].Value = aval;
                counter++;
            }

        }
        private void _insert_snippet_vr(Excel.Range sa, Excel.Worksheet ash, string src)
        {
            int r, c = 0;
            r = sa.Row;
            c = sa.Column;
            string[] rows = Regex.Split(src, vertical_sp);
            int rn = rows.Length;
            int counter = 0;
            int rx = r + rn;
            for (int i = r; i < rx; i++)
            {
                string aval = rows[counter].Replace(br_sp, "\n");
                if (writeCommentOverrideCheck.Checked)
                {
                    try
                    {
                        var old = ash.Cells[i, c].Value;
                        ash.Cells[i, c].Value = old + aval;
                        counter++;
                        continue;
                    }
                    catch (Exception ex) { }
                }
                ash.Cells[i, c].Value = aval;
                counter++;
            }

        }
        private Boolean _contains_cell_tag_horizon(string str)
        {
            Regex pt = new Regex(horizon_sp, RegexOptions.Compiled);
            if (pt.IsMatch(str)) return true;
            else return false;
        }
        private Boolean _contains_cell_tag_vertical(string str)
        {
            Regex pt = new Regex(vertical_sp, RegexOptions.Compiled);
            if (pt.IsMatch(str)) return true;
            else return false;
        }

        //ドロップダウンに値を追加する
        private void do_add_comment()
        {
            var sa = excelObj.Application.Selection;
            var ash = excelObj.Application.ActiveSheet;
            Regex pat = new Regex(@"\n", RegexOptions.Compiled | RegexOptions.Multiline);

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
                    buff = pat.Replace(buff, br_sp);
                }
            }
            if(buff != "")
            {
                //check onなら全クリア
                if (addCommentPreClearCheck.Checked == true) do_clear_combo_comment_all();

                RibbonDropDownItem item = Factory.CreateRibbonDropDownItem();
                item.Label = buff;
                writeCommentCombo.Items.Add(item);
            }
            MessageBox.Show("値の追加に成功しました");

        }

        //テキストファイルからドロップダウンに値を追加する
        private void do_add_comment_from_file()
        {
            string filename = "";
            string body = "";
            List<string> arr = new List<string>();

            //check onなら全クリア
            if (addCommentPreClearCheck.Checked == true) do_clear_combo_comment_all();

            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "テキストファイル(*.txt)|*.txt";
            if (f.ShowDialog() == DialogResult.OK)
            {
                filename = f.FileName;
            }
            if (filename == "") return;
            StreamReader sr = new StreamReader(filename, System.Text.Encoding.GetEncoding("shift_jis"));
            while (sr.Peek() > -1)
            {
                string line = sr.ReadLine();
                arr.Add(line);
            }
            sr.Close();

            for (int i = 0; i < arr.Count; i++)
            {
                RibbonDropDownItem item = Factory.CreateRibbonDropDownItem();
                item.Label = arr[i].ToString();
                writeCommentCombo.Items.Add(item);
            }
            MessageBox.Show("値の追加に成功しました");

        }

        //ドロップダウン選択項目削除
        private void do_clear_combo_comment_single()
        {
            int idx = 0;
            string cr = writeCommentCombo.Text;

            for (int i = 0; i < writeCommentCombo.Items.Count; i++)
            {
                RibbonDropDownItem opt = writeCommentCombo.Items[i];
                if (opt.Label.Equals(cr))
                {
                    writeCommentCombo.Items.RemoveAt(idx);
                    writeCommentCombo.Text = "";
                    break;
                }
                idx++;
            }
        }

        //ドロップダウン項目全削除
        private void do_clear_combo_comment_all()
        {
            writeCommentCombo.Items.Clear();
            writeCommentCombo.Text = "";
        }

        //ドロップダウンの値を保存
        private void do_save_val_comment()
        {
            int cnt = writeCommentCombo.Items.Count;
            string body = "";
            for (int i = 0; i < cnt; i++)
            {
                string val = writeCommentCombo.Items[i].Label;
                body += val;
                if (i != (cnt - 1)) body += "\r\n";
            }
            string path = _get_txt_save_path();
            Encoding enc = Encoding.GetEncoding("Shift_JIS");
            StreamWriter sw = new StreamWriter(path, false, enc);
            sw.WriteLine(body);
            sw.Close();
            MessageBox.Show("保存できました!");
        }

        //印を付ける
        private void do_line_mark_write_wrapper()
        {
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
                do_line_mark_write();
            }
        }
        private void do_line_mark_write()
        {
            var sa = excelObj.Application.Selection;
            var ash = excelObj.Application.ActiveSheet;
            int r1, r2, c = 0;
            string range_text = "";
            string marker_str = "";

            marker_str = markerDropdown.Text;
            if (marker_str == "" || marker_str == null) marker_str = "*";

            r1 = sa.Row;
            r2 = sa.Rows[sa.Rows.Count].Row;
            c = sa.Column;

            //行のループ
            for(int i= r1; i<=r2; i++)
            {

                range_text = i.ToString() + ":" + i.ToString();
                ash.Cells[i, c].Value = marker_str;
                if(addLabelColorCheck.Checked == true)
                {
                    if(addColorRowCheck.Checked == true)
                    {
                        ash.Rows[range_text].Interior.Color = 65535;
                    }
                    else
                    {
                        sa.Interior.Color = 65535;
                    }
                }

            }
        }

        //セル文字編集フォームを表示
        private void do_write_form()
        {
            var sa = excelObj.Application.Selection;
            var ash = excelObj.Application.ActiveSheet;

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
                body = _encode_return(body);
            }
            wrfrmObj.Show();
            wrfrmObj.writeFormText.Text = body;
            wrfrmObj.WindowState = FormWindowState.Normal;
            wrfrmObj.Activate();
        }

        //色付け決め打ち
        private void do_static_cell_coloring_wrapper(string operation)
        {
            Excel.Range sa = Globals.ThisAddIn.Application.ActiveCell;
            Excel.Worksheet ash = Globals.ThisAddIn.Application.ActiveSheet;
            Excel.Areas areas = Globals.ThisAddIn.Application.Selection.Areas;
            List<int[]> arr = _get_color_rgb_list();
            int[] cr_row = null;
            switch (operation)
            {
                case "blue":
                    cr_row = arr[0];
                    break;
                case "green":
                    cr_row = arr[1];
                    break;
                case "pink":
                    cr_row = arr[2];
                    break;
                case "purple":
                    cr_row = arr[3];
                    break;
                case "yellow":
                    cr_row = arr[4];
                    break;
                case "red":
                    cr_row = arr[5];
                    break;
            }
            List<string> selectionList = new List<string>();
            foreach (Excel.Range item in areas)
            {
                selectionList.Add(item.Address);
            }
            ash.Range[selectionList[0]].Select();
            for (int i = 0; i < selectionList.Count; i++)
            {
                ash.Range[selectionList[i]].Select();
                do_static_cell_coloring(cr_row);
            }
        }
        private void do_static_cell_coloring(int[] color_arr)
        {
            var sa = excelObj.Application.Selection;
            var ash = excelObj.Application.ActiveSheet;
            int r1, r2 = 0;
            r1 = sa.Row;
            r2 = sa.Rows[sa.Rows.Count].Row;

            for(int i=r1; i<=r2; i++)
            {
                if(addColorRowCheck.Checked == true)
                {
                    string range_text = i.ToString() + ":" + i.ToString();
                    ash.Rows[range_text].Interior.Color = Color.FromArgb(color_arr[0], color_arr[1], color_arr[2]);
                }
                else
                {
                    sa.Interior.Color = Color.FromArgb(color_arr[0], color_arr[1], color_arr[2]);
                }
            }
        }
        private List<int[]> _get_color_rgb_list()
        {
            List<int[]> arr = new List<int[]>();
            arr.Add(new int[3] { 137, 255, 255 });   //水色
            arr.Add(new int[3] { 153, 255, 153 });  //緑色
            arr.Add(new int[3] { 255, 179, 179 }); //桃色
            arr.Add(new int[3] { 212, 197, 255 }); //紫色
            arr.Add(new int[3] { 255, 255, 0 });   //黄色
            arr.Add(new int[3] { 255, 0, 0 });     //赤色
            return arr;
        }

        //色付け解除
        private void do_cell_coloring_empty_wrapper()
        {
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
                do_cell_coloring_empty();
            }
        }
        private void do_cell_coloring_empty()
        {
            var sa = excelObj.Application.Selection;
            var ash = excelObj.Application.ActiveSheet;
            int r1, r2 = 0;
            r1 = sa.Row;
            r2 = sa.Rows[sa.Rows.Count].Row;
            for(int i=r1; i<=r2; i++)
            {
                if(addColorRowCheck.Checked == true)
                {
                    string range_text = i.ToString() + ":" + i.ToString();
                    ash.Rows[range_text].Interior.ColorIndex = 0;
                }
                else
                {
                    sa.Interior.ColorIndex = 0;
                }
            }
        }

        //太字
        private void do_cell_bold_wrapper()
        {
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
                do_cell_bold();
            }
        }
        private void do_cell_bold()
        {
            Excel.Range sa = excelObj.Application.Selection;
            if (sa.Font.Bold == true) sa.Font.Bold = false;
            else sa.Font.Bold = true;
        }

        //赤字
        private void do_cell_red_wrapper()
        {
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
                do_cell_red();
            }
        }
        private void do_cell_red()
        {
            Excel.Range sa = excelObj.Application.Selection;
            if (sa.Font.ColorIndex == 3) sa.Font.ColorIndex = 1;
            else sa.Font.ColorIndex = 3;
        }

        //縦中
        private void do_cell_vertical_align_toggle_wrapper()
        {
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
                do_cell_vertical_align_toggle();
            }
        }
        private void do_cell_vertical_align_toggle()
        {
            Excel.Range sa = excelObj.Application.Selection;
            // -4108 == Excel.Constants.xlCenter
            if (sa.VerticalAlignment == -4108 || sa.VerticalAlignment == -4107) sa.VerticalAlignment = Excel.Constants.xlTop;
            else sa.VerticalAlignment = Excel.Constants.xlCenter;
        }

        //折り返し
        private void do_cell_linebreak_wrapper()
        {
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
                do_cell_linebreak();
            }
        }
        private void do_cell_linebreak()
        {
            Excel.Range sa = excelObj.Application.Selection;
            if (sa.WrapText) sa.WrapText = false;
            else sa.WrapText = true;
        }

        //通番号付与
        private void do_insert_auto_number_wrapper()
        {
            autoNumberCnt = 0;

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
                do_insert_auto_number();
            }
        }
        private void do_insert_auto_number()
        {
            var sa = excelObj.Application.Selection;
            var ash = excelObj.Application.ActiveSheet;
            double r1, r2, c;
            r1 = sa.Row;
            r2 = sa.Rows[sa.Rows.Count].Row;
            c = sa.Column;
            if(ash.Cells[r1, c].Value == null)
            {
                if(autoNumberCnt == 0) autoNumberCnt = 1;
            }
            else
            {
                Type t = ash.Cells[r1, c].Value.GetType();
                if (t.Equals(typeof(double)))
                {
                    autoNumberCnt = ash.Cells[r1, c].Value;
                }
            }
            for(double i=r1; i<=r2; i++)
            {
                ash.Cells[i, c].Value = autoNumberCnt;
                autoNumberCnt++;
            }
        }

        //セル内文字削除
        private void do_cell_clear_wrapper()
        {
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
                do_cell_clear();
            }
        }
        private void do_cell_clear()
        {
            var sa = excelObj.Application.Selection;
            var ash = excelObj.Application.ActiveSheet;
            int r1, r2, c1, c2 = 0;

            r1 = sa.Row;
            r2 = sa.Rows[sa.Rows.Count].Row;
            c1 = sa.Column;
            c2 = sa.Columns[sa.Columns.Count].Column;

            //ループ処理
            for (int i = r1; i <= r2; i++)
            {
                for(int j=c1; j <= c2; j++)
                {
                    try
                    {
                        ash.Cells[i, j].Value = "";
                    }
                    catch (Exception ex) { }
                }

            }
        }

        //選択範囲単位をオートフィル
        private void do_selected_auto_fill()
        {
            var sa = excelObj.Application.Selection;
            var ash = excelObj.Application.ActiveSheet;
            int r1, r2, c = 0;

            r1 = sa.Row;
            r2 = sa.Rows[sa.Rows.Count].Row;
            c = sa.Column;

            if (ash.Cells[r1, c].FormulaR1C1 == null) return;
            var buff = ash.Cells[r1, c].FormulaR1C1;

            //ループ処理
            for(int i=r1+1; i<=r2; i++)
            {
                ash.Cells[i, c].FormulaR1C1 = buff;
            }

        }

        //オートフィルタ抽出行をシートに書き出す
        private void do_auto_filtered_query(IProgress<int> p, CancellationToken token)
        {
            List<List<string>> data = _get_auto_filtered_rows();
            var awb = excelObj.Application.ActiveWorkbook;
            var aws = awb.Worksheets;
            int cnt = data.Count;

            Excel.Worksheet ws = aws.Add(After: aws[aws.Count]);
            ws.Name = "抽出_" + _get_logtime("yyyyMMdd_HHmmss");

            for(int i=0; i<data.Count; i++)
            {

                List<string> row = data[i];
                for(int j=0; j<row.Count; j++)
                {
                    Excel.Range cell = ws.Cells[i + 1, j + 1];
                    cell.Value = row[j];
                    cell.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    cell.VerticalAlignment = Excel.XlVAlign.xlVAlignTop;
                    cell.WrapText = false;
                }
                if (token.IsCancellationRequested)
                {
                    MessageBox.Show("処理をキャンセルしました。");
                    return;
                }
                float step = (float)(i+1) / cnt;
                step *= 100;
                int percent = (int)Math.Floor(step);
                p.Report(percent);
            }
            MessageBox.Show("オートフィルターの抽出行を新しいシートに書き出しました。");

        }
        private List<List<string>> _get_auto_filtered_rows()
        {
            var ash = excelObj.Application.ActiveSheet;

            //データ入力範囲の処理
            Excel.Range vrange = ash.Range["A1"].End[Excel.XlDirection.xlDown];
            Excel.Range hrange = ash.Range["A1"].End[Excel.XlDirection.xlToRight];

            int nr, nc = 0;
            nr = vrange.Rows[vrange.Rows.Count].Row;
            nc = hrange.Columns[hrange.Columns.Count].Column;

            //データ入力範囲を自動選択
            Excel.Range sa = ash.Range[ash.Cells[1, 1], ash.Cells[nr, nc]];
            sa.Select();

            int r1, r2, c1, c2 = 0;
            r1 = sa.Row;
            r2 = sa.Rows[sa.Rows.Count].Row;
            c1 = sa.Column;
            c2 = sa.Columns[sa.Columns.Count].Column;

            List<List<string>> data = new List<List<string>>();

            for(int i=r1; i<=r2; i++)
            {
                if (sa.Cells[i, 1].EntireRow.Hidden == true) continue;
                List<string> row_data = new List<string>();
                
                for (int j = c1; j <= c2; j++)
                {
                    Excel.Range cell = sa.Cells[i, j];
                    if(cell.Value == null)
                    {
                        row_data.Add("");
                    }
                    else
                    {
                        Type t = cell.Value.GetType();
                        if(t.Equals(typeof(string)))
                        {
                            row_data.Add((string)cell.Value);
                        }
                        else if(t.Equals(typeof(DateTime)))
                        {
                            row_data.Add(cell.Value.ToString("yyyy/MM/dd"));
                        }
                        else
                        {
                            row_data.Add(cell.Value.ToString());
                        }
                    }
                }
                data.Add(row_data);
            }

            ash.Range["A1"].Select();

            return data;

        }

        //カレント列のデータ入力範囲行をアクティブセルを起点に全て選択
        private void select_this_column_range()
        {
            var ash = excelObj.Application.ActiveSheet;
            var sa = excelObj.Application.Selection;
            Excel.Range vrange = ash.Range["A1"].End[Excel.XlDirection.xlDown];
            int nr = vrange.Rows[vrange.Rows.Count].Row;
            int cr = sa.Row;
            int cc = sa.Column;
            Excel.Range asa = ash.Range[ash.Cells[cr, cc], ash.Cells[nr, cc]];
            asa.Select();
        }

        //升目に罫線を引く
        private void do_border_matrix()
        {
            Excel.Range sa = Globals.ThisAddIn.Application.Selection;
            sa.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
        }

        //罫線を無地にする
        private void do_border_clear()
        {
            Excel.Range sa = Globals.ThisAddIn.Application.Selection;
            sa.Borders.LineStyle = Excel.XlLineStyle.xlLineStyleNone;
        }

        //再検査モードの自動チェック
        private void init_reserv_check_option()
        {
            writeCommentInsertPositionCheck.Checked = !writeCommentInsertPositionCheck.Checked;
            addColorRowCheck.Checked = !addColorRowCheck.Checked;
        }

        //初期スニペットの設定
        private void init_writeCommentCombo()
        {
            List<string> data = new List<string>();
            DateTime ymd = DateTime.Now;
            string md = ymd.ToString("M/d");
            data.Add("同上");
            data.Add("見落としがあります");
            data.Add("過剰指摘です");
            data.Add(md + " 修正を確認" + br_sp + br_sp);
            data.Add(md + " 未修正" + br_sp + br_sp);
            data.Add(md + " 新たな問題が発生しています。" + br_sp + br_sp);
            data.Add(md + " 問題が残っています" + br_sp + br_sp);
            data.Add(md + " 適合に差し換え" + br_sp + br_sp);
            data.Add(md + " 適合(注記)に差し換え" + br_sp + br_sp);
            data.Add(md + " 非適用に差し換え" + br_sp + br_sp);
            data.Add(md + " 承知しました。" + br_sp + br_sp);
            foreach(string vl in data)
            {
                RibbonDropDownItem item = Factory.CreateRibbonDropDownItem();
                item.Label = vl;
                writeCommentCombo.Items.Add(item);
            }

        }

        //オートフィルタの文字列絞り込み自動設定
        private void set_mytext_auto_filter()
        {
            try
            {
                Excel.Range acl = Globals.ThisAddIn.Application.ActiveCell;
                Excel.Worksheet ash = Globals.ThisAddIn.Application.ActiveSheet;
                int cx = acl.Column;
                Excel.Range ur = ash.UsedRange;
                string src = criteriaStringText.Text;
                if (src == "") return;
                if (criteriaFazzyCheck.Checked) src = "*" + src + "*";
                ur.AutoFilter(cx, src, Excel.XlAutoFilterOperator.xlFilterValues);
            }
            catch(Exception ex) { }
        }

        //表全体自動選択
        private void auto_select_used_range()
        {
            try
            {
                Excel.Worksheet ash = Globals.ThisAddIn.Application.ActiveSheet;
                ash.UsedRange.Select();
            }
            catch(Exception ex) { }
        }

        //近接セルから値を取得
        private void near_cell_copy_wrapper(string vector)
        {
            try
            {
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
                    near_cell_copy(vector);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("エラー：" + ex.Message);
            }

        }

        private void near_cell_copy(string vector)
        {
            var sa = excelObj.Application.Selection;
            var ash = excelObj.Application.ActiveSheet;

            int r = sa.Row;
            int rx = sa.Rows[sa.Rows.Count].Row;
            int c = sa.Column;

            for(int i=r; i<=rx; i++)
            {
                Excel.Range src_cl = null;
                switch(vector)
                {
                    case "left":
                        int cx = c;
                        do
                        {
                            cx--;

                        } while (ash.Columns[cx].EntireColumn.Hidden == true);
                        src_cl = ash.Cells[i, cx];
                        break;
                }
                Type t = src_cl.Value.GetType();
                if(t.Equals(typeof(string)))
                {
                    ash.Cells[i, c].Value = (string)src_cl.Value;
                }
            }


        }

    }
}
