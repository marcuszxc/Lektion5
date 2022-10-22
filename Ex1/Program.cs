namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Welcome welMsg = new Welcome();

            welMsg.WelcomeMessage();

        }

        class Welcome
        {
            public void WelcomeMessage()
            {
                Console.WriteLine("Welcome to OOP");
            }
        }

    }
}