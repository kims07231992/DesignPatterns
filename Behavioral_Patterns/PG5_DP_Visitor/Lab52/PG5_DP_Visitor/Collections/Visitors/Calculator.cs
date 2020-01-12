using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_Visitor.Collections.Visitors
{
    public abstract class Calculator : IVisitor
    {
        protected Predicate<int> IsMultiplesOfThree = s => (s % 3 == 0);
        protected Predicate<int> IsEven = s => ((s & 1) == 0);

        public abstract void Visit(BinaryTreeNode node);
    }
}
