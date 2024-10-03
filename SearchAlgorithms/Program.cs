namespace SearchAlgorithms
{
    internal class Program
    {

        static Random randomGenerator = new Random();
        static void Main(string[] args)
        {
            List<double> listOfDoubles = new List<double>();

            PopulateListWithRandomDoubles(ref listOfDoubles, 10);
            PrintList(listOfDoubles);

            Console.ReadKey();
        }

        static void PopulateListWithRandomDoubles(ref List<double> list, int size)
        {
            for (int i = 0; i < size; i++)
            {
                double twoDigitDouble = Double.Parse(randomGenerator.NextDouble().ToString("0.00"));
                list.Add(twoDigitDouble);
            }
        }

        static void PrintList(List<double> list)
        {
            Console.WriteLine("\n\nLIST PRINT:\n");

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("  " + list[i].ToString());
            }

            Console.WriteLine("\nEnd \n");
        }
    }
}
