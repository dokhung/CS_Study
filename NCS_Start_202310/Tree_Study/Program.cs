using System;
using System.Collections.Generic;

namespace Tree_Study
{
    class TreeNode<T> // 기본 트리
    {
        public T Data { get; set; }
        public List<TreeNode<T>> Childeren { get; set; } = new List<TreeNode<T>>();
    }
    internal class Program
    {
        static void PrintTree(TreeNode<string> root)
        {
            Console.WriteLine(root.Data); // My Data
            Console.WriteLine("=======");
            foreach (var VARIABLE in root.Childeren)
            {
                PrintTree(VARIABLE);
            }
            Console.WriteLine("=======");
        }
        public static void Main(string[] args)
        {
            TreeNode<string> root = new TreeNode<string>() { Data = "GameCompany" };
            TreeNode<string> node = new TreeNode<string>() { Data = "Context" };
            node.Childeren.Add(new TreeNode<string>() { Data = "Rive"});
            root.Childeren.Add(node);
            PrintTree(root);

        }
    }
}