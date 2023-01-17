namespace GenericsTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 112, 344, 432, 555, 678 };
            int intResGen = new FindMaximum<int>(ints).GetMax();
            Console.WriteLine("Maximum Interger Value is :" + intResGen);

            double[] doubles = { 11.2, 34.4, 4.32, 55.5, 6.78 };
            double doubleResGen = new FindMaximum<double>(doubles).GetMax();
            Console.WriteLine("Maximum Double Value is :" + doubleResGen);

            string[] strings = { "111", "222", "333", "55", "999" };
            string stringResGen = new FindMaximum<string>(strings).GetMax();
            Console.WriteLine("Maximum String Value is :" + stringResGen);

        }
    }
}
