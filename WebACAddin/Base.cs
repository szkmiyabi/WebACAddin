using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Office.Tools.Ribbon;
using System.Drawing;

namespace WebACAddin
{
    partial class Ribbon1
    {

        private List<string> libraSvArr = new List<string>()
        {
            "適合",
            "不適合",
            "非適用",
            "適合(注記)"
        };
        private List<string> libraplusSvArr = new List<string>()
        {
            "はい",
            "いいえ",
            "なし",
            "はい(注記)"
        };
        private List<string> shareSvArr = new List<string>()
        {
            "未修正",
            "判断保留",
            "※追記",
            "※修正",
            "※削除"
        };

        //判定修正スニペットコンボ初期化
        private void init_svRedimFlagCombo()
        {
            svRedimFlagCombo.Items.Clear();
            List<string> lst = new List<string>();
            if(isLibraPlusOn)
            {
                lst.AddRange(libraplusSvArr);
                lst.AddRange(shareSvArr);
            }
            else
            {
                lst.AddRange(libraSvArr);
                lst.AddRange(shareSvArr);
            }

            foreach (string vl in lst)
            {
                RibbonDropDownItem item = Factory.CreateRibbonDropDownItem();
                item.Label = vl;
                svRedimFlagCombo.Items.Add(item);
            }
        }


        //TXTファイル保存先を取得
        private string _get_txt_save_path()
        {
            string path = "";
            SaveFileDialog fda = new SaveFileDialog();
            fda.Filter = "Textファイル(*.txt)|*.txt";
            fda.Title = "名前を付けて保存";
            if (fda.ShowDialog() == DialogResult.OK)
            {
                path = fda.FileName;
            }
            return path;
        }

        //TSVファイル保存先を取得
        private string _get_tsv_save_path()
        {
            string path = "";
            SaveFileDialog fda = new SaveFileDialog();
            fda.Filter = "TSVファイル(*.txt)|*.txt";
            fda.Title = "名前を付けて保存";
            if (fda.ShowDialog() == DialogResult.OK)
            {
                path = fda.FileName;
            }
            return path;
        }

        //TSV行データの生成
        private string _edit_row_tsv(List<object> row)
        {
            string row_str = "";
            for (int j = 0; j < row.Count; j++)
            {
                Type t = row[j].GetType();
                if (t.Equals(typeof(double)))
                {
                    row_str += row[j].ToString();
                    if (j < (row.Count - 1)) row_str += "\t";
                }
                else if (t.Equals(typeof(string)))
                {
                    row_str += (string)row[j];
                    if (j < (row.Count - 1)) row_str += "\t";
                }

            }
            row_str += "\r\n";
            return row_str;
        }

        //セル選択範囲のデータを取得
        private List<object> _get_select_area_row(int idx)
        {
            var ash = excelObj.Application.ActiveSheet;
            var sa = excelObj.Application.Selection;
            List<object> arr = new List<object>();
            int y = idx;
            int x = sa.Column;
            int xn = sa.Columns[sa.Columns.Count].Column;
            for (int j = x; j <= xn; j++)
            {
                if (ash.Cells[y, j].Value == null)
                {
                    arr.Add((double)0);
                    continue;
                }
                Type t = ash.Cells[y, j].Value.GetType();
                System.Diagnostics.Debug.WriteLine(t);
                var dat = ash.Cells[y, j].Value;
                if (t.Equals(typeof(double)))
                {
                    arr.Add((double)ash.Cells[y, j].Value);
                }
                else if (t.Equals(typeof(string)))
                {
                    arr.Add((string)ash.Cells[y, j].Value);
                }
                else if (t.Equals(typeof(DateTime)))
                {
                    arr.Add((DateTime)ash.Cells[y, j].Value);
                }
                else if (t.Equals(typeof(Boolean)))
                {
                    arr.Add((Boolean)ash.Cells[y, j].Value);
                }
            }
            return arr;
        }

        //HTMLファイルのインデント・改行除去
        private string _html_clean(string str)
        {
            Regex pt = new Regex(@"(^\t|^ |\r\n|\r|\n)+");
            string ret = pt.Replace(str, "");
            return ret;
        }

        //ログタイムを取得
        private string _get_logtime(string formatter)
        {
            DateTime dt = DateTime.Now;
            return dt.ToString(formatter);
        }

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


        //Excel用RGBスカラーを取得
        private int getRGB(int r, int g, int b)
        {
            Color c = Color.FromArgb(r, g, b);
            var cint = (Microsoft.Office.Interop.Excel.XlRgbColor)(c.R + 0x100 * c.G + 0x10000 * c.B);
            return (int)cint;
        }


    }
}
