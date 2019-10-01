using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using System.Globalization;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Tools.Ribbon;
using Microsoft.Office.Interop.Excel;

namespace WebACAddin
{
    public partial class ConditionFormatForm : Form
    {
        public ConditionFormatForm()
        {
            InitializeComponent();
            conditionType.SelectedIndex = 0;
            //常に前面表示
            TopMost = true;
            ConditionFormatFormTopMostCheck.Checked = true;
            bgcolorRgb.Text = "(255,128,64)";
        }

        //背景色を取得
        private void openConditionColorPalletButton_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.AllowFullOpen = true;
            if(cd.ShowDialog() == DialogResult.OK)
            {
                Color crc = cd.Color;
                bgcolorRgb.Text = decode_to_tuple(crc);
            }
        }

        //条件付き書式を設定
        private void set_condition_format()
        {
            if (bgcolorRgb.Text == "" || conditionKeyword.Text == "") return;

            string keyword = conditionKeyword.Text;
            Color argb = encode_from_tuple(bgcolorRgb.Text);
            int cr_condition_tp = conditionType.SelectedIndex;

            Excel.Range sa = Globals.ThisAddIn.Application.Selection;
            Excel.FormatCondition fcs = null;

            switch(cr_condition_tp)
            {
                case 0:
                    fcs = sa.FormatConditions.Add(
                        XlFormatConditionType.xlTextString,
                        Type.Missing,
                        Type.Missing,
                        Type.Missing,
                        keyword,
                        XlContainsOperator.xlContains,
                        Type.Missing,
                        Type.Missing);

                    break;
                case 1:
                    fcs = sa.FormatConditions.Add(
                        XlFormatConditionType.xlTextString,
                        Type.Missing,
                        Type.Missing,
                        Type.Missing,
                        keyword,
                        XlContainsOperator.xlDoesNotContain,
                        Type.Missing,
                        Type.Missing);
                    break;
                case 2:
                    fcs = sa.FormatConditions.Add(
                        XlFormatConditionType.xlTextString,
                        Type.Missing,
                        Type.Missing,
                        Type.Missing,
                        keyword,
                        XlContainsOperator.xlBeginsWith,
                        Type.Missing,
                        Type.Missing);
                    break;
                case 3:
                    fcs = sa.FormatConditions.Add(
                        XlFormatConditionType.xlTextString,
                        Type.Missing,
                        Type.Missing,
                        Type.Missing,
                        keyword,
                        XlContainsOperator.xlEndsWith,
                        Type.Missing,
                        Type.Missing);
                    break;
            }

            fcs.Interior.Color = argb;
        }

        //条件付き書式除去
        private void del_condition_format()
        {
            Excel.Range sa = Globals.ThisAddIn.Application.Selection;
            try
            {
                sa.FormatConditions.Delete();

            }
            catch (Exception ex)
            {
                MessageBox.Show("条件付き書式はありません。");
            }
        }

        //Color構造体からタプルに変換
        private string decode_to_tuple(Color c)
        {
            string rgbText = String.Format("({0},{1},{2})", new object[] { c.R, c.G, c.B });
            return rgbText;
        }

        //タプルからカラー構造体に変換
        private Color encode_from_tuple(String tuple)
        {
            Color c = new Color();
            Regex pt = new Regex(@"(\(|\))", RegexOptions.Compiled);
            string csv = pt.Replace(tuple, "");
            string[] argb = csv.Split(',');
            int r = int.Parse(argb[0]);
            int g = int.Parse(argb[1]);
            int b = int.Parse(argb[2]);
            c = Color.FromArgb(255, r, g, b);
            return c;
        }

        //条件付き書式追加クリック
        private void addButton_Click(object sender, EventArgs e)
        {
            set_condition_format();
            //this.Dispose();
        }

        //条件付き書式削除クリック
        private void deleteButton_Click(object sender, EventArgs e)
        {
            del_condition_format();
            //this.Dispose();
        }

        //常に前面表示のトグル
        private void ConditionFormatFormTopMostCheck_Click(object sender, EventArgs e)
        {
            TopMost = !TopMost;
        }
    }
}
