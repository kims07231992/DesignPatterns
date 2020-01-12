using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using PG5_DP_Factory.DocumentsOffice.Model;

namespace PG5_DP_Factory.DocumentsOffice.FileHandlers
{
    //'================================================================================================================
    //' CLASS NAME  : FileHandler
    //'               1. Class for writable and launchable operation. 
    //'               2. Implemented several interface for Interface Segregation Principle(ISP).
    //'               3. did not make is as an interface due to shared method, ReleaseFileObject().
    //'================================================================================================================
    public abstract class FileHandler : IFileLaunchable, IFileCreatable
    {
        public abstract void CreateFile(string filePath, DocumentModel data);
        public abstract void LaunchFile(string filePath);
        protected static void ReleaseFileObject(object obj) // to clean up background file.exe
        {
            try
            {
                if (obj != null)
                {
                    Marshal.ReleaseComObject(obj);
                    obj = null;
                }
            }
            catch (Exception ex)
            {
                obj = null;
                throw ex;
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
