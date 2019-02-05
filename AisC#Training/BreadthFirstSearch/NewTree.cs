using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreadthFirstSearch
{
    class NewTree
    {
        // set root of the Binary Tree 
        public NodeStructure root;

        public NewTree()
        {
            root = null;
        }
        //function  traverse  tree
        public virtual void Traversal()
        {
            int height = Height(root);
            int i;
            for (i = 1; i <= height; i++)
            {
                //calling traversal function for root at level i
                Traversal(root, i);
                Console.WriteLine("Value of root is " + root + " at level " + i);
            }
        }

        // Calculate  the height of a tree
        public virtual int Height(NodeStructure root)

        {
            if (root == null)
            {
                return 0;
            }
            else
            {
                //check the height of left hand side
                int lheight = Height(root.left);
                //check the height of right hand side
                int rheight = Height(root.right);

                // compare the left hand side height and right hand side height and return the height which is highest
                if (lheight > rheight)
                {
                    return (lheight);
                }
                else
                {
                    return (rheight);
                }
            }
        }

        //
        public virtual void Traversal(NodeStructure root, int level)
        {
            if (root == null)
            {
                return;
            }
            if (level == 1)
            {
                Console.Write(root.data + " ");
            }
            else if (level > 1)
            {
                Traversal(root.left, level - 1);
                Traversal(root.right, level - 1);
            }
        }
    }
}
