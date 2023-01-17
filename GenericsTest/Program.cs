namespace GenericsTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 112, 3444, 432, 555, 678 };
            double[] doubles = { 11.2, 34.4, 4444.32, 55.5, 6.78 };
            string[] strings = { "111", "222", "9999", "55", "999" };

            FindMaximum<int> intResGen = new FindMaximum<int>(ints);
            intResGen.ToPrint();

            FindMaximum<double> doubleResGen = new FindMaximum<double>(doubles);
            doubleResGen.ToPrint();

            FindMaximum<string> stringResGen = new FindMaximum<string>(strings);
            stringResGen.ToPrint();



        }
    }
}
