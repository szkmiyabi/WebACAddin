using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Microsoft.Office.Tools.Ribbon;
using System.Text.RegularExpressions;
using Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;

namespace WebACAddin
{
    public partial class ListAddForm : Form
    {

        public ListAddForm()
        {
            InitializeComponent();
            ListAddFormText.Text = "　\r\n適合\r\n適合(注記)\r\n不適合\r\n非適用";
        }

        //条件書式を追加
        private void add_data()
        {
            if (ListAddFormText.Text == "")
            {
                MessageBox.Show("値が入力されていません!");
            }
            string buf = ListAddFormText.Text;
            string[] sep = { "\r\n" };
            string[] lines = buf.Split(sep, StringSplitOptions.None);
            string buf_txt = "";
            for (int i = 0; i < lines.Length; i++)
            {
                string row = lines[i];
                buf_txt += row;
                if (i != (lines.Length - 1)) buf_txt += ",";

            }

            var sa = Globals.ThisAddIn.Application.Selection;
            object alertType = Microsoft.Office.Interop.Excel.XlDVAlertStyle.xlValidAlertInformation;
            object conditionOperator = 3;
            object valueList = buf_txt;
            try
            {
                sa.Validation.Add(
                    Microsoft.Office.Interop.Excel.XlDVType.xlValidateList,
                    alertType,
                    conditionOperator,
                    valueList
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("入力規則リスト設定に成功しました");
            this.Dispose();

        }

        //追加するボタンクリック
        private void InputFormAddButton_Click(object sender, EventArgs e)
        {
            add_data();
        }

        private void ListAddFormText_KeyDown(object sender, KeyEventArgs e)
        {
            //Ctrl + A
            if (e.Control && e.KeyCode == Keys.A)
            {
                e.SuppressKeyPress = true; //beep disabled
                ListAddFormText.SelectAll();
            }
        }
    }
}
