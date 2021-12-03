using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car car1 = new Car("X5","BMW",250,"Red",20);
            //Car car2 = new Car("07", "Lada", 180, "Black",10);
            Car car3 = new Car();
           


            //car3.SetNumber(-9);
            //Console.WriteLine(car3.GetNumber());
            car3.Number = -9;
            Console.WriteLine(car3.Number);


           
           
            

            //Console.WriteLine(car1.Average());
            //Console.WriteLine(car2.Average());
        }

    }
}
