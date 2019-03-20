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
        private static Random rnd = new Random();  //乱数object

        //Formオブジェクト
        private static Form1 _frmObj;
        private static BrowserForm _brfrmObj;
        private static ContrastForm _cnfrmObj;
        private static WriteForm _wrfrmObj;
        private static DocForm _docfrmObj;
        private static InputForm _inpfrmObj;

        //コンストラクタ
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            excelObj = WebACAddin.Globals.ThisAddIn;
            culture = new CultureInfo("ja-JP", true);
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();

            addLabelColorCheck.Checked = true;
            //writeCommentBreakCheck.Checked = true;
            writeCommentOverrideCheck.Checked = true;
            addCommentPreClearCheck.Checked = true;

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

        //DocFormインスタンスの取得
        public static DocForm docfrmObj
        {
            get
            {
                if(_docfrmObj == null || _docfrmObj.IsDisposed)
                {
                    _docfrmObj = new DocForm();
                }
                return _docfrmObj;
            }
        }

        //InputFormインスタンスの取得
        public static InputForm inpfrmObj
        {
            get
            {
                if (_inpfrmObj == null || _inpfrmObj.IsDisposed)
                {
                    _inpfrmObj = new InputForm();
                }
                return _inpfrmObj;
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


        //判定を追記する
        private void svRedimInputButton_Click(object sender, RibbonControlEventArgs e)
        {
            do_add_survey_write_wrapper();
        }

        //この語句を追記する
        private void surveyChangeInputButton_Click(object sender, RibbonControlEventArgs e)
        {
            do_add_comment_write_wrapper();
        }

        //セルから値追加
        private void writeCommentAddButton_Click(object sender, RibbonControlEventArgs e)
        {
            do_add_comment();
        }

        //ファイルから値追加
        private void writeCommentAddFromFileButton_Click(object sender, RibbonControlEventArgs e)
        {
            do_add_comment_from_file();
        }

        //印を付ける
        private void markerInputButton_Click(object sender, RibbonControlEventArgs e)
        {
            do_line_mark_write_wrapper();
        }

        //セル文字編集フォームを表示
        private void writeFormOpenButton_Click(object sender, RibbonControlEventArgs e)
        {
            do_write_form();
        }

        //テキスト編集
        private void documentEditButton_Click(object sender, RibbonControlEventArgs e)
        {
            do_doc_form();
        }

        //項目1件削除
        private void delCommentSingleButton_Click(object sender, RibbonControlEventArgs e)
        {
            do_clear_combo_comment_single();
        }

        //項目全削除
        private void delCommentAllButton_Click(object sender, RibbonControlEventArgs e)
        {
            do_clear_combo_comment_all();
        }

        //判定ひな形生成
        private void svDataForPasteButton_Click(object sender, RibbonControlEventArgs e)
        {
            get_survey_base();
        }

        //色付け決め打ち
        private void ccBlueButton_Click(object sender, RibbonControlEventArgs e)
        {
            do_static_cell_coloring_wrapper("blue");
        }
        private void ccGreenButton_Click(object sender, RibbonControlEventArgs e)
        {
            do_static_cell_coloring_wrapper("green");
        }
        private void ccPinkButton_Click(object sender, RibbonControlEventArgs e)
        {
            do_static_cell_coloring_wrapper("pink");
        }
        private void ccPurpleButton_Click(object sender, RibbonControlEventArgs e)
        {
            do_static_cell_coloring_wrapper("purple");
        }
        private void ccYellowButton_Click(object sender, RibbonControlEventArgs e)
        {
            do_static_cell_coloring_wrapper("yellow");
        }

        //色付け除去
        private void ccEmptyButton_Click(object sender, RibbonControlEventArgs e)
        {
            do_cell_coloring_empty_wrapper();
        }

        //太字
        private void fontBoldButton_Click(object sender, RibbonControlEventArgs e)
        {
            do_cell_bold_wrapper();
        }

        //赤字
        private void fontRedButton_Click(object sender, RibbonControlEventArgs e)
        {
            do_cell_red_wrapper();
        }

        //縦中
        private void cellVerticalCenterButton_Click(object sender, RibbonControlEventArgs e)
        {
            do_cell_vcenter_wrapper();
        }

        //折り返し
        private void cellLineBreakButton_Click(object sender, RibbonControlEventArgs e)
        {
            do_cell_linebreak_wrapper();
        }

        //通し番号
        private void autoNumberButton_Click(object sender, RibbonControlEventArgs e)
        {
            do_insert_auto_number_wrapper();
        }

        //行複写
        private void insertRowcontentButton_Click(object sender, RibbonControlEventArgs e)
        {
            do_insert_rowcontent();
        }

        //フッタークリア
        private void excelFooterClearButton_Click(object sender, RibbonControlEventArgs e)
        {
            do_excel_footer_clear();
        }

        //セル文字削除
        private void cellStrDeleteButton_Click(object sender, RibbonControlEventArgs e)
        {
            do_cell_clear_wrapper();
        }

        //フォームから値追加
        private void writeCommentAddFromFormButton_Click(object sender, RibbonControlEventArgs e)
        {
            inpfrmObj.Show();
        }
    }
}
