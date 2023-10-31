using System;

namespace NrinkTreeNodeArr
{
    class TreeNode
    {
        public object Data { get; set; }
        public TreeNode[] Children { get; set; }

        public TreeNode(object data, int maxcount = 3)
        {
            Data = data;
            Children = new TreeNode[maxcount];
        }
    }
    internal class Program
    {
        // static void PrintTree(TreeNode _node)
        // {
        //     foreach (var VARIABLE in )
        //     {
        //         
        //     }
        // }

        public static void Main(string[] args)
        {
            var A = new TreeNode("A");
            foreach (var VARIABLE in A.Children)
            {
                Console.WriteLine(VARIABLE.Data);
            }
            
        }
    }
}