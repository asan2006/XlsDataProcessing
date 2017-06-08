using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XlsDataProcessing.Panel
{
    public partial class PST5XProcessPanel : UserControl
    {
        public PST5XProcessPanel()
        {
            InitializeComponent();
        }

        private void btn_iTest_Click(object sender, EventArgs e)
        {
            var headerA1 = "Time(S)";
            var headerB1 = "ADXL335_In_X";
            var headerC1 = "ADXL335_In_Y";
            var headerD1 = "ADXL335_Ex_Y";
            var headerE1 = "LPR403AL";
            var headerF1 = "ADXL335_In_X_Ave";
            var headerG1 = "ADXL335_In_Y_Ave";
            var headerH1 = "ADXL335_Ex_Y_Ave";
            var headerI1 = "LPR403AL_Ave";
            var headerJ1 = "ADXL335_In_Y_Null";
            var headerK1 = "ADXL335_Ex_Y_Null";
            var headerL1 = "ADXL335_In_Y_Net";
            var headerM1 = "ADXL335_Ex_Y_Net";
            var headerN1 = "Smooth";

            foreach (var file in folderList1.xlsFileList)
            {
                /**************************************************************
                var directoryName = file.Directory.Name;
                //处理加速度数据
                if (directoryName.Contains("acc"))
                {
                    ExcelPackage ep = new ExcelPackage(file);
                    ExcelWorkbook wb = ep.Workbook;
                    //处理原始数据表
                    string strRNG;
                    var originalSheet = wb.Worksheets[1];
                    var rowCount = originalSheet.Dimension.End.Row;
                    var dt = (double)originalSheet.Cells["A2"].Value;
                    originalSheet.Name = "Original Data";
                    originalSheet.Cells["B1"].Value = headerB1;
                    originalSheet.Cells["C1"].Value = headerC1;
                    originalSheet.Cells["D1"].Value = headerD1;
                    originalSheet.Cells["E1"].Value = headerE1;
                    originalSheet.Cells["F1"].Value = headerF1;
                    originalSheet.Cells["G1"].Value = headerG1;
                    originalSheet.Cells["H1"].Value = headerH1;
                    originalSheet.Cells["I1"].Value = headerI1;
                    originalSheet.Cells["J1"].Value = headerJ1;
                    originalSheet.Cells["K1"].Value = headerK1;
                    originalSheet.Cells["L1"].Value = headerL1;
                    originalSheet.Cells["M1"].Value = headerM1;
                    originalSheet.Cells["N1"].Value = headerN1;

                    //adxl335数据(包含陀螺仪数据）取30个平均值
                    strRNG = string.Format("F2:I{0}", rowCount.ToString());
                    originalSheet.Cells[strRNG].FormulaR1C1 = "=AVERAGE(RC[-4]:R[29]C[-4])";

                    //计算ADXL335_Null值,取0.8s的静态数据，默认数据采集频率为500HZ
                    var nullCount = 0.8 / dt;
                    originalSheet.Cells["J2"].Formula = string.Format("=AVERAGE(G2:G{0})", nullCount.ToString());
                    originalSheet.Cells["K2"].Formula = string.Format("=AVERAGE(H2:H{0})", nullCount.ToString());

                    //计算ADXL335_Net值
                    strRNG = string.Format("L2:L{0}", rowCount.ToString());
                    originalSheet.Cells[strRNG].FormulaR1C1 = "=RC[-5]-R2C10";
                    strRNG = string.Format("M2:M{0}", rowCount.ToString());
                    originalSheet.Cells[strRNG].FormulaR1C1 = "=RC[-5]-R2C11";

                    //计算Smooth
                    strRNG = string.Format("N2:N{0}", rowCount.ToString());
                    originalSheet.Cells[strRNG].FormulaR1C1 = "=AVERAGE(RC[-2]:R[9]C[-2])";

                    //画散点图
                    var chrt = originalSheet.Drawings.AddChart("test", eChartType.XYScatterLinesNoMarkers);
                    //chrt.Series.Add("F:H", "A:A");

                    ep.Save();
                    ep.Dispose();                   

                }
                ************************************/
            }
        }
    }
}
