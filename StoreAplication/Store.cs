using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreAplication
{
   public class Store:Customer
    {
        public Store(string name,string city) : base(name, city)
        {

        }
        public override void DisplayInfo()
        {
            Console.WriteLine("\nThe name of the store is:" + Name);
            Console.WriteLine("The city of the car is:" + City);
        }
    }
}
