using PG5_DP_Visitor.Collections;
using PG5_DP_Visitor.Collections.Visitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_Visitor
{
    public class Program
    {
        private static BinaryTreeCollection  _collection = new BinaryTreeCollection();

        public static void Main(string[] args)
        {
            Run();
        }

        private static void Run()
        {
            SetCollection();
            
            // test, please pick one
            //TestNodeAdder();
            //TestConsolePrinter();
        }
        
        private static void SetCollection()
        {
            _collection.Root = new BinaryTreeNode(1);
            _collection.Root.Left = new BinaryTreeNode(2);
            _collection.Root.Right = new BinaryTreeNode(3);
            _collection.Root.Left.Left = new BinaryTreeNode(4);
            _collection.Root.Left.Right = new BinaryTreeNode(5);
            _collection.Root.Right.Left = new BinaryTreeNode(6);
            _collection.Root.Right.Right = new BinaryTreeNode(7);
            _collection.Root.Left.Left.Left = new BinaryTreeNode(8);
            _collection.Root.Left.Left.Right = new BinaryTreeNode(9);
            _collection.Root.Right.Left.Left = new BinaryTreeNode(10);
            _collection.Root.Right.Left.Right = new BinaryTreeNode(11);
            _collection.Root.Left.Right.Left = new BinaryTreeNode(12);
            _collection.Root.Left.Right.Right = new BinaryTreeNode(13);
            _collection.Root.Left.Left.Left.Left = new BinaryTreeNode(14);
            _collection.Root.Left.Left.Left.Right = new BinaryTreeNode(15);
            _collection.Root.Left.Left.Right.Left = new BinaryTreeNode(16);
            _collection.Root.Left.Left.Right.Right = new BinaryTreeNode(17);
            _collection.Root.Left.Left.Right.Left.Left = new BinaryTreeNode(18);
            _collection.Root.Left.Left.Right.Left.Right = new BinaryTreeNode(19);
            _collection.Root.Left.Left.Left.Left.Left = new BinaryTreeNode(20);
        }

        private static void TestNodeAdder()
        {
            _collection.AcceptPreOrder(new Adder());
            _collection.DisplayPreOrder();
        }
        private static void TestConsolePrinter()
        {
            _collection.AcceptPreOrder(new ConsolePrinter());
        }
    }
}
