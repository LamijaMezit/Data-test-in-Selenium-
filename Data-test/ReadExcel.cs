using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Data_test
{
     public class ReadExcel
    {
        public static IEnumerable<object[]> RExcel()
        {
            using (ExcelPackage package = new ExcelPackage(new FileInfo("C:/Users/lamij/OneDrive/Desktop/Lamija1-data.xslx")))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets["List"];
                int rowCount = worksheet.Dimension.End.Row;
                for ( int row=2; row<=rowCount; row++)
                {
                    yield return new object[]
                    {
                        worksheet.Cells[row,1].Value?.ToString().Trim()

                    };
                }

            }
        }
    }
}
