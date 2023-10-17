namespace Mission5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
             * 20보다 작은 자연수 중에서 3 또는 5의 배수를 모두 더한 값 구하기
             * x의 배수는 나머지가 0인 경우겠죠
             * 3과 5의 배수 둘다 해당되는 수를 두번 더하지 않도록 유의할것
             * while문 사용해서 해결하기
             * 
             * 
             */
            {
                int i = 1;
                int sum = 0;
                while (i > 20)
                {
                    if (i % 3 == 0 || i % 5 == 0)
                    {
                        // i가 현재 3의 배수 혹은 5의 배수다.
                        sum += i;
                    }

                    i++;
                }
                
            }
        }
    }
}