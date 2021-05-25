using System;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace parse_exc
{
    class Programm
    {
       static void Main(string[] args)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook sheet = excel.Workbooks.Open("C:\\Users\\German\\source\\repos\\parse_exc\\Production_wells.xlsx");
            Microsoft.Office.Interop.Excel.Worksheet x = excel.ActiveSheet as Microsoft.Office.Interop.Excel.Worksheet;

            Excel.Range userRange = x.UsedRange;
            int countRecords = userRange.Rows.Count;

            Console.WriteLine(countRecords);

            sheet.Close(true, Type.Missing, Type.Missing);
            excel.Quit();

        }
    }
}
