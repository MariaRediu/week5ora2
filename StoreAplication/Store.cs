using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreAplication
{
    public class Store : IStore
    {
        public string Name { get; set; }
        public string City { get; set; }
        public Store(string name,string city)
        {
            this.Name = name;
            this.City = city;

        }

        public void CancelOrder(IOrder order)
        {
            Console.WriteLine("The delivery is annulate");
          
        }

        public IOrder EnterandBuy(ICustomer costumer, IProducer producer, IVehicule vehicule)
        {
            Console.WriteLine($"{customer.Name} enter to {this.Name}");
            Console.WriteLine(($"{customer.Name} orders  { vehicule.Name}");
        }
    }
}
