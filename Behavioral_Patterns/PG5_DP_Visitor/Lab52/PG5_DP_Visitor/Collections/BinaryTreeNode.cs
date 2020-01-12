using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_Visitor.Collections
{
    public class BinaryTreeNode
    {
        public BinaryTreeNode(int data)
        {
            this.Data = data;
        }

        public BinaryTreeNode Left { get; set; } = null;
        public BinaryTreeNode Right { get; set; } = null;
        public int Data { get; set; }
    }
}
