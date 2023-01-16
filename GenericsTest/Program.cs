namespace GenericsTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindMaximum maxValue = new FindMaximum();

            int intResGen = maxValue.GetMaximun<int>(10, 78, 90);
            Console.WriteLine("Maximum Interger Value is :" + intResGen);
            double doubleResGen = maxValue.GetMaximun<double>(11.4, 89.67, 98.5);
            Console.WriteLine("Maximum Double Value is :" + doubleResGen);
            string stringResGen = maxValue.GetMaximun<string>("456", "946", "657");
            Console.WriteLine("Maximum String is :" + stringResGen);
        }
    }
}
