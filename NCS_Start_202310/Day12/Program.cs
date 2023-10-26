using System;
using System.Collections.Generic;

namespace NCS_Start_202310
{
    #region 그래프
    public class Node<T> //트리의 요소인 정점의 가장 기본적 구조
    {
        public T Data { get; set; }
        public List<Node<T>> Neighbor { get; set; } = new List<Node<T>>();
        public List<int> Weight { get; set; } = new List<int>();
        public Node(T data)
        {
            Data = data;
        }
    }

    public class Graph<T>
    {
        int[,] mat; //행렬의 크기는 size*size가 될것임...

        int[,] aa = {   { 0, 0, 0, 0 },
                        { 0, 0, 0, 0 },
                        { 0, 0, 0, 0 },
                        { 0, 0, 0, 0 },
        };
        int size; //4

        List<Node<T>> nodes = new List<Node<T>>();
        bool directGraph = false; //기본적으로 무방향인데, 방향성을 가진다면 요거 체크...

        public Graph(bool direction = false)
        {
            this.directGraph = direction;
        }

        public Node<T> AddVertex(T data)
        {
            return AddVertex(new Node<T>(data));
        }

        public Node<T> AddVertex(Node<T> node)
        {
            nodes.Add(node);
            return node;
        }

        public void AddEdge(Node<T> from, Node<T> to, int weight = 1)
        {
            from.Neighbor.Add(to);
            from.Weight.Add(weight);
            if (directGraph == false)
            {
                to.Neighbor.Add(from);
                to.Weight.Add(weight);
            }
        }

        public void PrintGraph()
        {
            foreach (var item in nodes)
            {
                int cnt = item.Neighbor.Count;
                for (int i = 0; i < cnt; i++)
                {
                    Console.WriteLine($"{item.Data} ㅡ ({item.Weight[i]}) ㅡ {item.Neighbor[i].Data}");
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Graph<string> graph = new Graph<string>();
            var gr1 = graph.AddVertex("아파트 1동");
            var gr2 = graph.AddVertex("아파트 2동");
            var gr3 = graph.AddVertex("아파트 3동");
            var gr4 = graph.AddVertex("아파트 4동");

            graph.AddEdge(gr1, gr2, 1);
            graph.AddEdge(gr1, gr3, 2);
            graph.AddEdge(gr2, gr4, 6);
            graph.AddEdge(gr3, gr4, 9);

            graph.PrintGraph();
        }
    }

    #endregion

    #region SortedList 
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        SortedList<int, string> sortlist = new SortedList<int, string>();
    //        sortlist.Add(0, "안녕1");
    //        sortlist.Add(3, "안녕2");
    //        sortlist.Add(10, "안녕3");
    //        sortlist.Add(7, "안녕4");
    //        sortlist.Add(2, "안녕5");
    //        sortlist[1] = "안녕6";
    //        sortlist[6] = "안녕7";
    //        sortlist[6] = "안녕777777";            

    //        foreach (var item in sortlist)
    //        {
    //            Console.WriteLine($"{item.Key} , {item.Value}");
    //        }

    //        Console.WriteLine("\n삭제 진행 \n");
    //        sortlist.Remove(3);
    //        sortlist.Remove(7);
    //        foreach (var item in sortlist)
    //        {
    //            Console.WriteLine($"{item.Key} , {item.Value}");
    //        }
    //    }
    //}
    #endregion
    #region 이진탐색트리
    //public class BinaryTreeNode<T>
    //{
    //    public T Data { get; set; }
    //    public BinaryTreeNode<T> Left { get; set; }
    //    public BinaryTreeNode<T> Right { get; set; }
    //    public BinaryTreeNode(T data)
    //    {
    //        Data = data;
    //    }
    //}

    //public class BinarySearchTree<T>
    //{
    //    public BinaryTreeNode<T> Root { get; set; } = null;
    //    Comparer<T> comparer = Comparer<T>.Default;

    //    public void Insert(T val)
    //    {
    //        BinaryTreeNode<T> node = Root;
    //        if (Root == null)
    //        {
    //            Root = new BinaryTreeNode<T>(val);
    //            return;
    //        }
    //        while (node !=null)
    //        {
    //            int result = comparer.Compare(node.Data, val);
    //            if ( result ==0)
    //            {
    //                Console.WriteLine("두개의 값이 같음...");
    //                return;
    //            }
    //            else if (result < 0)// -1
    //            {
    //                if (node.Left == null)
    //                {
    //                    node.Left = new BinaryTreeNode<T>(val);
    //                    return;
    //                }
    //                node = node.Left;
    //            }
    //            else // result == 1 /val이 node.Data보다 큰 경우
    //            {
    //                if (node.Right == null)
    //                {
    //                    node.Right = new BinaryTreeNode<T>(val);
    //                    return;
    //                }
    //                node = node.Right;
    //            }
    //        }
    //    }

    //    public bool SearchValue(T val)
    //    {
    //        var node = Root;
    //        while (node !=null)
    //        {
    //            int result = comparer.Compare(node.Data, val);
    //            if (result == 0)
    //            {
    //                return true;
    //            }
    //            else if (result < 0)
    //            {
    //                node = node.Left;
    //            }
    //            else //result > 0
    //            {
    //                node = node.Right;
    //            }
    //        }
    //        return false;
    //    }

    //    public bool RemoveValue(T val)
    //    {
    //        var node = Root;
    //        BinaryTreeNode<T> prev = null;
    //        while (node !=null)
    //        {
    //            int result = comparer.Compare(node.Data, val);
    //            if (result ==0)
    //            {
    //                break;
    //            }
    //            else if (result < 0)
    //            {
    //                prev = node;
    //                node = node.Left;
    //            }
    //            else //result > 0
    //            {
    //                prev = node;
    //                node = node.Right;
    //            }
    //        }
    //        if (node == null)
    //        {
    //            return false;
    //        }

    //        if (node.Left == null && node.Right == null) //삭제하려는 대상이 자식노드가 전혀 없다면..
    //        {
    //            if (prev.Left == node)
    //            {
    //                prev.Left = null;
    //            }
    //            else
    //            {
    //                prev.Right = null;
    //            }
    //            node = null;
    //        }
    //        else if(node.Left == null || node.Right == null) //자식 노드가 1개일 경우
    //        {
    //            var child = node.Left != null ? node.Left : node.Right;
    //            if (prev.Left == node)
    //            {
    //                prev.Left = child;
    //            }
    //            else
    //            {
    //                prev.Right = child;
    //            }
    //            node = null;
    //        }
    //        else //자식노드가 2개일 경우
    //        {
    //            var pre = node;
    //            var preRight = node.Right;
    //            while (preRight.Left !=null)
    //            {
    //                pre = preRight;
    //                preRight = preRight.Left;
    //            }
    //            node.Data = preRight.Data; //없앨 노드.. 그자리에 (없앨노드)의 오른쪽 노드로 채워두고

    //            if (pre.Left == preRight)
    //            {
    //                pre.Left = preRight.Right;
    //            }
    //            else
    //            {
    //                pre.Right = preRight.Right;
    //            }
    //        }
    //        return true;
    //    }

    //    public void PreOrderTraversal(BinaryTreeNode<T> node) //전위 순회
    //    {
    //        if (node == null)
    //            return;

    //        Console.WriteLine(node.Data);
    //        PreOrderTraversal(node.Left);
    //        PreOrderTraversal(node.Right);
    //    }
    //}


    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        BinarySearchTree<int> tree = new BinarySearchTree<int>();

    //        //숫자 값은 1이상 20이하의 값중에 뽑도록한다....
    //        Random random = new Random();
    //        //List<int> list = new List<int>(); 
    //        ////겹치지 않게 랜덤수 7개 뽑기... 트리랑은 상관없음... 이런거 꽤 자주 할 확률이 커서 지금 해봅시다
    //        //int a = 0;
    //        ////while (list.Count < 7)            
    //        //for (int i = 0; i < 7; /*i++*/)
    //        //{
    //        //    a = random.Next(1,21); //1이상 21 미만의 값을 뽑음
    //        //    if (list.Contains(a) == false)
    //        //    {
    //        //        list.Add(a);
    //        //        Console.WriteLine(a);
    //        //        i++;
    //        //    }
    //        //    else
    //        //    {
    //        //        continue;
    //        //    }
    //        //}

    //        List<int> list = new List<int>();
    //        for (int i = 1; i <= 20; i++)
    //        {
    //            list.Add(i);
    //        }
    //        //list == 1부터 20까지 들은 리스트를 확보.

    //        int rand = 0;
    //        for (int i = 0; i < 7; i++)
    //        {
    //            rand = random.Next(0, list.Count);
    //            Console.WriteLine(list[ rand ] );
    //            tree.Insert(list[rand]); //겹치지않는 수를 tree에 7번 더할 수 있음.
    //            list.RemoveAt(rand);
    //        }

    //        tree.PreOrderTraversal(tree.Root); //보기..
    //    }
    //}

    #endregion
    #region 레벨순서순회
    //class BinaryTreeNode<T>
    //{
    //    public T Data { get; set; }
    //    public BinaryTreeNode<T> Left { get; set; }
    //    public BinaryTreeNode<T> Right { get; set; }
    //    public BinaryTreeNode(T data)
    //    {
    //        Data = data;
    //    }
    //}

    //class BinaryTree<T>
    //{
    //    public BinaryTreeNode<T> Root { get; private set; }
    //    public BinaryTree(T rootdata)
    //    {
    //        Root = new BinaryTreeNode<T>(rootdata);
    //    }

    //    public void LevelOrder()
    //    {
    //        var queue = new Queue<BinaryTreeNode<T>>();
    //        queue.Enqueue(this.Root);

    //        while (queue.Count>0)
    //        {
    //            var node = queue.Dequeue();
    //            Console.WriteLine(node.Data);
    //            if (node.Left !=null)
    //            {
    //                queue.Enqueue(node.Left);
    //            }
    //            if (node.Right != null)
    //            {
    //                queue.Enqueue(node.Right);
    //            }
    //        }
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        BinaryTree<int> tree = new BinaryTree<int>(1);
    //        tree.Root.Left = new BinaryTreeNode<int>(2);
    //        tree.Root.Right = new BinaryTreeNode<int>(3);

    //        tree.Root.Left.Left = new BinaryTreeNode<int>(4);
    //        tree.Root.Right.Right = new BinaryTreeNode<int>(5);

    //        tree.LevelOrder();
    //    }
    //}
    #endregion

    #region 이진트리 stack사용...
    //class BinaryTreeNode<T>
    //{
    //    public T Data { get; set; }
    //    public BinaryTreeNode<T> Left { get; set; }
    //    public BinaryTreeNode<T> Right { get; set; }
    //    public BinaryTreeNode(T data)
    //    {
    //        Data = data;
    //    }
    //}

    //class BinaryTree<T>
    //{
    //    public BinaryTreeNode<T> Root { get; private set; }
    //    public BinaryTree(T rootdata)
    //    {
    //        Root = new BinaryTreeNode<T>(rootdata);
    //    }

    //    public void PreOrderIterate() //전위 반복 순회
    //    {
    //        if (Root == null)            
    //            return;            

    //        Stack<BinaryTreeNode<T>> stack = new Stack<BinaryTreeNode<T>>();
    //        stack.Push(Root); //시작이될 루트 저장

    //        while (stack.Count > 0) 
    //        {
    //            var node = stack.Pop();
    //            Console.WriteLine(node.Data);

    //            if (node.Right !=null) //오른쪽 노드가 있으면
    //            {
    //                stack.Push(node.Right); 
    //            }

    //            if (node.Left !=null)
    //            {
    //                stack.Push(node.Left);
    //            }
    //        }
    //    }
    //    public void InOrderIterate() //중위 반복 순회
    //    {
    //        if (Root == null)
    //            return;

    //        Stack<BinaryTreeNode<T>> stack = new Stack<BinaryTreeNode<T>>();
    //        var node = Root;

    //        //먼저 왼쪽만 다 채워둠
    //        while (node !=null || stack.Count > 0)
    //        {
    //            while (node != null) //그 오른쪽이 존재하지 않을때까지 반복..
    //            {
    //                stack.Push(node);  //그 노드를 일단 저장..
    //                node = node.Left; //노드의 또 왼쪽으로 감..
    //            }

    //            node = stack.Pop();
    //            Console.WriteLine(node.Data);

    //            node = node.Right; //오른쪽 노드가 있따면...
    //        }
    //    }

    //    public void PostOrderIterate() //후위 반복 순회
    //    {
    //        if (Root == null)
    //            return;

    //        Stack<BinaryTreeNode<T>> stack = new Stack<BinaryTreeNode<T>>();
    //        var node = Root;

    //        //왼쪽 마지막까지 일단 다 돌고.. => 오른쪽 자식노드와 루트를 스택에 저장할것임...
    //        while (node!=null || stack.Count>0)
    //        {
    //            while (node !=null)
    //            {
    //                if (node.Right != null)
    //                {
    //                    stack.Push(node.Right);
    //                }
    //                stack.Push(node); //루트를 스택에 저장
    //                node = node.Left; //왼쪽으로 가기...
    //            }

    //            node = stack.Pop();

    //            if (node.Right != null && stack.Count > 0 && node.Right == stack.Peek()) //스택의 맨 위가 오른쪽 자식노드와 같다면
    //            {
    //                var right = stack.Pop(); //오른쪽 자식노드 꺼냄
    //                stack.Push(node); //스택에 루트노드 다시 넣기
    //                node = right;
    //            }
    //            else
    //            {
    //                Console.WriteLine(node.Data);
    //                node = null;
    //            }
    //        }
    //    }        
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        BinaryTree<int> tree = new BinaryTree<int>(1);
    //        tree.Root.Left = new BinaryTreeNode<int>(2);
    //        tree.Root.Right = new BinaryTreeNode<int>(3);

    //        tree.Root.Left.Left = new BinaryTreeNode<int>(4);
    //        tree.Root.Right.Right = new BinaryTreeNode<int>(5);

    //        Console.WriteLine("전위 순회");
    //        tree.PreOrderIterate();

    //        Console.WriteLine("중위 순회");
    //        tree.InOrderIterate();

    //        Console.WriteLine("후위 순회");
    //        tree.PostOrderIterate();
    //    }
    //}
    #endregion
    #region 이진트리

    //class BinaryTreeNode<T>
    //{ 
    //    public T Data { get; set; }
    //    public BinaryTreeNode<T> Left { get; set; }
    //    public BinaryTreeNode<T> Right { get; set; }
    //    public BinaryTreeNode(T data)
    //    {
    //        Data = data;
    //    }
    //}

    //class BinaryTree<T>
    //{ 
    //    public BinaryTreeNode<T> Root { get; private set; }
    //    public BinaryTree(T rootdata)
    //    {
    //        Root = new BinaryTreeNode<T>(rootdata);
    //    }

    //    public void PreOrderTraversal(BinaryTreeNode<T> node) //전위 순회
    //    {
    //        if (node == null)
    //            return;

    //        Console.WriteLine(node.Data);
    //        PreOrderTraversal(node.Left);
    //        PreOrderTraversal(node.Right);
    //    }
    //    public void InOrderTraversal(BinaryTreeNode<T> node) //중위 순회
    //    {
    //        if (node == null)
    //            return;

    //        InOrderTraversal(node.Left);
    //        Console.WriteLine(node.Data);
    //        InOrderTraversal(node.Right);
    //    }
    //    public void PostOrderTraversal(BinaryTreeNode<T> node) //후위 순회
    //    {
    //        if (node == null)
    //            return;

    //        PostOrderTraversal(node.Left);
    //        PostOrderTraversal(node.Right);
    //        Console.WriteLine(node.Data);                         
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        BinaryTree<int> tree = new BinaryTree<int>(1);
    //        tree.Root.Left = new BinaryTreeNode<int>(2);
    //        tree.Root.Right = new BinaryTreeNode<int>(3);

    //        tree.Root.Left.Left = new BinaryTreeNode<int>(4);
    //        tree.Root.Right.Right = new BinaryTreeNode<int>(5);

    //        Console.WriteLine("전위 순회");
    //        tree.PreOrderTraversal(tree.Root);

    //        Console.WriteLine();

    //        Console.WriteLine("중위 순회");
    //        tree.InOrderTraversal(tree.Root);

    //        Console.WriteLine();

    //        Console.WriteLine("후위 순회");
    //        tree.PostOrderTraversal(tree.Root);
    //    }
    //}
    #endregion

    #region 왼쪽자식 오른쪽 형제 표현 LCRS 

    //class LCRSNode
    //{ 
    //    public object Data { get; set; }

    //    public LCRSNode LeftChild { get; set; }
    //    public LCRSNode RightSibling { get; set; }
    //    public LCRSNode(object data)
    //    {
    //        Data = data;
    //    }
    //}

    //class LCRSTree
    //{ 
    //    public LCRSNode Root { get; private set; }
    //    public LCRSTree(object rootData)
    //    {
    //        Root = new LCRSNode(rootData);
    //    }

    //    public LCRSNode AddChild(LCRSNode parent/*부모로 삼고 싶은, 이미 존재하는 노드*/, object data/*자식으로 넣고 싶은 데이터*/)             
    //    {
    //        if (parent == null)
    //        {
    //            return null;
    //        }

    //        LCRSNode child = new LCRSNode(data);
    //        if (parent.LeftChild == null) //부모로 삼고자했던 친구의 자식이 없다면
    //        {
    //            parent.LeftChild = child;
    //        }
    //        else//내가 자식으로 들어가고 싶은 부모의 자식이 이미 있다면
    //        {
    //            LCRSNode node = parent.LeftChild; //
    //            while (node.RightSibling != null)
    //            {
    //                node = node.RightSibling;
    //            }
    //            node.RightSibling = child; // 그 자식의 형제가 됨...
    //        }
    //        return child;
    //    }

    //    public LCRSNode AddSibling(LCRSNode node, object data) //node의 형제로 data를 넣고 싶다...
    //    {
    //        if (node  == null)
    //        {
    //            return null;
    //        }
    //        LCRSNode sibling = new LCRSNode(data); //내가 형제로 넣고 싶은 데이터 실체화 함...

    //        if (node.RightSibling == null)
    //        {
    //            node.RightSibling = sibling;
    //        }
    //        else //만약 이미 형제가 있어..
    //        {
    //            while (node.RightSibling !=null)
    //            {
    //                node = node.RightSibling;
    //            }
    //            node.RightSibling = sibling;
    //        }
    //        return sibling;
    //    }

    //    public void PrintTree()
    //    {
    //        Queue<LCRSNode> nodequeue = new Queue<LCRSNode>();
    //        nodequeue.Enqueue(this.Root); //부모를 일단 큐에 넣음 

    //        while (nodequeue.Count > 0)//nodequeue가 존재한다면 계속 돌것임
    //        {
    //            LCRSNode node = nodequeue.Dequeue();
    //            while (node !=null)
    //            {
    //                Console.WriteLine(node.Data); //해당 노드 데이터 출력..
    //                if (node.LeftChild!=null)
    //                {
    //                    nodequeue.Enqueue(node.LeftChild); //자식도 확인하기 위해서 큐에 담아둠...
    //                }
    //                node = node.RightSibling;
    //            }
    //        }
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //트리클래스의 사용

    //        LCRSTree tree = new LCRSTree("A");

    //        var A = tree.Root; //부모가 될것임

    //        LCRSNode B = tree.AddChild(A, "B");
    //        var C = tree.AddChild(A, "C");
    //        var D = tree.AddSibling(B, "D"); //var D = tree.AddSibling(C, "D"); //var D = tree.AddChild(A, "D");

    //        //B의 자식, D의 자식도 동일하게 가능...

    //        var E = tree.AddChild(B, "E");
    //        var F = tree.AddChild(B, "F");

    //        var G = tree.AddChild(D, "G");

    //        tree.PrintTree();

    //        //=========================== 이하 트리클래스가 아닌 노드만 이용해서 트리형태를 강제구축함
    //        //var A = new LCRSNode("A");
    //        //var B = new LCRSNode("B");
    //        //var C = new LCRSNode("C");
    //        //var D = new LCRSNode("D");
    //        //var E = new LCRSNode("E");
    //        //var F = new LCRSNode("F");
    //        //var G = new LCRSNode("G");

    //        //A.LeftChild = B;
    //        //B.RightSibling = C;
    //        //C.RightSibling = D;

    //        //B.LeftChild = E;
    //        //E.RightSibling = F;

    //        //D.LeftChild = G;

    //        //if (A.LeftChild !=null)
    //        //{
    //        //    Console.WriteLine(A.Data);
    //        //    LCRSNode tmp = A.LeftChild;
    //        //    Console.WriteLine(tmp.Data);
    //        //    while (tmp.RightSibling !=null)
    //        //    {
    //        //        tmp = tmp.RightSibling;
    //        //        Console.WriteLine(tmp.Data);
    //        //    }

    //        //    tmp.LeftChild
    //        //}
    //    }
    //}
    #endregion

    #region n링크 표현 리스트로 바꿔보기
    //class TreeNode
    //{
    //    public object Data { get; set; }
    //    public List<TreeNode> Children { get; private set; } = new List<TreeNode>(); // 이 케이스랑 동일
    //    public TreeNode(object data)
    //    {
    //        Data = data;
    //        //Children = new List<TreeNode>(); //이 케이스랑 동일
    //    }
    //    public void AddChildren(TreeNode _node)
    //    {
    //        Children.Add(_node);
    //    }
    //}

    //class Program
    //{
    //    static void PrintTree(TreeNode _node)
    //    {
    //        Console.WriteLine(_node.Data);

    //        Console.WriteLine();
    //        foreach (var item in _node.Children)
    //        {
    //            PrintTree(item);
    //        }
    //    }

    //    static void Main(string[] args)
    //    {
    //        var A = new TreeNode("A");
    //        var B = new TreeNode("B");
    //        var C = new TreeNode("C");
    //        var D = new TreeNode("D");
    //        A.AddChildren(B);
    //        A.AddChildren(C);
    //        A.AddChildren(D);

    //        B.AddChildren(new TreeNode("E"));
    //        B.AddChildren(new TreeNode("F"));

    //        D.AddChildren(new TreeNode("G"));

    //        PrintTree(A); //전체 트리 출력하는 함수도 만들기
    //        //foreach (var item in A.Children)
    //        //{
    //        //    Console.WriteLine(item.Data);
    //        //}
    //    }
    //}
    #endregion

    #region n링크 표현 배열로
    //class TreeNode
    //{
    //    public object Data { get; set; }
    //    public TreeNode[] Children { get; private set; }
    //    public TreeNode(object data, int maxcount = 3)
    //    {
    //        Data = data;
    //        Children = new TreeNode[maxcount];
    //    }
    //}

    //class Program
    //{
    //    static void PrintTree(TreeNode _node)
    //    {
    //    }

    //    static void Main(string[] args)
    //    {
    //        var A = new TreeNode("A");
    //        var B = new TreeNode("B");
    //        var C = new TreeNode("C");
    //        var D = new TreeNode("D");
    //        A.Children[0] = B; //함수로 바꿔서 넣어야하는게 맞는..
    //        A.Children[1] = C;
    //        A.Children[2] = D;

    //        B.Children[0] = new TreeNode("E");
    //        B.Children[1] = new TreeNode("F");

    //        D.Children[0] = new TreeNode("G");

    //        PrintTree(A); //전체 트리 출력하는 함수도 만들기
    //        //foreach (var item in A.Children)
    //        //{
    //        //    Console.WriteLine(item.Data);
    //        //}
    //    }
    //}
    #endregion

    #region 트리 기본
    //class TreeNode<T> //트리의 요소인 정점의 가장 기본적 구조
    //{ 
    //    public T Data { get; set; }
    //    public List<TreeNode<T>> Children { get; set; } = new List<TreeNode<T>>();        
    //}    

    //class Program
    //{
    //    static void PrintTree(TreeNode<string> root) //재귀함수
    //    {
    //        Console.WriteLine(root.Data); //본인 데이터 출력
    //        Console.WriteLine("===============");
    //        foreach (var item in root.Children)
    //        {
    //            PrintTree(item);
    //        }
    //        Console.WriteLine("===============");
    //    }

    //    static void Main(string[] args)
    //    {
    //        TreeNode<string> root = new TreeNode<string>() { Data ="게임회사" };

    //        TreeNode<string> node = new TreeNode<string>() { Data = "개발팀" };
    //        node.Children.Add(new TreeNode<string>() { Data = "컨텐츠"});
    //        node.Children.Add(new TreeNode<string>() { Data = "라이브 서비스" });
    //        node.Children.Add(new TreeNode<string>() { Data = "툴" });
    //        root.Children.Add(node);

    //        node = new TreeNode<string>() { Data = "아트팀" };
    //        node.Children.Add(new TreeNode<string>() { Data = "UI/UX" });
    //        node.Children.Add(new TreeNode<string>() { Data = "배경" });
    //        node.Children.Add(new TreeNode<string>() { Data = "캐릭터/오브젝트" });
    //        root.Children.Add(node);

    //        node = new TreeNode<string>() { Data = "기획팀" };
    //        node.Children.Add(new TreeNode<string>() { Data = "스토리" });
    //        node.Children.Add(new TreeNode<string>() { Data = "시스템" });
    //        node.Children.Add(new TreeNode<string>() { Data = "컨텐츠" });
    //        root.Children.Add(node);

    //        node = new TreeNode<string>() { Data = "QA" };
    //        root.Children.Add(node);

    //        Console.WriteLine("설정한 트리 출력");
    //        Console.WriteLine("===============");
    //        PrintTree(root);

    //    }
    //}
    #endregion
}