using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace _06.EXCELlent_Knowledge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create COM Objects. Create a COM object for everything that is referenced
            Application xlApp = new Application();
            Workbook xlWorkbook = xlApp.Workbooks.Open(@"sample_table.xlsx");
            _Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Range xlRange = xlWorksheet.UsedRange;
            

        }
    }
}
