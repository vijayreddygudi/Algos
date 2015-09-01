using System.Collections.Generic;
using static System.Console;

namespace LeftViewOfBTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BTNode root = ConstructTree();
            PrintLeftview(root);
            ReadLine();
        }

        private static void PrintLeftview(BTNode root)
        {
            Queue<BTNode> nodes = new Queue<BTNode>();

            BTNode current = root;

            while (current != null)
            {

                if (current.LeftNode != null)
                {
                    nodes.Enqueue(current.LeftNode);
                }

                if (current.RightNode != null)
                {
                    nodes.Enqueue(root.RightNode);
                }

                WriteLine(current.Data);
                current = current.LeftNode ?? current.RightNode;
            }
            //


        }

        private static BTNode ConstructTree()
        {
            BTNode root = new BTNode(1);
            BTNode two = new BTNode(2);
            BTNode three = new BTNode(3);
            BTNode four = new BTNode(4);
            BTNode five = new BTNode(5);
            BTNode six = new BTNode(6);
            BTNode seven = new BTNode(7);
            root.LeftNode = two;
            root.RightNode = three;
            two.LeftNode = four;
            two.RightNode = five;
            three.LeftNode = six;
            three.RightNode = seven;

            return root;
        }
    }
    internal class BTNode
    {
        public int Data;
        public BTNode LeftNode;
        public BTNode RightNode;

        public BTNode(int data)
        {
            Data = data;
        }
    }
}
