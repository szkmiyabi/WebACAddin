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
using Microsoft.Office.Tools.Ribbon;
using System.Text.RegularExpressions;
using System.IO;

namespace WebACAddin
{
    public partial class ComboEditForm : Form
    {

        private string br_sp = "<bkmk:br>";

        //コンストラクタ
        public ComboEditForm()
        {
            InitializeComponent();
            TopMost = true;
            comboValTable.ColumnCount = 1;
            comboValTable.Columns[0].HeaderText = "値";
            comboValTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            comboValTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            comboValTable.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            comboValTable.ColumnHeadersVisible = false;
            load_from_combo();
        }

        //リボンのドロップダウン値を読み込む
        private void load_from_combo()
        {
            List<string> data = _load_data_from_combo();
            foreach (string vl in data)
            {
                comboValTable.Rows.Add(vl);
            }
        }
        private List<string> _load_data_from_combo()
        {
            List<string> data = new List<string>();
            RibbonComboBox cmb = Globals.Ribbons.Ribbon1.writeCommentCombo;
            for(int i=0; i<cmb.Items.Count; i++)
            {
                RibbonDropDownItem itm = cmb.Items[i];
                string cr = _br_decode(itm.Label);
                data.Add(cr);
            }
            return data;
        }
        private string _br_decode(string str)
        {
            return str.Replace(br_sp, "\n");
        }

        //フォームからリボンのドロップダウン値を更新する
        private void set_to_combo()
        {
            RibbonComboBox cmb = Globals.Ribbons.Ribbon1.writeCommentCombo;
            cmb.Items.Clear();
            List<string> data = _load_data_from_table();
            for(int i=0; i<data.Count; i++)
            {
                RibbonDropDownItem itm = Globals.Ribbons.Ribbon1.Factory.CreateRibbonDropDownItem();
                string cr = data[i];
                itm.Label = _br_encode(cr);
                cmb.Items.Add(itm);
            }
            MessageBox.Show("値の更新に成功しました!");
            this.Dispose();
            
        }
        private List<string> _load_data_from_table()
        {
            List<string> data = new List<string>();
            for(int i=0; i<comboValTable.RowCount; i++)
            {
                string cr = (string) comboValTable.Rows[i].Cells[0].Value;
                if (cr == null) continue;
                data.Add(cr);
            }
            return data;
        }

        private string _br_encode(string str)
        {
            try
            {
                string ret = Regex.Replace(str, @"\n", br_sp);
                return ret;
            }
            catch(Exception ex)
            {
                return str;
            }
        }

        //値更新クリック
        private void comboUpdateButton_Click(object sender, EventArgs e)
        {
            set_to_combo();
        }

        //キャンセルクリック
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
