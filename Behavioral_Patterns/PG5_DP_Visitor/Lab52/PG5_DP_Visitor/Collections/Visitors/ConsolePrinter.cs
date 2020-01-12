using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_Visitor.Collections.Visitors
{
    public class ConsolePrinter : Calculator
    {
        public override void Visit(BinaryTreeNode node)
        {
            if (isEven(node.Data))
            {
                Console.WriteLine($"{node.Data}");
            }
        }
    }
}
