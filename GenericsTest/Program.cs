namespace GenericsTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intResGen = new FindMaximum<int>(20, 50, 9).GetMaximun();
            Console.WriteLine("Maximum Interger Value is :" + intResGen);
            double doubleResGen = new FindMaximum<double>(200.0, 50.9, 9.5).GetMaximun();
            Console.WriteLine("Maximum Double Value is :" + doubleResGen);
            string stringResGen = new FindMaximum<string>("44", "56", "78").GetMaximun();
            Console.WriteLine("Maximum String Value is :" + stringResGen);


        }
    }
}
