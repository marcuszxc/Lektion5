namespace Ex2Ver3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("PWD234", "PR60", "BMW", "Red", 2012, true);

            Console.WriteLine($"{car1.RegNum} : {car1.Model} : {car1.Manufacturer} : {car1.Color} : {car1.YearMod} : {car1.ForSale}");

        }

        class Car
        {
            private string regNum;

            private string model;

            private string manufacturer;

            private string color;

            private int yearmod;

            private bool forSale;


           public Car(string regNum, string model, string manufacturer, string color, int yearmod, bool forSale)
            {
                this.regNum = regNum;
                this.model = model;
                this.manufacturer = manufacturer;
                this.color = color;
                this.yearmod = yearmod;
                this.forSale = forSale;
            }

            public string RegNum
            {
                set { regNum = value; }
                get { return regNum; }
            }

            public string Model
            {
                set { model = value; }
                get { return model; }
            }

            public string Manufacturer
            {
                set { manufacturer = value; }
                get { return manufacturer; }
            }

            public string Color
            {
                set { color = value; }
                get { return color; }
            }

            public int YearMod
            {
                set { yearmod = value; }
                get { return yearmod; }
            }

            public bool ForSale
            {
                set { forSale = value; }
                get { return forSale; }
            }

        }

    }
}