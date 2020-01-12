using PG5_DP_Factory.DocumentsOffice.FileHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_Factory.DocumentsOffice.HandlerFactory
{
    //'================================================================================================================
    //' CLASS NAME  : PresentationHandlerCreator
    //'               1. Class to return Handler.
    //'               2. Factory Method Pattern.
    //'               3. Skipped specific realization for option prameter.
    //'================================================================================================================
    public class PresentationHandlerCreator : IFileHandlerCreator
    {
        public FileHandler Create(string option)
        {
            var handler = new PresentationHandler();
            return handler;
        }
    }
}
