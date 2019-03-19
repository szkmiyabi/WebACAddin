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


namespace WebACAddin
{
    partial class Ribbon1
    {

        //Form表示
        private void do_doc_form()
        {
            docfrmObj.Show();
        }

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

    }
}
