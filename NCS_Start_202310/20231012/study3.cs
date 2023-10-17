using System;

namespace _20231012
{
    public class study3
    {
        public void st2()
        {
            try
            {
                // char a = 'a';
                // Console.WriteLine((int)a);
                // a = 'A';
                // Console.WriteLine((int)a);
                char[] charArr = new char[10];
                for (int i = 0; i < charArr.Length; i++)
                {
                    string a = "aaaaaaaa" + 2;
                    charArr[i] = (char)('a' + 1);
                    Console.WriteLine(i + "번째 charArr[] 요소 : " + charArr[i]);
                }
                Console.WriteLine(); //띄어쓰기

                for (int i = 0; i < charArr.Length; i++)
                {
                    Console.WriteLine(i+"번째 charArr[] 요소 : " + (char)(charArr[i] - 32));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}