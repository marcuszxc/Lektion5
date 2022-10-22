namespace Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cities = new Dictionary<string, string>()
            {
                { "UK","London,New castel" },
                {"USA", "New york, Wasington" },
                {"SWEDEN", "Stockholm, Malmö"}
            };

            foreach (var c in cities)
            {
                Console.WriteLine($"Key: {c.Key} --- Value: {c.Value}");
            }

            Console.WriteLine($"\n{cities["USA"]}");

            string result;

            if (cities.TryGetValue("SWEDEN", out result))
            {
                Console.WriteLine($"\n{result}");
            }

            cities.Remove("UK");

            Console.ReadKey(true);

            Console.Clear();

            foreach (var c in cities)
            {
                Console.WriteLine($"Key: {c.Key} --- Value: {c.Value}");
            }

        }
    }
}