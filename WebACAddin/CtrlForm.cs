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
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace WebACAddin
{
    public partial class CtrlForm : Form
    {

        //タイトルバーなしでドラッグ操作可能にするメンバ、メソッド定義
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();

        //セル位置記憶
        private Excel.Range mmRange;


        public CtrlForm()
        {
            InitializeComponent();
            //常に前面表示
            TopMost = true;
            //サイズ変更不可
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            mmRange = null;
            //透過有効
            opacityCheck.Checked = true;
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

        //閉じるボタンクリック
        private void CtrlFormCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //タイトルバーなしでフォームをドラッグ操作可能にする
        private void CtrlForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //マウスのキャプチャを解除
                ReleaseCapture();
                //タイトルバーでマウスの左ボタンが押されたことにする
                SendMessage(Handle, WM_NCLBUTTONDOWN, (IntPtr)HT_CAPTION, IntPtr.Zero);
            }
        }

        //Goボタンクリック
        private void jumpThisCellButton_Click(object sender, EventArgs e)
        {
            string addr = jumpCellAddrText.Text;
            if (addr == "" || addr == null) return;
            Regex pt = new Regex(@"([a-zA-Z]*)([0-9]+)", RegexOptions.Compiled);
            if (!pt.IsMatch(addr)) return;
            addr = addr.ToUpper();
            Regex pt_num = new Regex(@"^[0-9]+", RegexOptions.Compiled);
            if(pt_num.IsMatch(addr))
            {
                addr = "A" + addr;
            }
            Excel.Worksheet ash = Globals.ThisAddIn.Application.ActiveSheet;
            ash.Range[addr].Select();

        }

        //ウィンドウが非アクティブの場合透明化
        private void CtrlForm_Deactivate(object sender, EventArgs e)
        {
            try
            {
                if (opacityCheck.Checked == true) this.Opacity = 0.5;
            }
            catch (Exception ex) { }
        }

        //ウィンドウがアクティブの場合通常表示
        private void CtrlForm_Activated(object sender, EventArgs e)
        {
            if (opacityCheck.Checked == true) this.Opacity = 1;
        }
    }
}
