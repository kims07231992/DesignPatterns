using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PG5_DP_Factory.DocumentsOffice.FileHandlers;

namespace PG5_DP_Factory.DocumentsOffice.HandlerFactory
{
    //'================================================================================================================
    //' INTERFACE NAME  : IFileHandlerCreator
    //'               1. Interface to return Handler.
    //'               2. Factory Method Pattern.
    //'================================================================================================================
    public interface IFileHandlerCreator
    {
        FileHandler Create(string option);
    }
}
