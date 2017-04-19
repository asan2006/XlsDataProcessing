using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace XlsDataProcessing
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            //程序名称及版本初始化
            Text = Assembly.GetEntryAssembly().GetName().Name;
        }
    }
}
