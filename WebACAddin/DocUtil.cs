using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using System.IO;
using Microsoft.Office.Tools.Ribbon;

namespace WebACAddin
{
    partial class Ribbon1
    {

        //検査報告書等Excelのフッター未指定処理
        private void do_excel_footer_clear()
        {
            Excel.Workbook wbk = Globals.ThisAddIn.Application.ActiveWorkbook;

            foreach(Excel.Worksheet cws in wbk.Worksheets)
            {
                cws.PageSetup.LeftFooter = "";
                cws.PageSetup.CenterFooter = "";
                cws.PageSetup.RightFooter = "";
            }
        }

        //アクティブブックのシート一覧コンボをセットする
        private void set_active_book_sheets()
        {
            if (activeBookSheetsCombo.Items.Count > 0) activeBookSheetsCombo.Items.Clear();

            var wbk = excelObj.Application.ActiveWorkbook;
            foreach (Excel.Worksheet cws in wbk.Worksheets)
            {
                string sname = cws.Name;
                RibbonDropDownItem itm = Factory.CreateRibbonDropDownItem();
                itm.Label = sname;
                activeBookSheetsCombo.Items.Add(itm);
            }
            MessageBox.Show("ワークシート一覧をセットしました！");
        }

        //シート一覧コンボで選択したシートに切り替える
        private void change_sheet_by_combo()
        {
            string crname = activeBookSheetsCombo.Text;
            var wbk = excelObj.Application.ActiveWorkbook;
            foreach (Excel.Worksheet cws in wbk.Worksheets)
            {
                string sname = cws.Name;
                if (crname == sname)
                {
                    cws.Activate();
                    break;
                }
            }
        }


    }
}
