namespace Ex2Ver2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("PWD234","PR60","BMW","Red",2012,true); 

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

            public Car(string regNum, string model, string manufacturer, string color, int yearmod, bool forSale)
            {
                this.regNum = regNum.ToUpper();
                this.model = model.ToUpper();
                this.manufacturer = manufacturer.ToUpper();
                this.color = color;
                this.yearmod = yearmod;
                this.forSale = forSale;
            }
        }

    }
}