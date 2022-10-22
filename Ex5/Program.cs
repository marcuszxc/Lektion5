

namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            list = (Enumerable.Range(-5, 11).ToList());

            list.Sort();

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey(true);

            Console.Clear();

            list.Remove(5);

            list.RemoveAt(0);

            list.RemoveRange(0, 2);

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey(true);

            Console.Clear();

            list.Clear();

            foreach (int i in list)
            {
                Console.WriteLine();
            }

        }
    }
}