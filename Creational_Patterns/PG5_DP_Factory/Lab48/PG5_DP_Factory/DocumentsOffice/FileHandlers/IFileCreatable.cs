using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PG5_DP_Factory.DocumentsOffice.Model;

namespace PG5_DP_Factory.DocumentsOffice.FileHandlers
{
    //'================================================================================================================
    //' INTERFACE NAME  : IFileCreatable
    //'               1. Interface for creatable operation.
    //'================================================================================================================
    public interface IFileCreatable
    {
        void CreateFile(string filePath, DocumentModel data);
    }
}
