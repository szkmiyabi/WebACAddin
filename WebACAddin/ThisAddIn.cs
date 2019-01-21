using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;

namespace WebACAddin
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            //Excel終了時フォームを強制的に閉じる
            if (Ribbon1.frmObj.IsDisposed == false) Ribbon1.frmObj.Dispose();
            if (Ribbon1.brfrmObj.IsDisposed == false) Ribbon1.brfrmObj.Dispose();
            if (Ribbon1.cnfrmObj.IsDisposed == false) Ribbon1.cnfrmObj.Dispose();
            if (Ribbon1.wrfrmObj.IsDisposed == false) Ribbon1.wrfrmObj.Dispose();
        }

        #region VSTO で生成されたコード

        /// <summary>
        /// デザイナーのサポートに必要なメソッドです。
        /// このメソッドの内容をコード エディターで変更しないでください。
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
