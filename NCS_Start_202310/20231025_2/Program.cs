namespace _20231025_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int number = 2;
            bool isEven;

            if (number % 2 == 0)
            {
                isEven = true;
            }
            else 
            {
                isEven = false;
            }

            {
                int number1 = 2;
                bool isEven1;

                isEven1 = (number1 % 2 == 0) ? true : false ;
            }
        }
    }
}