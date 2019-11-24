using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;

namespace WebACAddin
{
    public partial class CtrlForm : Form
    {

        private Excel.Range mmRange;

        public CtrlForm()
        {
            InitializeComponent();
            //常に前面表示
            TopMost = true;
            //サイズ変更不可
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            mmRange = null;
        }


        //下へカーソル移動
        private void cellGoBottomButton_Click(object sender, EventArgs e)
        {
            Excel.Range sa = Globals.ThisAddIn.Application.Selection;
            Excel.Worksheet ash = Globals.ThisAddIn.Application.ActiveSheet;

            int r, c = 0;
            r = sa.Row;
            c = sa.Column;

            int rx = r;
            do
            {
                rx++;
            }
            while (ash.Rows[rx].EntireRow.Hidden == true);

            Excel.Range nextCell = ash.Cells[rx, c];
            nextCell.Select();

        }

        //上へカーソル移動
        private void cellGoTopButton_Click(object sender, EventArgs e)
        {
            Excel.Range sa = Globals.ThisAddIn.Application.Selection;
            Excel.Worksheet ash = Globals.ThisAddIn.Application.ActiveSheet;

            int r, c = 0;
            r = sa.Row;
            c = sa.Column;
            if(r == 1)
            {
                MessageBox.Show("これ以上、上に移動できません！");
                return;
            }

            int rx = r;
            do
            {
                rx--;
            }
            while (ash.Rows[rx].EntireRow.Hidden == true);


            Excel.Range nextCell = ash.Cells[rx, c];
            nextCell.Select();
        }

        //左へカーソル移動
        private void cellGoLeftButton_Click(object sender, EventArgs e)
        {
            Excel.Range sa = Globals.ThisAddIn.Application.Selection;
            Excel.Worksheet ash = Globals.ThisAddIn.Application.ActiveSheet;

            int r, c = 0;
            r = sa.Row;
            c = sa.Column;
            if (c == 1)
            {
                MessageBox.Show("これ以上、左に移動できません！");
                return;
            }

            int cx = c;
            do
            {
                cx--;
            }
            while (ash.Columns[cx].EntireColumn.Hidden == true);

            Excel.Range nextCell = ash.Cells[r, cx];
            nextCell.Select();
        }

        //右へカーソル移動
        private void cellGoRightButton_Click(object sender, EventArgs e)
        {
            Excel.Range sa = Globals.ThisAddIn.Application.Selection;
            Excel.Worksheet ash = Globals.ThisAddIn.Application.ActiveSheet;

            int r, c = 0;
            r = sa.Row;
            c = sa.Column;

            int cx = c;
            do
            {
                cx++;
            }
            while (ash.Columns[cx].EntireColumn.Hidden == true);

            Excel.Range nextCell = ash.Cells[r, cx];
            nextCell.Select();
        }

        //透過表示
        private void opacityCheck_Click(object sender, EventArgs e)
        {
            if (this.Opacity == 1) this.Opacity = 0.7;
            else this.Opacity = 1;
        }

        //メモリーボタンクリック
        private void locationMemoryButton_Click(object sender, EventArgs e)
        {
            mmRange = Globals.ThisAddIn.Application.Selection;
        }

        //Backボタンクリック
        private void MemoryBackButton_Click(object sender, EventArgs e)
        {
            if(mmRange != null)
            {
                Excel.Worksheet ash = Globals.ThisAddIn.Application.ActiveSheet;
                Excel.Range mmCell = ash.Cells[mmRange.Row, mmRange.Column];
                mmCell.Select();
            }
        }
    }
}
