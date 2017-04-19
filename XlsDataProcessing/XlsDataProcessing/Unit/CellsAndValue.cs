using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XlsDataProcessing.Unit
{
    public partial class CellsAndValue : UserControl
    {
        Dictionary<string, string> cellValues = new Dictionary<string, string>();

        public CellsAndValue()
        {
            InitializeComponent();
            //dgvCells.DataSource = cellValues;
            //cellValues.Add("A1", "123");
        }
    }
}
