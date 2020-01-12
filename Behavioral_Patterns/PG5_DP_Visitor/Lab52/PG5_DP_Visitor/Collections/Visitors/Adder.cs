using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_Visitor.Collections.Visitors
{
    public class Adder : Calculator
    {
        public override void Visit(BinaryTreeNode node)
        {
            if (isMultiplesOfThree(node.Data))
            {
                node.Data++;
            }
        }
    }
}
