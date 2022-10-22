using System.Collections.ObjectModel;

namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Collection<int> coll = new Collection<int>();


            foreach (int i in Enumerable.Range(1,10))
            {
                coll.Add(i);
            }

            foreach (int i in coll)
            {
                Console.WriteLine(i);
            }

        }
    }
}