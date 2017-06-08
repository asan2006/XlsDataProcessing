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
        //Dictionary<string, string> cellValues = new Dictionary<string, string>();
        public BindingList<string> blCellsData { get; set; }

        public CellsAndValue()
        {
            InitializeComponent();
            dgvCells.Rows.Add(new object[] { "D25","T=22"});
            dgvCells.Rows.Add(new object[] { "D26", "RH=29%" });

            //dgvCells.DataBindings.Add("DataSource", this, "blCellsData", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        public string TextTip
        {
            get { return gbText.Text; }
            set { value = gbText.Text; }
        }

        public List<CellsData> ListCellsData
        {
            get
            {
                List<CellsData> ls = new List<CellsData>();
                for (int i = 0; i < dgvCells.Rows.Count; i++)
                {
                    var cell = dgvCells.Rows[i].Cells[0].Value;
                    var value = dgvCells.Rows[i].Cells[1].Value;
                    if (cell != null && value != null)
                    {
                        CellsData data = new CellsData(cell.ToString(), value.ToString());
                        ls.Add(data);
                    }
                }
                return ls;
            }
        }
    }
}