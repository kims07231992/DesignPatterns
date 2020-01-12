using PG5_DP_Factory.DocumentsOffice.FileHandlers;
using PG5_DP_Factory.DocumentsOffice.HandlerFactory;
using PG5_DP_Factory.DocumentsOffice.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PG5_DP_Factory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Run();
        }
        private static void Run()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources");

            // test creating files
            TestCreateFiles(path);

            // test launching files
            TestLaunchFiles(path);
        }

        private static void TestCreateFiles(string path)
        {
            var officeFiles = new string[] { "aa.doc", "bb.docx", "cc.xls", "dd.xlsx", "ee.pptx" };
            foreach (var fileName in officeFiles)
            {
                string filePath = Path.Combine(path, fileName);
                FileHandler handler = new FileHandlerFactory().Create(fileName);
                handler.CreateFile(filePath, new DocumentModel()
                {
                    Title = "title",
                    Description = "The more I lean,\n the more I realize \n how much I don't know."
                });
            }
        }
        private static void TestLaunchFiles(string path)
        {
            var officeFiles = new string[] { "a.doc", "b.docx", "c.xls", "d.xlsx", "e.pptx" };
            // set and launch files
            foreach (var fileName in officeFiles)
            {
                string filePath = Path.Combine(path, fileName);
                FileHandler handler = new FileHandlerFactory().Create(fileName);
                handler.LaunchFile(filePath);
            }
        }
    }
}
