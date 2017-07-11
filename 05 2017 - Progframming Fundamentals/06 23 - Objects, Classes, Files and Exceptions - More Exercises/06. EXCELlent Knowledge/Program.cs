using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.IO;

namespace _06.EXCELlent_Knowledge
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Directory.GetCurrentDirectory();
            Console.WriteLine(path);
            Application xlApp = new Application();
            Workbook xlWorkbook = xlApp.Workbooks.Open($@"{path}\a.xlsx");
            Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Range xlRange = xlWorksheet.UsedRange;
            
            

            for (int i = 1; i <= 5; i++)
            {
                if (xlWorksheet.Cells[i, 1] == null) break;

                for (int j = 1; j <= 5; j++)
                {
                    if (xlWorksheet.Cells[i, j] == null) break;
                    Console.Write(xlWorksheet.Cells[i, j].Value2 + "|");
                }
                Console.WriteLine();
            }
            
        }
    }
}
