using PG5_DP_Visitor.Collections.Visitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_Visitor.Collections
{
    public class BinaryTreeCollection
    {
        public BinaryTreeNode Root { get; set; } = null;

        public bool IsEmpty()
        {
            return this.Root == null ? true : false;
        }

        public void AcceptPreOrder(IVisitor visitor)
        {
            PreOrderRecursive(this.Root, visitor.Visit);
        }

        public void DisplayPreOrder()
        {
            PreOrderRecursive(this.Root, s => Console.WriteLine($"{s.Data}"));
        }

        private void PreOrderRecursive(BinaryTreeNode node, Action<BinaryTreeNode> doSomething)
        {
            if (node == null)
            {
                return;
            }
            else
            {
                doSomething(node);
                PreOrderRecursive(node.Left, doSomething);
                PreOrderRecursive(node.Right, doSomething);
            }
        }
    }
}
