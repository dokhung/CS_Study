﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace _20231026_3
{
    class LCRSNode
    {
        public object Data { get; set; }
        public LCRSNode LeftChild { get; set; }
        public LCRSNode RightSibling { get; set; }

        public LCRSNode(object data)
        {
            Data = data;
        }
    }

    class LCRSTree
    {
        public LCRSNode Root { get; private set; }

        public LCRSTree(object rootData)
        {
            Root = new LCRSNode(rootData);
        }

        public LCRSNode AddChild(LCRSNode parent/* 부모로 삼고 싶은, 이미 존재하는 노드*/, object data/*자식으로 넣고 싶은 데이터*/) // 이 트리의 (무언가의) 자식으로 넣고 싶음
        {
            if (parent == null)
            {
                return null;
            }

            LCRSNode child = new LCRSNode(data);
            if (parent.LeftChild == null) // 부모로 삼고자 했던 친구의 자식이 없다면
            {
                parent.LeftChild = child;
            }
            else // 내가 자식으로 들어가고 싶은 부모의 자식이 이미 있다면
            {
                LCRSNode node = parent.LeftChild;
                while (node.RightSibling != null)
                {
                    node = node.RightSibling;
                }

                node.RightSibling = child;
            }

            return child;
        }

        public LCRSNode AddSibling(LCRSNode node, object data)
        {
            if (node == null)
            {
                return null;
            }

            LCRSNode sibling = new LCRSNode(data); // 내가 형제로 넣고 싶은 데이터 실체화 함...

            if (node.RightSibling == null)
            {
                node.RightSibling = sibling;
            }
            else // 만약 이미 형제가 있다면?
            {
                while (node.RightSibling != null)
                {
                    node = node.RightSibling;
                }

                node.RightSibling = sibling;
            }

            return sibling;
        }

        public void PrintTree()
        {
            Queue<LCRSNode> nodequeue = new Queue<LCRSNode>();
            nodequeue.Enqueue(this.Root); // 부모를 일단 큐에 넣음
            
            while (nodequeue.Count > 0) // nodequeue가 존재한다면 계속 돌것임
            {
                LCRSNode node = nodequeue.Dequeue();
                while (node !=null)
                {
                    Console.WriteLine(node.Data); // 해당 노드 데이터 출력
                    if (node.LeftChild != null)
                    {
                        nodequeue.Enqueue(node.LeftChild); // 자식도 확인하기 위해서 큐에 담아둠...
                    }

                    node = node.RightSibling;
                }
            }
        }
        
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            var A = new LCRSNode("A");
            var B = new LCRSNode("B");
            var C = new LCRSNode("C");
            var D = new LCRSNode("D");
            var E = new LCRSNode("E");
            var F = new LCRSNode("F");
            var G = new LCRSNode("G");

            A.LeftChild = B;
            B.RightSibling = C;
            C.RightSibling = D;
            

            B.LeftChild = E;
            E.RightSibling = F;
            
            D.LeftChild = G;

            if (A.LeftChild != null)
            {
                var tmp = A.LeftChild;
                Console.WriteLine(tmp.Data);
                while (tmp.RightSibling != null)
                {
                    tmp = tmp.RightSibling;
                    Console.WriteLine(tmp.Data);
                }
                
            }
        }
    }
}