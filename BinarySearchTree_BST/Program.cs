using System;

namespace BinarySearchTree_BST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node Root = CreateTree();
            // Enter number =  56 30 0 0 70 0 0 as input to get required BST

            // Display in-Order Type BST
            Console.WriteLine("In-Order BST");
            Inorder(Root);
            Console.WriteLine("\n");

            // Display in-Order Type BST
            Console.WriteLine("Pre-Order BST");
            PreOrder(Root);
            Console.WriteLine("\n");

            // Display in-Order Type BST
            Console.WriteLine("Post-Order BST");
            PostOrder(Root);
            Console.WriteLine("\n");
        }

        // Creating node Class
        public class Node
        {
            public Node Right = null;
            public Node Left = null;
            public int Data;
            public Node(int Data)
            {
                this.Data = Data;
            }
        }

        // Creating Method for Inserting the element into the BST
        public static Node Insert(Node Root, int Val)
        {
            if (Root == null)
            {
                Root = new Node(Val);
                return Root;
            }
            if (Root.Data > Val)
            {
                Root.Left = Insert(Root.Left, Val);
            }
            else
            {
                Root.Right = Insert(Root.Right, Val);
            }
            return Root;
        }

        //Creating method for In-order type BST
        public static void Inorder(Node Root)
        {
            if (Root == null)
            {
                return;
            }
            Inorder(Root.Left);
            Console.Write(Root.Data + " ");
            Inorder(Root.Right);
        }

        //Creating method for Pre-order type BST
        public static void PreOrder(Node Root)
        {
            if (Root == null)
            {
                return;
            }
            Console.Write(Root.Data + " ");
            PreOrder(Root.Left);
            PreOrder(Root.Right);
        }

        //Creating method for Post-order type BST
        public static void PostOrder(Node Root)
        {
            if (Root == null)
            {
                return;
            }
            PostOrder(Root.Left);
            PostOrder(Root.Right);
            Console.Write(Root.Data + " ");
        }

        //Creating Method for Entering the data to Create BST 
        public static Node CreateTree()
        {
            Node Root = null;
            Console.WriteLine("Enter data: ");
            int data = int.Parse(Console.ReadLine());
            if (data == 0)
            {
                return null;
            }
            Root = new Node(data);
            Console.WriteLine("Enterc left for :" + data);
            Root.Left = CreateTree();

            Console.WriteLine("Enterc right for :" + data);
            Root.Right = CreateTree();
            return Root;
        }
    }
}
