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
        private int seed;
        private Boolean isLibraPlusOn;

        //Formオブジェクト
        private static Form1 _frmObj;
        private static BrowserForm _brfrmObj;
        private static ContrastForm _cnfrmObj;
        private static WriteForm _wrfrmObj;
        private static InputForm _inpfrmObj;
        private static ConditionFormatForm _ccffrmObj;
        private static CellForm _cllfrmObj;
        private static CtrlForm _ctrlfrmObj;
        private static ComboEditForm _cmbefrmObj;
        private static RepoUpdForm _rupfrmObj;

        //コンストラクタ
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            excelObj = WebACAddin.Globals.ThisAddIn;
            culture = new CultureInfo("ja-JP", true);
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();

            addLabelColorCheck.Checked = true;
            //writeCommentBreakCheck.Checked = true;
            writeCommentOverrideCheck.Checked = true;
            //addCommentPreClearCheck.Checked = true;
            addColorRowCheck.Checked = true;

            //writeCommentComboに初期スニペット登録
            init_writeCommentCombo();

            //判定修正スニペットコンボ初期化
            libraPlusToggle.Checked = true;
            isLibraPlusOn = true;
            init_svRedimFlagCombo();

            //乱数のシード値
            seed = Environment.TickCount;

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

        //ConditionFormatFormインスタンスの取得
        public static ConditionFormatForm ccffrmObj
        {
            get
            {
                if (_ccffrmObj == null || _ccffrmObj.IsDisposed)
                {
                    _ccffrmObj = new ConditionFormatForm();
                }
                return _ccffrmObj;
            }
        }

        //CellFormインスタンスの取得
        public static CellForm cllfrmObj
        {
            get
            {
                if(_cllfrmObj == null || _cllfrmObj.IsDisposed)
                {
                    _cllfrmObj = new CellForm();
                }
                return _cllfrmObj;
            }
        }

        //CtrlFormインスタンスの取得
        public static CtrlForm ctrlfrmObj
        {
            get
            {
                if (_ctrlfrmObj == null || _ctrlfrmObj.IsDisposed)
                {
                    _ctrlfrmObj = new CtrlForm();
                }
                return _ctrlfrmObj;
            }
        }

        //ComboEditFormインスタンスの取得
        public static ComboEditForm cmbefrmObj
        {
            get
            {
                if(_cmbefrmObj == null || _cmbefrmObj.IsDisposed)
                {
                    _cmbefrmObj = new ComboEditForm();
                }
                return _cmbefrmObj;
            }
        }

        //RepoUpdFormインスタンスの取得
        public static RepoUpdForm rupfrmObj
        {
            get
            {
                if(_rupfrmObj == null || _rupfrmObj.IsDisposed)
                {
                    _rupfrmObj = new RepoUpdForm();
                }
                return _rupfrmObj;
            }
        }

        //ハイパーリンクを設定
        private void setHrefBtn_Click(object sender, RibbonControlEventArgs e)
        {
            do_href_add_wrapper();
        }

        //ページタイトルを取得
        private void setPageTitleBtn_Click(object sender, RibbonControlEventArgs e)
        {
            do_page_title_add_wrapper();
        }

        //選択範囲をTSV保存
        private void saveAsTSVButton_Click(object sender, RibbonControlEventArgs e)
        {
            do_selet_area_tsv();
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
            do_add_comment_write();
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
            get_survey_base_wrapper();
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
        private void ccRedButton_Click(object sender, RibbonControlEventArgs e)
        {
            do_static_cell_coloring_wrapper("red");
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

        //オートフィル
        private void selectedAutoFillButton_Click(object sender, RibbonControlEventArgs e)
        {
            do_selected_auto_fill();
        }

        //ドロップダウンの値を保存
        private void writeCommentComboSaveButton_Click(object sender, RibbonControlEventArgs e)
        {
            do_save_val_comment();
        }

        //シート一覧を読み込み
        private void readActiveBookSheetsButton_Click(object sender, RibbonControlEventArgs e)
        {
            set_active_book_sheets();
        }

        //コンボで選択したシートに切り替える
        private void activeBookSheetsCombo_TextChanged(object sender, RibbonControlEventArgs e)
        {
            change_sheet_by_combo();
        }

        //カスタム条件書式
        private void customConditionFormatButton_Click(object sender, RibbonControlEventArgs e)
        {
            ccffrmObj.Show();
        }

        //抽出
        private void autoFilteredQueryButton_Click(object sender, RibbonControlEventArgs e)
        {
            do_auto_filtered_query();
        }

        //セル解析
        private void cellAnalysisButton_Click(object sender, RibbonControlEventArgs e)
        {
            cllfrmObj.Show();
        }

        //カーソル
        private void CursolControlFormButton_Click(object sender, RibbonControlEventArgs e)
        {
            ctrlfrmObj.Show();
        }

        //値編集
        private void doEditComboButton_Click(object sender, RibbonControlEventArgs e)
        {
            cmbefrmObj.Show();
        }

        //升目
        private void borderMatrixButton_Click(object sender, RibbonControlEventArgs e)
        {
            do_border_matrix();
        }

        //無地
        private void borderClearButton_Click(object sender, RibbonControlEventArgs e)
        {
            do_border_clear();
        }

        //レポート行修正
        private void repoRowUpdateButton_Click(object sender, RibbonControlEventArgs e)
        {
            rupfrmObj.Show();
        }

        //再検査チェックをクリック
        private void writeCommentReSurveyCheck_Click(object sender, RibbonControlEventArgs e)
        {
            init_reserv_check_option();
        }

        //乱数
        private void doRandomNumsButton_Click(object sender, RibbonControlEventArgs e)
        {
            do_random_nums();
        }

        //オートフィルタ文字列自動設定
        private void autoFilterAutoValSetButton_Click(object sender, RibbonControlEventArgs e)
        {
            set_mytext_auto_filter();
        }

        //表全体選択
        private void usedRangeSelectButton_Click(object sender, RibbonControlEventArgs e)
        {
            auto_select_used_range();
        }

        //LibraPlusトグルボタンON/OFF
        private void libraPlusToggle_Click(object sender, RibbonControlEventArgs e)
        {
            isLibraPlusOn = libraPlusToggle.Checked;
            init_svRedimFlagCombo();
        }
    }
}
