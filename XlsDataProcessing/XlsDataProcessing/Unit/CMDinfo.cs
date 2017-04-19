using System;
using System.Windows.Forms;

namespace XlsDataProcessing.Unit
{
    public partial class CMDinfo : UserControl
    {
        public CMDinfo()
        {
            InitializeComponent();
        }

        public void AddInfo(string strInfo)
        {
            txtInfo.AppendText(String.Format("{0}: {1}\r\n", DateTime.Now.ToString("hh:mm:ss"), strInfo));
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtInfo.Clear();
        }
    }
}
