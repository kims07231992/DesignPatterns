using PG5_DP_Factory.DocumentsOffice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;
using System.IO;
using System.Runtime.InteropServices;

namespace PG5_DP_Factory.DocumentsOffice.FileHandlers
{
    //'================================================================================================================
    //' CLASS NAME  : WordHandler
    //'               1. Class to launch and create word extension files.
    //'================================================================================================================
    public class WordHandler : FileHandler
    {
        public override void CreateFile(string filePath, DocumentModel data)
        {
            Application wordApp = null;
            Document doc = null;

            try
            {
                wordApp = new Application();
                doc = wordApp.Documents.Add();

                // write title and description
                doc.Range().Text = data.Title;
                doc.Range().Text += data.Description;

                // save and close
                doc.SaveAs2(filePath);
                doc.Close();
                wordApp.Quit();
            }
            finally
            {
                ReleaseFileObject(doc);
                ReleaseFileObject(wordApp);
            }
        }
        public override void LaunchFile(string filePath)
        {
            Application wordApp = null;
            Document doc = null;

            // launch file
            wordApp = new Application();
            wordApp.Visible = true;
            doc = wordApp.Documents.Open(filePath);
        }
    }
}
