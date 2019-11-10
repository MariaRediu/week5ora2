using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreAplication
{
   public  abstract class Car:Customer
    {
       
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }

        public Car(string name,string city,string model,int year,double price) : base(name,city)
        {
            this.Model = model;
            this.Year = year;
            this.Price = price;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("\nThe name of the car is:" + Name);
            Console.WriteLine("The price of the car is:" + Price);
            Console.WriteLine("The model of the car is:" + Model);
            Console.WriteLine("The year of the car is:" + Year);
            Console.WriteLine("The city of the car is:" + City);
        }
    }
}
