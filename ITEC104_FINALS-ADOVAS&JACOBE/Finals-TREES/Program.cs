using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finals_TREES
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prog = new Program();
            int n, num;
            Console.WriteLine("Enter how many numbers to be input");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter " + input + "numbers : ");
            for (int i = 0; i < input; i++)
            {
                num = Convert.ToInt32(Console.ReadLine());
                prog.insertTotree(num);
            }
            Console.WriteLine("Tree Insertion Done Successfully!");

            Console.WriteLine("Enter number to be searched");
            input = Convert.ToInt32(Console.ReadLine());
            if (prog.searchTree(input) != null)
            {
                Console.WriteLine("Number Found!");
            }
            else
            {
                Console.WriteLine("Number not Found.");
            }

            Console.WriteLine("Inorder traversal of binary search tree");
            prog.inOrderTraversal();

            Console.WriteLine("\nPre-order traversal of binary search tree");
            prog.preOrderTraversal();

            Console.WriteLine("\nPost-order traversal of binary search tree");
            prog.postOrderTraversal();
        }
        public class TreeNode
        {
            public int data;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int data)
            {
                this.data = data;
                this.left = this.right = null;
            }
        }

        TreeNode root;

        Program()
        {
            root = null;
        }

        public TreeNode insert(TreeNode root, int dataToBeinserted)
        {
            if (root == null)
            {
                root = new TreeNode(dataToBeinserted);
                return root;
            }
            if (root.data > dataToBeinserted)
            {
                root.left = insert(root.left, dataToBeinserted);
            }
            else if (root.data > dataToBeinserted)
            {
                root.right = insert(root.right, dataToBeinserted);
            }
            return root;
        }

        public TreeNode search(TreeNode root, int dataToBeInserted)
        {
            if (root == null || root.data == dataToBeInserted)
                return root;

            if (root.data > dataToBeInserted)
                return insert(root.left, dataToBeInserted);

            //else
            return insert(root.right, dataToBeInserted);
        }


        public void inOrder(TreeNode root)
        {
           
                if (root == null)
                    return;
                inOrder(root.left);
                Console.WriteLine(root.data + " ");
                inOrder(root.right);
            
      
        }
        public void preOrder(TreeNode root)
        {
            if (root == null)
                return;
            Console.WriteLine(root.data + " ");
            inOrder(root.left);
            inOrder(root.right);
        }
        public void postOrder(TreeNode root)
        {
            if (root == null)
                return;
            Console.WriteLine(root.data + " ");
            inOrder(root.left);
            inOrder(root.right);
            Console.WriteLine(root.data + " ");
        }

        public void insertTotree(int dataToBeInserted)
        {
            root = insert(root, dataToBeInserted);
        }

        public TreeNode searchTree(int dataToBeInserted)
        {
            return insert(root, dataToBeInserted);
        }
        public void inOrderTraversal()
        {
            inOrder(root);
        }

        public void preOrderTraversal()
        {
            preOrder(root);
        }

        public void postOrderTraversal()
        {
            postOrder(root);
        }


    }
}