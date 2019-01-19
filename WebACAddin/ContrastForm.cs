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
        private string prefix = "<!doctype html><html lang='ja'><head><meta charset='utf-8'>";
        private string header_end = "</head><body>";
        private string body = "<div id='canvas'><strong>あいうえおABCDE</strong></div>";
        private string sufix = "</body></html>";

        private Regex fgpat = new Regex(@"(前景色:)(#[0-9a-fA-F]+)", RegexOptions.Compiled);
        private Regex bgpat = new Regex(@"(背景色:)(#[0-9a-fA-F]+)", RegexOptions.Compiled);

        public ContrastForm()
        {
            InitializeComponent();
            reset_preview();
        }

        //コントラストをプレビュー
        private void disp_preview()
        {
            string src = contrastRatioText.Text;
            string css_text = "<style>";
            css_text += "#canvas {  font-family: Meiryo,sans-serif; width: calc(100% - 40px); padding: 20px; text-align:center; font-size: 24px;";
            css_text += "background-color: " + _get_background_color(src) + ";";
            css_text += "color: " + _get_foreground_color(src) + ";";
            css_text += " }</style>";
            contrastBrowser.DocumentText = prefix + css_text + header_end + body + sufix;
        }

        //コントラストのプレビューをクリア
        private void reset_preview()
        {
            string css_text = "<style>";
            css_text += "#canvas { font-family: Meiryo,sans-serif; width: calc(100% - 40px); padding: 20px; text-align:center; font-size: 24px; background-color: #FFF; color: #000; }</style>";
            contrastBrowser.DocumentText = prefix + css_text + header_end + body + sufix;
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
            str = _text_clean(str);
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
            str = _text_clean(str);
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
    }


}
