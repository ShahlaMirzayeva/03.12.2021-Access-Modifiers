using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers
{
    class Vehicle
    {
       public string Model { get; set; }
       
        public readonly string Brand;
        public int Speed;
        public string Color;
        public int Litr;
        protected readonly string Ban;
        private int _number;
        private readonly int _pass;

        public Vehicle()
        {
           
        }
        public int Number
        {

            get
            {

                return _number;

            }

            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Duzgun daxil edin");
                    return;
                }

                _number = value;

            }
        }



        //public int GetNumber()
        //{
        //    return _number;
        //}

        //public void SetNumber(int num)
        //{
        //    if (num < 0)
        //    {
        //        Console.WriteLine("Duzgun daxil edin");
        //    }

        //    _number = num;
        //}






        //public Vehicle(string model,string brand,int speed,string color,int litr)
        //{
        //    Model = model;
        //    Brand = brand;
        //    Speed = speed;
        //    Color = color;
        //    Litr = litr;
        //    Console.WriteLine($"{Model} {Brand}");
        //}
        //public Vehicle()
        //{
        //    Console.WriteLine("Ok");
        //}

        //public int Average()
        //{
        //    return Litr * 100;
        //}

        public void Test()
        {
            Car car = new Car();
            
            
        }
    }
}
