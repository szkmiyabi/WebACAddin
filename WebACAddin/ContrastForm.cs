using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;

namespace WebACAddin
{
    public partial class ContrastForm : Form
    {
        private string prefix = "<!doctype html><html lang='ja'><head><meta charset='utf-8'><style>* { font-family:'メイリオ',Meiryo,sans-serif; }</style></head><body>";
        private string body = "";
        private string sufix = "</body></html>";

        private Regex svpat = new Regex(@"(.+?)(前景色:.+?)(背景色:.+?)(コントラスト比:.+?)(:1)", RegexOptions.Compiled);
        private Regex fgpat = new Regex(@"(前景色:)(#[0-9a-fA-F]+)", RegexOptions.Compiled);
        private Regex bgpat = new Regex(@"(背景色:)(#[0-9a-fA-F]+)", RegexOptions.Compiled);


        public ContrastForm()
        {
            InitializeComponent();
            reset_preview();
            TopMost = true;
            ContrastFormTopMostCheck.Checked = true;
        }

        //コントラストをプレビュー
        private void disp_preview()
        {
            body = "";
            string src = contrastRatioText.Text;
            List<string> rows = _get_sv_arr(src);
            foreach (string row in rows)
            {
                string[] tmp = row.Split('\t');
                string str = tmp[0];
                string fgc = _get_foreground_color(tmp[1]);
                string bgc = _get_background_color(tmp[2]);
                body += @"<p style=""color:" + fgc + @";background-color:" + bgc + @";padding:10px;text-align:center;"">" + str + "</p>";
            }
            contrastBrowser.DocumentText = prefix + body + sufix;
        }

        //コントラストのプレビューをクリア
        private void reset_preview()
        {
            body = @"<p style=""color:#000000;background-color:#ffffff;padding:10px;text-align:center;"">あいうえお</p>";
            contrastBrowser.DocumentText = prefix + body + sufix;
        }

        //指摘コレクションの取得
        private List<string> _get_sv_arr(string str)
        {
            List<string> arr = new List<string>();
            str = _text_clean(str);
            if (svpat.IsMatch(str))
            {
                MatchCollection mc = svpat.Matches(str);
                foreach (Match m in mc)
                {
                    string row = m.Groups[1] + "\t" + m.Groups[2] + "\t" + m.Groups[3];
                    arr.Add(row);
                }
            }
            return arr;
        }

        //アクティブセルのデータを取得
        private void load_cell_data()
        {
            Excel.Range sa = Globals.ThisAddIn.Application.ActiveCell;
            Excel.Worksheet ash = Globals.ThisAddIn.Application.ActiveSheet;

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
            contrastRatioText.Text = body;
        }

        //テキストエリアから前景色RGBコードだけ取得
        private string _get_foreground_color(string str)
        {
            string ret = "";
            if (fgpat.IsMatch(str))
            {
                MatchCollection mc = fgpat.Matches(str);
                Match m = mc[0];
                ret = m.Groups[2].Value;
            }
            return ret;
        }

        //テキストエリアから背景色RGBコードだけ取得
        private string _get_background_color(string str)
        {
            string ret = "";
            if (bgpat.IsMatch(str))
            {
                MatchCollection mc = bgpat.Matches(str);
                Match m = mc[0];
                ret = m.Groups[2].Value;
            }
            return ret;
        }

        //正規表現検索しやすくするためのテキスト前処理
        private string _text_clean(string str)
        {
            Regex pt = new Regex(@"(\r\n|\r|\n)+");
            str = pt.Replace(str, "");
            try
            {
                str = new Regex(@"<").Replace(str, "&lt;");
                str = new Regex(@">").Replace(str, "&gt;");
            }
            catch(Exception ex) { }
            return str;
        }

        //プレビューボタンをクリック
        private void contrastRatioPvButton_Click(object sender, EventArgs e)
        {
            disp_preview();
        }

        //クリアボタンをクリック
        private void contrastRatioClearButton_Click(object sender, EventArgs e)
        {
            reset_preview();
        }

        //セル値を取得ボタンをクリック
        private void loadCellDataButton_Click(object sender, EventArgs e)
        {
            load_cell_data();
        }

        //テキスト欄クリアボタンをクリック
        private void contrastRatioTextClearButton_Click(object sender, EventArgs e)
        {
            contrastRatioText.Clear();
        }

        //常に前面表示のトグル処理
        private void ContrastFormTopMostCheck_Click(object sender, EventArgs e)
        {
            TopMost = !TopMost;
        }
    }


}
