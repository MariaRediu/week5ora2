using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreAplication
{
   public class Car: IVehicule
    {

        public Producer Producer { get; set; }

        public string Name { get; set; } 

        public decimal Price { get; set; }
     

        public Car(Producer producer ,string name,decimal price) 
        {
            this.Producer = producer;
            this.Name = name;
            this.Price = price;
        }

        public  void DisplayInfo()
        {
            Console.WriteLine("\nThe name of the car is:" + Name);
            Console.WriteLine("The price of the car is:" + Price);
            Console.WriteLine("The model of the car is:" + Producer);
            
        }
    }
}
