namespace GenericsTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Initializing Test Maximum Program");

            int result = FindMaximum.GetMaximumIntNumber(95, 150, 65);
            Console.WriteLine($"The maxumum number between three integer is : {result}");

            double doubleResult = FindMaximum.GetMaximumFloatNumber(11.5, 11.6, 11.7);
            Console.WriteLine($"The maxumum number between three integer is : {doubleResult}");

        }
    }
}
