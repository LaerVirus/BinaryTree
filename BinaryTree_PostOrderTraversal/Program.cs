using System;

namespace BinaryTree_PostOrderTraversal
{
    public static class Program
    {
        static BinaryTree binaryTree = new BinaryTree();

        public static void Main(string[] args)
        {
            Console.WriteLine(Messages.NumberOfNodes);

            int nodeNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(Messages.Nodes);

            for (int i = 0; i < nodeNumber; i++)
            {
                binaryTree.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine(Messages.CreatedTree);
            binaryTree.PrintAsTree();
            Console.WriteLine(Messages.PostOrderTraversal);
            BinaryTreeConsole.PrintToConsole(binaryTree);
        }
    }

    public struct Messages
    {
        public const string NumberOfNodes = "Количество вершин:";
        public const string Nodes = "Вершины:";
        public const string CreatedTree = "Готовое дерево";
        public const string PostOrderTraversal = "Обратный обход:";
    }
}
