using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreAplication
{
   public abstract class Customer 
    {
        public string Name { get; set; }
        public string City { get; set; }
        public Customer(string name,string city)
        {
            this.Name = name;
            this.City = city;

        }

        public abstract void DisplayInfo();
    }
}
