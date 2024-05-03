namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
        }
        public static int Add(int num1, int num2)
        {
            int total = num1 + num2;
            return total;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            decimal total = num1 + num2;
            return total;
        }

        public static string Add(int num1, int num2, bool isUSD)
        {
            if (isUSD)
            {
                string total = (num1 + num2).ToString();
                return total;
            }
            else { return "no funny money"; }
        }
    }
}
