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

        //角丸赤枠を挿入
        private void insert_rounded_rect()
        {
            var ash = Globals.ThisAddIn.Application.ActiveSheet;
            var scl = Globals.ThisAddIn.Application.ActiveCell;
            float left = float.Parse(scl.Left.ToString());
            float top = float.Parse(scl.Top.ToString());
            float[] size = { 120, 90 };
            var textBox = ash.Shapes.AddShape(5, left, top, size[0], size[1]);
            // border設定
            textBox.Fill.Visible = MsoTriState.msoFalse;
            textBox.Line.ForeColor.RGB = getRGB(255, 0, 0);
            textBox.Line.Transparency = 0.2F;
            textBox.Line.Weight = 3;
            // shadow設定
            textBox.Shadow.Visible = MsoTriState.msoTrue;
            textBox.Shadow.Style = MsoShadowStyle.msoShadowStyleOuterShadow;
            textBox.Shadow.OffsetX = 1;
            textBox.Shadow.OffsetY = 1;
            textBox.Shadow.Transparency = 0.5F;
            textBox.Select();
        }

        //吹出を挿入
        private void insert_callout()
        {
            var ash = Globals.ThisAddIn.Application.ActiveSheet;
            var scl = Globals.ThisAddIn.Application.ActiveCell;
            float left = float.Parse(scl.Left.ToString());
            float top = float.Parse(scl.Top.ToString());
            float[] size = { 120, 90 };
            var rectCallout = ash.Shapes.AddShape(105, left, top, size[0], size[1]);
            rectCallout.Fill.ForeColor.RGB = getRGB(255, 255, 255);
            rectCallout.TextFrame2.TextRange.Font.Fill.ForeColor.RGB = getRGB(0, 0, 0);
            rectCallout.TextFrame2.TextRange.Font.Size = 9;
            rectCallout.TextFrame2.TextRange.Font.Name = "ＭＳ Ｐゴシック";
            rectCallout.Line.ForeColor.RGB = getRGB(255, 192, 0);
            rectCallout.Line.Weight = 1.5F;
            rectCallout.Select();
        }

        //図形矢印を挿入
        private void insert_arrow()
        {
            var ash = Globals.ThisAddIn.Application.ActiveSheet;
            var scl = Globals.ThisAddIn.Application.ActiveCell;
            float left = float.Parse(scl.Left.ToString());
            float top = float.Parse(scl.Top.ToString());
            float[] size = { 200, 75 };
            var arrow = ash.Shapes.AddShape(33, left, top, size[0], size[1]);
            arrow.Fill.ForeColor.RGB = getRGB(255, 153, 0);
            arrow.Line.Visible = MsoTriState.msoFalse;
            arrow.Shadow.Visible = MsoTriState.msoTrue;
            arrow.Shadow.Style = MsoShadowStyle.msoShadowStyleOuterShadow;
            arrow.Shadow.OffsetX = 1;
            arrow.Shadow.OffsetY = 1;
            arrow.Shadow.Transparency = 0.5F;
        }

        //線矢印を挿入
        private void insert_line_arrow()
        {
            var ash = Globals.ThisAddIn.Application.ActiveSheet;
            var scl = Globals.ThisAddIn.Application.ActiveCell;
            float left = float.Parse(scl.Left.ToString());
            float top = float.Parse(scl.Top.ToString());
            float[] matrix = { left, top };
            var arrow = ash.Shapes.AddLine(matrix[0], matrix[1], matrix[0] + 60, matrix[1] + 10);
            arrow.Line.EndArrowheadStyle = MsoArrowheadStyle.msoArrowheadOpen;
            arrow.Line.EndArrowheadLength = MsoArrowheadLength.msoArrowheadLong;
            arrow.Line.EndArrowheadWidth = MsoArrowheadWidth.msoArrowheadWide;
            arrow.Line.ForeColor.RGB = getRGB(255, 0, 0);
            arrow.Line.Weight = 2.5F;
            arrow.Shadow.Visible = MsoTriState.msoTrue;
            arrow.Shadow.Visible = MsoTriState.msoTrue;
            arrow.Shadow.Style = MsoShadowStyle.msoShadowStyleOuterShadow;
            arrow.Shadow.OffsetX = 1;
            arrow.Shadow.OffsetY = 1;
            arrow.Shadow.Transparency = 0.5F;
        }

        //透明枠を挿入
        private void insert_textbox()
        {
            var ash = Globals.ThisAddIn.Application.ActiveSheet;
            var scl = Globals.ThisAddIn.Application.ActiveCell;
            float left = float.Parse(scl.Left.ToString());
            float top = float.Parse(scl.Top.ToString());
            float[] size = { 200, 100 };
            var textBox = ash.Shapes.AddTextbox(MsoTextOrientation.msoTextOrientationHorizontal, left, top, size[0], size[1]);
            textBox.Fill.Visible = MsoTriState.msoFalse;
            textBox.Line.Visible = MsoTriState.msoFalse;
            textBox.TextFrame2.TextRange.Font.Size = 9;
            textBox.TextFrame2.TextRange.Font.Name = "ＭＳ Ｐゴシック";
            textBox.Select();
        }

        //図形の書式無効化
        private void reset_shape_style()
        {
            var sa = Globals.ThisAddIn.Application.Selection;
            var sps = sa.ShapeRange;
            for (int i = 1; i <= sps.Count; i++)
            {
                var sp = sps[i];
                sp.Fill.Visible = MsoTriState.msoFalse;
                sp.Line.Visible = MsoTriState.msoFalse;
                //sp.TextFrame.TextRange.Font.Bold = MsoTriState.msoFalse;
            }
        }

        //最前面に移動
        private void bring_front()
        {
            var sa = Globals.ThisAddIn.Application.Selection;
            var sps = sa.ShapeRange;
            for (int i = 1; i <= sps.Count; i++)
            {
                var sp = sps[i];
                sp.ZOrder(MsoZOrderCmd.msoBringToFront);
            }
        }

        //横反転
        private void horizontal_flip()
        {
            var sa = Globals.ThisAddIn.Application.Selection;
            var sps = sa.ShapeRange;
            for (int i = 1; i <= sps.Count; i++)
            {
                var sp = sps[i];
                sp.Flip(MsoFlipCmd.msoFlipHorizontal);
            }
        }

        //縦反転
        private void vertical_flip()
        {
            var sa = Globals.ThisAddIn.Application.Selection;
            var sps = sa.ShapeRange;
            for (int i = 1; i <= sps.Count; i++)
            {
                var sp = sps[i];
                sp.Flip(MsoFlipCmd.msoFlipVertical);
            }
        }

    }
}
