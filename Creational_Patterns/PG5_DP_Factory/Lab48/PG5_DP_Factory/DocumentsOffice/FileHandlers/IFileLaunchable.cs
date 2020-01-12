using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_Factory.DocumentsOffice.FileHandlers
{
    //'================================================================================================================
    //' INTERFACE NAME  : IFileLaunchable
    //'               1. Interface for launchable operation.
    //'================================================================================================================
    public interface IFileLaunchable
    {
        void LaunchFile(string filePath);
    }
}
