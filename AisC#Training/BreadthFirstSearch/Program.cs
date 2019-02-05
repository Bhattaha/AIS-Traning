using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreadthFirstSearch
{
    class Program
    {

        public static void Main(string[] args)
        {
            NewTree tree = new NewTree();

            tree.root = new NodeStructure(9);

            tree.root.left = new NodeStructure(6);
            tree.root.right = new NodeStructure(11);

            tree.root.left.left = new NodeStructure(2);
            tree.root.left.right = new NodeStructure(5);
            tree.root.right.left = new NodeStructure(15);
            tree.root.right.right = new NodeStructure(10);
            Console.WriteLine("Breadth first search of binary tree is :");
            tree.Traversal();

            Console.Read();
        }

        
    }
}
