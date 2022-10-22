namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Collections.ObjectModel.Collection<string> collection = new System.Collections.ObjectModel.Collection<string>();

            foreach (int item in Enumerable.Range(1,10))
            {
                collection.Add(Convert.ToString(item));
            }

            string[] array = collection.ToArray();

            foreach (string item in array)
            {
                Console.WriteLine(item);
            }

        }
    }
}