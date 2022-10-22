namespace Ex2Ver1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();

            car1.regNum = "PWD546";

            car1.model = "PR60";

            car1.manufacturer = "BMW";

            car1.color = "Red";

            car1.yearmod = 2012;

            car1.forSale = true;


            Console.WriteLine($"{car1.regNum} : {car1.model} : {car1.manufacturer} : {car1.color} : {car1.yearmod} : {car1.forSale}");


        }

        class Car
        {
            public string regNum;

            public string model;

            public string manufacturer;

            public string color;

            public int yearmod;

            public bool forSale;

        }
    }
}