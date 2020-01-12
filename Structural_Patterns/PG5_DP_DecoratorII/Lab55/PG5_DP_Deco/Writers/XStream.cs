using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_Deco.Writers
{
    public class XStream : IWriter
    {
        private string _path;

        public XStream(string fileName)
        {
            this._path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
        }

        public void WriteData(byte[] data)
        {
            using (FileStream fs = File.Open(this._path, FileMode.Create))
            {
                using (BinaryWriter wr = new BinaryWriter(fs))
                {
                    wr.Write(data);
                }
            }
        }
    }
}
