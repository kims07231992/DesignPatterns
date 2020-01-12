using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PG5_DP_Factory.DocumentsOffice.FileHandlers;

namespace PG5_DP_Factory.DocumentsOffice.HandlerFactory
{
    //'================================================================================================================
    //' CLASS NAME  : FileHandlerCreator
    //'               1. Class to return all kinds of handlers
    //'               2. Factory Method Pattern.
    //'================================================================================================================
    public class FileHandlerFactory : IFileHandlerCreator
    {
        public FileHandler Create(string fileName)
        {
            FileHandler handler = null;

            if (fileName.EndsWith(".doc") || fileName.EndsWith(".docx"))
            {
                handler = new WordHandler();
            }
            else if (fileName.EndsWith(".xls") || fileName.EndsWith(".xlsx"))
            {
                handler = new ExcelHandler();
            }
            else if (fileName.EndsWith(".pptx"))
            {
                handler = new PresentationHandler();
            }
            return handler;          
        }
    }
}
