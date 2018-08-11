using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


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

        //選択範囲のURLのセルにハイパーリンク設定
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
            }
            catch(Exception ex)
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

        //HTMLファイルのインデント・改行除去
        private string _html_clean(string str)
        {
            Regex pt = new Regex(@"(^\t|^ |\r\n|\r|\n)+");
            string ret = pt.Replace(str, "");
            return ret;
        }

        //
        //文字コードを判別する
        private System.Text.Encoding _get_self_encoding(byte[] bytes)
        {
            const byte bEscape = 0x1B;
            const byte bAt = 0x40;
            const byte bDollar = 0x24;
            const byte bAnd = 0x26;
            const byte bOpen = 0x28;    //'('
            const byte bB = 0x42;
            const byte bD = 0x44;
            const byte bJ = 0x4A;
            const byte bI = 0x49;

            int len = bytes.Length;
            byte b1, b2, b3, b4;

            //Encode::is_utf8 は無視

            bool isBinary = false;
            for (int i = 0; i < len; i++)
            {
                b1 = bytes[i];
                if (b1 <= 0x06 || b1 == 0x7F || b1 == 0xFF)
                {
                    //'binary'
                    isBinary = true;
                    if (b1 == 0x00 && i < len - 1 && bytes[i + 1] <= 0x7F)
                    {
                        //smells like raw unicode
                        return System.Text.Encoding.Unicode;
                    }
                }
            }
            if (isBinary)
            {
                return null;
            }

            //not Japanese
            bool notJapanese = true;
            for (int i = 0; i < len; i++)
            {
                b1 = bytes[i];
                if (b1 == bEscape || 0x80 <= b1)
                {
                    notJapanese = false;
                    break;
                }
            }
            if (notJapanese)
            {
                return System.Text.Encoding.ASCII;
            }

            for (int i = 0; i < len - 2; i++)
            {
                b1 = bytes[i];
                b2 = bytes[i + 1];
                b3 = bytes[i + 2];

                if (b1 == bEscape)
                {
                    if (b2 == bDollar && b3 == bAt)
                    {
                        //JIS_0208 1978
                        //JIS
                        return System.Text.Encoding.GetEncoding(50220);
                    }
                    else if (b2 == bDollar && b3 == bB)
                    {
                        //JIS_0208 1983
                        //JIS
                        return System.Text.Encoding.GetEncoding(50220);
                    }
                    else if (b2 == bOpen && (b3 == bB || b3 == bJ))
                    {
                        //JIS_ASC
                        //JIS
                        return System.Text.Encoding.GetEncoding(50220);
                    }
                    else if (b2 == bOpen && b3 == bI)
                    {
                        //JIS_KANA
                        //JIS
                        return System.Text.Encoding.GetEncoding(50220);
                    }
                    if (i < len - 3)
                    {
                        b4 = bytes[i + 3];
                        if (b2 == bDollar && b3 == bOpen && b4 == bD)
                        {
                            //JIS_0212
                            //JIS
                            return System.Text.Encoding.GetEncoding(50220);
                        }
                        if (i < len - 5 &&
                            b2 == bAnd && b3 == bAt && b4 == bEscape &&
                            bytes[i + 4] == bDollar && bytes[i + 5] == bB)
                        {
                            //JIS_0208 1990
                            //JIS
                            return System.Text.Encoding.GetEncoding(50220);
                        }
                    }
                }
            }

            //should be euc|sjis|utf8
            //use of (?:) by Hiroki Ohzaki <ohzaki@iod.ricoh.co.jp>
            int sjis = 0;
            int euc = 0;
            int utf8 = 0;
            for (int i = 0; i < len - 1; i++)
            {
                b1 = bytes[i];
                b2 = bytes[i + 1];
                if (((0x81 <= b1 && b1 <= 0x9F) || (0xE0 <= b1 && b1 <= 0xFC)) &&
                    ((0x40 <= b2 && b2 <= 0x7E) || (0x80 <= b2 && b2 <= 0xFC)))
                {
                    //SJIS_C
                    sjis += 2;
                    i++;
                }
            }
            for (int i = 0; i < len - 1; i++)
            {
                b1 = bytes[i];
                b2 = bytes[i + 1];
                if (((0xA1 <= b1 && b1 <= 0xFE) && (0xA1 <= b2 && b2 <= 0xFE)) ||
                    (b1 == 0x8E && (0xA1 <= b2 && b2 <= 0xDF)))
                {
                    //EUC_C
                    //EUC_KANA
                    euc += 2;
                    i++;
                }
                else if (i < len - 2)
                {
                    b3 = bytes[i + 2];
                    if (b1 == 0x8F && (0xA1 <= b2 && b2 <= 0xFE) &&
                        (0xA1 <= b3 && b3 <= 0xFE))
                    {
                        //EUC_0212
                        euc += 3;
                        i += 2;
                    }
                }
            }
            for (int i = 0; i < len - 1; i++)
            {
                b1 = bytes[i];
                b2 = bytes[i + 1];
                if ((0xC0 <= b1 && b1 <= 0xDF) && (0x80 <= b2 && b2 <= 0xBF))
                {
                    //UTF8
                    utf8 += 2;
                    i++;
                }
                else if (i < len - 2)
                {
                    b3 = bytes[i + 2];
                    if ((0xE0 <= b1 && b1 <= 0xEF) && (0x80 <= b2 && b2 <= 0xBF) &&
                        (0x80 <= b3 && b3 <= 0xBF))
                    {
                        //UTF8
                        utf8 += 3;
                        i += 2;
                    }
                }
            }
            //M. Takahashi's suggestion
            //utf8 += utf8 / 2;

            System.Diagnostics.Debug.WriteLine(
                string.Format("sjis = {0}, euc = {1}, utf8 = {2}", sjis, euc, utf8));
            if (euc > sjis && euc > utf8)
            {
                //EUC
                return System.Text.Encoding.GetEncoding(51932);
            }
            else if (sjis > euc && sjis > utf8)
            {
                //SJIS
                return System.Text.Encoding.GetEncoding(932);
            }
            else if (utf8 > euc && utf8 > sjis)
            {
                //UTF8
                return System.Text.Encoding.UTF8;
            }

            return null;
        }

    }
}
