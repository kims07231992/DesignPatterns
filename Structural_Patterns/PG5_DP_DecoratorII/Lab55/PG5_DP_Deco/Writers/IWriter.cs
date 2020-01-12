using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_Deco.Writers
{
    public interface IWriter
    {
        void WriteData(byte[] data);
    }
}
