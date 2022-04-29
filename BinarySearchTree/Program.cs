using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var tree = new Tree<int>();

            tree.Add(9);
            tree.Add(12);
            tree.Add(10);
            tree.Add(5);
            tree.Add(3);
            tree.Add(6);
            tree.Add(7);
            tree.Add(8);
            tree.Add(2);
            tree.Add(117);
            tree.Add(15);
            tree.Add(20);

            Console.WriteLine("Tree count: " + tree.Count);
            Console.WriteLine();

            var Preorder = tree.Preorder();
            var Postorder = tree.Postorder();
            var Inorder = tree.Inorder();

            foreach (var item in Preorder)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();

            foreach (var item in Postorder)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();

            foreach (var item in Inorder)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();


            Console.ReadLine();

        }
    }
}
