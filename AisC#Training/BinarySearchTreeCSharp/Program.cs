using System;


namespace BinarySearchTreeCSharp
{
    //node class with  left child and right child
    class Node
    {
        public int value;
        public Node left;
        public Node right;
    }

    class Tree
    {
        //insert values into tree
        public Node Insert(Node root, int value)
        {
            if (root == null)
            {
                root = new Node();
                root.value = value;
            }
            else if (value < root.value)
            {
                root.left = Insert(root.left, value);
            }
            else
            {
                root.right = Insert(root.right, value);
            }

            return root;
        }
        //inorder traversal
        public void InOrderTraverse(Node root)
        {
            if (root == null)
            {
                return;
            }

            InOrderTraverse(root.left);
           
            Console.Write(root.value + " ");
            InOrderTraverse(root.right);
        }
        //preorder traversal
        public void PreorderTraverse(Node root)
        {
            if (root == null)
            {
                return;
            }
            
            Console.Write(root.value + " ");
            PreorderTraverse(root.left);
            PreorderTraverse(root.right);
        }
        //postorder traversal
        public void PostOrderTraverse(Node root)
        {
             if (root == null)
             {
                return;
             }

            PostOrderTraverse(root.left);
            PostOrderTraverse(root.right);
            
            Console.Write(root.value + " ");
        }
        // Driver Code 
        static public void Main(String[] args)
        {
            Node root = null;
            Tree tree = new Tree();
            //insert values into the tree
            root = tree.Insert(root, 19);
            root = tree.Insert(root, 3);
            root = tree.Insert(root, 27);
            root = tree.Insert(root, 7);
            root = tree.Insert(root, 47);
            root = tree.Insert(root, 14);
            Console.WriteLine("The in order traversal");
            tree.InOrderTraverse(root);
            Console.WriteLine("\nThe pre order traversal");
            tree.PreorderTraverse(root);
            Console.WriteLine("\nThe post order traversal");
            tree.PostOrderTraverse(root);
            Console.Read();
        }
    }
}
