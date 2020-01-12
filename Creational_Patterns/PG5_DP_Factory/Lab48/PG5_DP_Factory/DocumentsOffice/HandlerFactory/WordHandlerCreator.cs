using PG5_DP_Factory.DocumentsOffice.FileHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_Factory.DocumentsOffice.HandlerFactory
{
    //'================================================================================================================
    //' CLASS NAME  : WordHandlerCreator
    //'               1. Class to return Handler.
    //'               2. Factory Method Pattern.
    //'               3. Skipped specific realization for option prameter.
    //'================================================================================================================
    public class WordHandlerCreator : IFileHandlerCreator
    {
        public FileHandler Create(string option)
        {
            var handler = new WordHandler();
            return handler;
        }
    }
}
