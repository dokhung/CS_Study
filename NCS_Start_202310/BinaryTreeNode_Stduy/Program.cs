using System;
using System.Collections.Generic;

namespace BinaryTreeNode_Stduy
{
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
        public BinaryTreeNode<T> Root { get; set; }

        public BinaryTree(T rootdata)
        {
            Root = new BinaryTreeNode<T>(rootdata);
        }

        public void LevelOrder()
        {
            var queue = new Queue<BinaryTreeNode<T>>();
            queue.Enqueue(this.Root);

            while (queue.Count>0)
            {
                var node = queue.Dequeue();
                Console.WriteLine(node.Data);
                if (node.Left !=null)
                {
                    queue.Enqueue(node.Left);                    
                }

                if (node.Right != null)
                {
                    queue.Enqueue(node.Right);
                }
            }
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            BinaryTree<int> tree = new BinaryTree<int>(1);
            tree.Root.Left = new BinaryTreeNode<int>(2);
            tree.LevelOrder();
        }
    }
}