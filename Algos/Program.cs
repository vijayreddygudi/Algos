using static System.Console;

namespace Algos
{
    class Program
    {
        static void Main(string[] args)
        {
            int levelCounter = 0;

            BTNode root = ConstructTree();
            BTNode current = root;
            while (true)
            {
                WriteLine(current.Data);
                levelCounter++;
                if (current.Left != null)
                {
                    current = current.Left;
                }
                else
                {
                    current = current.Right;
                }
                break;
            }
            levelCounter++;

        }

        private static BTNode ConstructTree()
        {
            BTNode root = new BTNode(5);

            BTNode two = new BTNode(2);
            BTNode ten = new BTNode(10);
            BTNode seven = new BTNode(7);

            root.Left = two;
            ten.Left = seven;
            root.Right = ten;

            return root;
        }

    }

    class BTNode
    {
        public int Data;
        public BTNode Left;
        public BTNode Right;
        public BTNode(int value)
        {
            Data = value;
        }
    }
}
