using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebACAddin
{
    public partial class Progress : Form
    {
        public delegate void Func(IProgress<int> p, CancellationToken cancelToken);
        CancellationTokenSource _cancellTokenSource;
        Task m_Task;
        Func m_Func;

        public Progress()
        {
            InitializeComponent();
        }

        public void SetTitle(string title)
        {
            this.Text = title;
        }

        public void SetFunction(Func func)
        {
            m_Func = func;
        }

        private void ShowProgress(int percent)
        {
            this.progressBar1.Value = percent;
            if (percent == 100)
            {
                m_Task.Wait();
                this.Close();
            }
        }

        private void Progress_Shown(object sender, EventArgs e)
        {
            _cancellTokenSource = new CancellationTokenSource();
            var cancelToken = _cancellTokenSource.Token;
            var p = new Progress<int>(ShowProgress);
            m_Task = Task.Run(() => m_Func(p, cancelToken));
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.CancelButton.Enabled = false;
            if(_cancellTokenSource != null)
            {
                _cancellTokenSource.Cancel();
                m_Task.Wait();
                this.Close();
            }
        }
    }
}
