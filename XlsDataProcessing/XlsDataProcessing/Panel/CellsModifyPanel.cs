using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XlsDataProcessing.Unit;
using System.IO;

namespace XlsDataProcessing.Panel
{
    public partial class CellsModifyPanel : UserControl
    {
        CellsData[] cellsDataS;
        int xlsxNum;
        public CellsModifyPanel()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            cellsDataS = cellsAndValue1.ListCellsData.ToArray();
            xlsxNum = folderList1.xlsFileList.Count;
            //判断表格和数据是否符合条件
            if (cellsDataS.Count() <= 0 || folderList1.xlsFileList.Count <= 0)
                return;
            if (!bgw.IsBusy)
                bgw.RunWorkerAsync();
            btnRun.Enabled = false;
        }

        private void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < xlsxNum; i++)
            {
                var f = folderList1.xlsFileList[i];

                //跨线程调用窗体
                this.Invoke((EventHandler)(delegate
                {
                    cmDinfo1.AddInfo(String.Format("正在处理第{0}/{1}个文件：{2}", i + 1, xlsxNum, f.Name));
                }));

                XlsxHandle XlsxH = new XlsxHandle(f);
                //处理第一个表格，注意是从1开始，而不是0！
                XlsxH.ModifyCells(1, cellsDataS);
                XlsxH.Release();
            }

            this.Invoke((EventHandler)(delegate
            {
                btnRun.Enabled = true;
                cmDinfo1.AddInfo("所有文件处理完成！");
            }));
        }
    }
}
