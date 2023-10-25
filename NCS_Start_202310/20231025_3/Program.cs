using System;

namespace _20231025_3
{
        class Sorting
    {
        public delegate int CompareDelegate(int num1, int num2);

        public static void Sort(int[] arr, CompareDelegate comp /*비교함수. 오름차순 또는 내림차순 에 맞게 판별해줄것임*/)
        {
            if (arr.Length < 2) //하나짜리라면 소팅할 수 없어서 돌려보냄
            {
                return;
            }
            int val;
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    val = comp(arr[i], arr[j]);
                    if (val == -1) //
                    {
                        //교환 필요
                        int tmp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = tmp;
                    }
                }
            }

            Display(arr);
        }

        static void Display(int[] arr) //배열 바뀐거 확인용
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                if (i< arr.Length -1)
                {
                    Console.Write(",");
                }                
            }
            Console.WriteLine();
        }
    }

    class Program
    {
       static int AscendingCompare(int num1, int num2) //오름차순. 두 수를 비교했을때, 앞의 수가 뒤의 수보다 크다면 잘못됐으므로 -1을 반환.
        {
            if (num1 == num2)
            {
                return 0;
            }
            else
                return num2 - num1 > 0 ? 1 : -1;
        }

        static int DescendingCompare(int num1, int num2) //내림차순. 두 수를 비교해서, 앞의 수가 뒤의 수보다 커야함.
        {
            if (num1 == num2)
            {
                return 0;
            }
            else
                return num2 - num1 > 0 ? -1 : 1;
        }

        static void Main(string[] args)
        {
            int[] arr = new int[6] { 7,1,5, 9, 3,8};

            Console.WriteLine("오름차순 정렬 시도");
            Sorting.CompareDelegate sortdel = AscendingCompare;
            Sorting.Sort(arr, sortdel);    

            Console.WriteLine("내림차순 정렬 시도");
            Sorting.Sort(arr, DescendingCompare);
        }
    }
}