using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using System.Globalization;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Security;

namespace WebACAddin
{
    public partial class Ribbon1
    {
        private ThisAddIn excelObj;
        private CultureInfo culture;
        private static Form1 _frmObj;


        //コンストラクタ
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            excelObj = WebACAddin.Globals.ThisAddIn;
            culture = new CultureInfo("ja-JP", true);
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
        }

        //Form1インスタンスの取得
        public static Form1 frmObj
        {
            get
            {
                if(_frmObj == null || _frmObj.IsDisposed)
                {
                    _frmObj = new Form1();
                }
                return _frmObj;
            }
        }

        //色コードを取得
        private void cellColorCodeBtn_Click(object sender, RibbonControlEventArgs e)
        {
            get_color_code();
        }

        //この色のセルをリスト表示
        private void thisColorCodeBtn_Click(object sender, RibbonControlEventArgs e)
        {
            get_this_color_cell_list();
        }

        //このリストに一致するセルに色を付ける
        private void thisListMatchBtn_Click(object sender, RibbonControlEventArgs e)
        {
            do_coloring_match_list();
        }

        //ハイパーリンクを設定
        private void setHrefBtn_Click(object sender, RibbonControlEventArgs e)
        {
            do_href_add();
        }

        //ページタイトルを取得
        private void setPageTitleBtn_Click(object sender, RibbonControlEventArgs e)
        {
            do_page_title_add();
        }

        //リストを反転
        private void listReverseButton_Click(object sender, RibbonControlEventArgs e)
        {
            do_reverse_list();
        }

        //選択範囲をTSV保存
        private void saveAsTSVButton_Click(object sender, RibbonControlEventArgs e)
        {
            do_selet_area_tsv();
        }

        //品質チェックコメントを取得
        private void waCheckCommentBaseButton_Click(object sender, RibbonControlEventArgs e)
        {
            get_wa_check_comment_base();
        }
    }
}
