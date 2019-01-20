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
        private static Random rnd = new Random();  //乱数object
        private static BrowserForm _brfrmObj;
        private static ContrastForm _cnfrmObj;
        private static WriteForm _wrfrmObj;

        //コンストラクタ
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            excelObj = WebACAddin.Globals.ThisAddIn;
            culture = new CultureInfo("ja-JP", true);
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();

            groupLabelWithColorRadio.Checked = true;

        }

        public ThisAddIn get_excelObj()
        {
            return excelObj;
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

        //BrowserFormインスタンスの取得
        public static BrowserForm brfrmObj
        {
            get
            {
                if(_brfrmObj == null || _brfrmObj.IsDisposed)
                {
                    _brfrmObj = new BrowserForm();
                }
                return _brfrmObj;
            }
        }

        //ContrastFormインスタンスの取得
        public static ContrastForm cnfrmObj
        {
            get
            {
                if (_cnfrmObj == null || _cnfrmObj.IsDisposed)
                {
                    _cnfrmObj = new ContrastForm();
                }
                return _cnfrmObj;
            }
        }

        //WriteFormインスタンスの取得
        public static WriteForm wrfrmObj
        {
            get
            {
                if(_wrfrmObj == null || _wrfrmObj.IsDisposed)
                {
                    _wrfrmObj = new WriteForm();
                }
                return _wrfrmObj;
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

        //グループ名を挿入
        private void groupLabelAddButton_Click(object sender, RibbonControlEventArgs e)
        {
            do_groupname_insert();
        }

        //HTMLを簡易表示
        private void dispEasyHtmlDocButton_Click(object sender, RibbonControlEventArgs e)
        {
            do_disp_htmlcode();
        }

        //コントラスト比結果表示
        private void dispContrastRepFormButton_Click(object sender, RibbonControlEventArgs e)
        {
            do_disp_contrast_preview();
        }

        //この語句を追記する
        private void surveyChangeInputButton_Click(object sender, RibbonControlEventArgs e)
        {
            do_add_comment_write();
        }

        //印を付ける
        private void markerInputButton_Click(object sender, RibbonControlEventArgs e)
        {
            do_line_mark_write();
        }

        //セル文字編集フォームを表示
        private void writeFormOpenButton_Click(object sender, RibbonControlEventArgs e)
        {
            do_write_form();
        }
    }
}
