using System;

namespace BinaryTreeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<Human> binaryTree = new BinaryTree<Human>();

            binaryTree.Add(new Human(10));
            binaryTree.Add(new Human(4));
            binaryTree.Add(new Human(22));
            binaryTree.Add(new Human(8));
            binaryTree.Add(new Human(7));
            binaryTree.Add(new Human(9));
            binaryTree.Add(new Human(15));
            binaryTree.Add(new Human(31));
            
            //Console.WriteLine(binaryTree.Contains(new Human(31)));
            
            Console.WriteLine("FOREACH OUTPUT:");
            foreach (Human x in binaryTree)
            {
                Console.WriteLine(x.GetAge());
            }
            
            /*Console.WriteLine("TOSTRING OUTPUT:");
            Console.WriteLine(binaryTree);*/
        }
    }
}