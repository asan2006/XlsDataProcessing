using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Office.Interop;
using Microsoft.Office.Interop.Excel;

namespace XlsDataProcessing.Unit
{
    public class XlsxHandle
    {
        public static FileInfo xlsxFile;
        private Microsoft.Office.Interop.Excel.Application xlApp;
        private Microsoft.Office.Interop.Excel.Workbook xlBook;
        private Microsoft.Office.Interop.Excel.Worksheet xlSheet;
        public XlsxHandle(FileInfo fi)
        {            
            xlsxFile = fi;
            xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlBook = xlApp.Workbooks.Open(xlsxFile.FullName);
        }

        public void ModifyCells(int sheetIndex, CellsData[] cellsDatas)
        {
            xlSheet = xlBook.Worksheets[sheetIndex];
            foreach (var data in cellsDatas)
            {
                xlSheet.Range[data.CellName].Value = data.CellValue;
                xlBook.Save();
            }
        }
        /// <summary>
        /// 使用完毕一定要回收excel资源
        /// </summary>
        public void Release()
        {
            try
            {
                xlBook.Close();
                xlApp.Quit();
                xlSheet = null;
                xlBook = null;
                xlApp = null;
                GC.Collect();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
