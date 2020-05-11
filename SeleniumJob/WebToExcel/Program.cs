using System;
using System.IO;
using OfficeOpenXml;

namespace WebToExcel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IterateExcel(2, 30000);

        }
        public static void IterateExcel(int Column, int Row)
        {
            string path = "F:\\Selenium\\SeleniumJob\\Data\\AshishWorksheet.xlsx";
            MemoryStream stream = new MemoryStream();
            ExcelPackage package = new ExcelPackage(stream);
            //var sheet = package.Workbook.Worksheets.Add("Ashish");
            var shee = package.Workbook
            sheet.Cells[1, 1].Value = "Name";
            sheet.Cells[1, 2].Value = "Addres111s";
            package.Save();



            // for (int i = 2; i <= Row; i++)
            // {
            //     for (int j = 1; j <= Column; j++)
            //     {
            //         Console.WriteLine("Starting the process");
            //         var stream = new MemoryStream();
            //         using (var package = new ExcelPackage(stream))
            //         {
            //             var sheet = package.Workbook.Worksheets.Add("ashishTest");
            //         }
            //     }
            // }
        }
    }
}
