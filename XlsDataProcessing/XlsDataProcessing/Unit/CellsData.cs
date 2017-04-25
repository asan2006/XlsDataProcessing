using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XlsDataProcessing.Unit
{
    public class CellsData
    {
        public CellsData(string paraCellName, string paraCellValue)
        {
            CellName = paraCellName;
            CellValue = paraCellValue;
        }

        public string CellName
        {
            get;
            set;
        }

        public string CellValue
        {
            get;
            set;
        }
    }
}
