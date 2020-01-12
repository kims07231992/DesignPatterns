using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_Deco.Writers
{
    public class XCompressStream : IWriter
    {
        private static int BUFFER_SIZE = 64 * 1024; // 64kB

        private IWriter _writer;

        public XCompressStream(IWriter writer)
        {
            this._writer = writer;
        }

        public void WriteData(byte[] data)
        {
            var compressedData = Compress(data);
            this._writer.WriteData(compressedData);
        }

        private static byte[] Compress(byte[] inputData)
        {
            using (var compressIntoMs = new MemoryStream())
            {
                using (var gzs = new BufferedStream(new GZipStream(compressIntoMs,
                    CompressionMode.Compress), BUFFER_SIZE))
                {
                    gzs.Write(inputData, 0, inputData.Length);
                }
                return compressIntoMs.ToArray();
            }
        }
    }
}
