using System;
using System.Collections.Generic;

namespace _20231026_1
{
    class TreeNode<T>
    {
        public T Data { get; set; }
        public List<TreeNode<T>> childeren { get; set; } = new List<TreeNode<T>>();
    }
    internal class Program
    {
        static void PrintTree(TreeNode<string> root)
        {
            Console.WriteLine(root.Data);
            Console.WriteLine("**********");
            foreach (var VARIABLE in root.childeren)
            {
                PrintTree(VARIABLE);
            }
            Console.WriteLine("**********");
        }
        public static void Main(string[] args)
        {
            TreeNode<string> root = new TreeNode<string>() { Data = "게임회사" };
            TreeNode<string> node = new TreeNode<string>() { Data = "개발팀" };
            node.childeren.Add(new TreeNode<string>() { Data = "컨텐츠 개발"});
            node.childeren.Add(new TreeNode<string>() { Data = "라이브 서비스"});
            node.childeren.Add(new TreeNode<string>() { Data = "툴 개발"});
            root.childeren.Add(node);

            node = new TreeNode<string>() { Data = "아트팀" };
            node.childeren.Add(new TreeNode<string>() {Data = "UI/UX"});
            node.childeren.Add(new TreeNode<string>() {Data = "배경"});
            node.childeren.Add(new TreeNode<string>() {Data = "U캐랙터/오브젝트"});
            root.childeren.Add(node);

            node = new TreeNode<string>() { Data = "기획팀" };
            node.childeren.Add(new TreeNode<string>() { Data = "스토리"});
            node.childeren.Add(new TreeNode<string>() { Data = "시스템"});
            node.childeren.Add(new TreeNode<string>() { Data = "컨텐츠"});
            root.childeren.Add(node);

            node = new TreeNode<string>() { Data = "QA" };
            root.childeren.Add(node);

            Console.WriteLine("설정한 트리 출력");
            Console.WriteLine(root.Data);
        }
    }
}