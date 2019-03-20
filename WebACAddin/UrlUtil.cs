using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;


namespace WebACAddin
{
    partial class Ribbon1
    {

        //選択範囲のURLのセルにハイパーリンク設定
        private void do_href_add_wrapper()
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
                do_href_add();
            }
        }
        private void do_href_add()
        {
            var sa = excelObj.Application.Selection;
            var ash = excelObj.Application.ActiveSheet;

            int x, y, yn;
            y = sa.Row;
            yn = sa.Rows[sa.Rows.Count].Row;
            x = sa.Column;

            for (int i = y; i <= yn; i++)
            {
                var href = ash.Hyperlinks;
                href.Add(ash.Cells[i, x], ash.Cells[i, x].Value, Type.Missing, ash.Cells[i, x].Value, ash.Cells[i, x].Value);
            }
        }

        //選択範囲のURLのセルの隣列にページタイトル取得
        private void do_page_title_add_wrapper()
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
                do_page_title_add();
            }
            MessageBox.Show("ページタイトル取得が完了しました！");
        }
        private void do_page_title_add()
        {
            var sa = excelObj.Application.Selection;
            var ash = excelObj.Application.ActiveSheet;

            int x, xn, y, yn;
            y = sa.Row;
            yn = sa.Rows[sa.Rows.Count].Row;
            x = sa.Column;
            xn = x + 1;

            for (int i = y; i <= yn; i++)
            {
                string cr_val = "";

                Type t = ash.Cells[i, x].Value.GetType();
                if (t.Equals(typeof(string)))
                {
                    cr_val = (string)ash.Cells[i, x].Value;
                    string tt = _get_page_title(cr_val);
                    ash.Cells[i, x + 1].Value = tt;
                }
            }
            //MessageBox.Show("ページタイトル取得が完了しました！");
        }

        //ページタイトルを取得
        private string _get_page_title(string url)
        {
            string pg_title = "";

            try
            {
                WebClient wc = new WebClient();
                wc.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
                //sslエラー回避
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
                ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
                byte[] wbuf = wc.DownloadData(url);
                System.Text.Encoding enc = _get_self_encoding(wbuf);
                string html = enc.GetString(wbuf);
                html = _html_clean(html);
                pg_title = _page_title(html);
                wc.Dispose();
            }
            catch (Exception ex)
            {
                pg_title = "title取得エラー";
            }

            return pg_title;
        }



        //title要素の中身を取得
        private string _page_title(string str)
        {
            string ret = "";
            try
            {
                Regex pt = new Regex(@"(<title.*>)(.+?)(</title>)");
                MatchCollection mc = pt.Matches(str);
                if (mc.Count > 0)
                {
                    Match mt = mc[0];
                    ret = mt.Groups[2].Value;

                }
            }
            catch (Exception ex)
            {
                ret = "title取得エラー";
            }
            return ret;
        }


        //選択範囲をTSV保存
        private void do_selet_area_tsv()
        {
            string save_path = _get_tsv_save_path();

            //BOM無し設定
            System.Text.Encoding enc = new System.Text.UTF8Encoding(false);
            StreamWriter sw = new StreamWriter(save_path, false, enc);

            var sa = excelObj.Application.Selection;
            var ash = excelObj.Application.ActiveSheet;

            int y = sa.Row;
            int yn = sa.Rows[sa.Rows.Count].Row;

            for (int i = y; i <= yn; i++)
            {
                List<object> row = _get_select_area_row(i);
                string row_str = _edit_row_tsv(row);
                sw.Write(row_str);
            }

            sw.Close();
            MessageBox.Show("処理が完了しました!");

        }



    }
}
