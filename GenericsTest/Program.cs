namespace GenericsTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Initializing Test Maximum Program");

            int result = FindMaximum.GetMaximumIntNumber(95, 150, 65);
            Console.WriteLine($"The maxumum number between three integer is : {result}");


        }
    }
}
