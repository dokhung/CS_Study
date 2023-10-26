using System;

class TreeNode
{ 
    public object Data { get; set; }
    public TreeNode[] Children { get; private set; }
    public TreeNode(object data, int maxcount = 3)
    {
        Data = data;
        Children = new TreeNode[maxcount];
    }
}    

class Program
{
    
    static void PrintTree(TreeNode _node)
    {
        
    }

    static void Main(string[] args)
    {
        var A = new TreeNode("A");
        var B = new TreeNode("B");
        var C = new TreeNode("C");
        var D = new TreeNode("D");
        A.Children[0] = B;
        A.Children[1] = C;
        A.Children[2] = D;

        B.Children[0] = new TreeNode("E");
        B.Children[1] = new TreeNode("F");

        D.Children[0] = new TreeNode("G");

        PrintTree(A); //전체 트리 출력하는 함수도 만들기
        //foreach (var item in A.Children)
        //{
        //    Console.WriteLine(item.Data);
        //}
    }
}