using PG5_DP_Iterator.X;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_Iterator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Run();
        }
        public static void Run()
        {
            XCollection coll = new XCollection();
            coll.Add("A");
            coll.Add("B");
            coll.Add("C");
            coll.Add("D");
            coll.Add("E");

            IXIterator it = coll.GetIterator();
            object o;
            while ((o = it.Next()) != null)
            {
                Console.WriteLine(o);
            }

            // 출력 : A C E  (0, 2, 4 등 짝수만 출력함) 
        }
    }
}
