using PG5_DP_Deco.Writers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_Deco
{
    /* Note
     * Encoding.X.GetString() 에서 지원하는 Converting Method는 input array가 X type을 위해 유효하다고 가정한다.
     * 따라서 임의의 binary 데이터가 input값으로 들어올 경우, 데이터에 문제가 생길 수 있다.
     * 이번 Lab에서는 AES Key값을 byte[] <-> string 으로 변환하는 과정에서 데이터가 변경되는 에러가 있었다.
     * (string상으로는 같은 값임에도 불구하고..)
     */
    public class Program
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            string s = "Lorem Ipsum Lorem Ipsum Lorem Ipsum has been Lorem Ipsum Lorem Ipsum Lorem Ipsum Lorem Ipsum Lorem Ipsum Lorem Ipsum";
            byte[] data = Encoding.UTF8.GetBytes(s); 

            IWriter wr1 = new XCompressStream(new XEncryptStream(new XStream("1.txt")));
            wr1.WriteData(data);

            IWriter wr2 = new XCompressStream(new XStream("2.txt"));
            wr2.WriteData(data);

            IWriter wr3 = new XEncryptStream(new XStream("3.txt"));
            wr3.WriteData(data);
        }
    }
}
