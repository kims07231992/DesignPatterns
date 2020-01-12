using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.IO;
using PG5_DP_Factory.DocumentsOffice.Model;

namespace PG5_DP_Factory.DocumentsOffice.FileHandlers
{
    //'================================================================================================================
    //' CLASS NAME  : ExcelHandler
    //'               1. Class to launch and create excel extension files.
    //'================================================================================================================
    public class ExcelHandler : FileHandler
    {
        public override void CreateFile(string filePath, DocumentModel data)
        {
            int? workSheetIndex = null;
            Application excelApp = null;
            Workbook wb = null;
            Worksheet ws = null;

            try
            {
                workSheetIndex = 1;           
                excelApp = new Application();
                wb = excelApp.Workbooks.Add();
                ws = wb.Worksheets.get_Item(workSheetIndex) as Worksheet;

                // write title and description    
                int r = 1;
                ws.Cells[r++, 1] = data.Title;
                ws.Cells[r++, 1] = data.Description;
                
                // save and close
                wb.SaveAs(filePath);
                wb.Close(true);
                excelApp.Quit();
            }
            finally
            {
                ReleaseFileObject(ws);
                ReleaseFileObject(wb);
                ReleaseFileObject(excelApp);
            }
        }
        public override void LaunchFile(string filePath)
        {
            Application excelApp = null;
            Workbook wb = null;

            // launch file
            excelApp = new Application();
            excelApp.Visible = true;
            wb = excelApp.Workbooks.Open(filePath); // open excel file
        }
    }
}
