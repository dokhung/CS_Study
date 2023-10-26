using System;
using System.Collections.Generic;

 class BinaryTreeNode<T>
    { 
        public T Data { get; set; }
        public BinaryTreeNode<T> Left { get; set; }
        public BinaryTreeNode<T> Right { get; set; }
        public BinaryTreeNode(T data)
        {
            Data = data;
        }
    }

    class BinaryTree<T>
    { 
        public BinaryTreeNode<T> Root { get; private set; }
        public BinaryTree(T rootdata)
        {
            Root = new BinaryTreeNode<T>(rootdata);
        }

        public void PreOrderTraversal(BinaryTreeNode<T> node) //전위 순회
        {
            if (node == null)
                return;

            Console.WriteLine(node.Data);
            PreOrderTraversal(node.Left);
            PreOrderTraversal(node.Right);
        }
        public void InOrderTraversal(BinaryTreeNode<T> node) //중위 순회
        {
            if (node == null)
                return;

            InOrderTraversal(node.Left);
            Console.WriteLine(node.Data);
            InOrderTraversal(node.Right);
        }
        public void PostOrderTraversal(BinaryTreeNode<T> node) //후위 순회
        {
            if (node == null)
                return;

            PostOrderTraversal(node.Left);
            PostOrderTraversal(node.Right);
            Console.WriteLine(node.Data);                         
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> tree = new BinaryTree<int>(1);
            tree.Root.Left = new BinaryTreeNode<int>(2);
            tree.Root.Right = new BinaryTreeNode<int>(3);

            tree.Root.Left.Left = new BinaryTreeNode<int>(4);
            tree.Root.Right.Right = new BinaryTreeNode<int>(5);

            Console.WriteLine("전위 순회");
            tree.PreOrderTraversal(tree.Root);

            Console.WriteLine();

            Console.WriteLine("중위 순회");
            tree.InOrderTraversal(tree.Root);
            
            Console.WriteLine();

            Console.WriteLine("후위 순회");
            tree.PostOrderTraversal(tree.Root);
        }
    }
    
    /*
     *public void PreOrderIterate() //전위 반복 순회
        {
            if (Root == null)
            {
                return;
            }

            Stack<BinaryTreeNode<T>> stack = new Stack<BinaryTreeNode<T>>();
            stack.Push(Root); //시작이될 루트 저장

            while (stack.Count > 0) 
            {
                var node = stack.Pop();
                Console.WriteLine(node.Data);

                if (node.Right !=null) //오른쪽 노드가 있으면
                {
                    stack.Push(node.Right); 
                }

                if (node.Left !=null)
                {
                    stack.Push(node.Left);
                }
            }
        }
     * 
     */