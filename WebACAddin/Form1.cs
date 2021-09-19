using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WebACAddin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TopMost = true;
        }

        public void setTitle(string title)
        {
            this.Text = title;
        }

        private void reportText_KeyDown(object sender, KeyEventArgs e)
        {
            //Ctrl + A を実装
            if(e.Control && e.KeyCode == Keys.A)
            {
                e.SuppressKeyPress = true; //beep解除
                reportText.SelectAll();
            }
        }

    }
}
