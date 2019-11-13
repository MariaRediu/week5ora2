using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreAplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomer alex = new Customer("Alex");

            IStore ford = new Store("Ford","Bucuresti");
            IVehicule focus = new Car
            {
                Producer =  "Ford" ,
                Name = "Focus",
                Price = 15000,
                
            };

            IStore skoda = new Store("Skoda","Bucuresti");
            IVehicule fabia = new Car  
            {
                Producer = "Skoda",
                Name = "Fabia",
                Price = 15000,

            };
            IOrder focusOrder = ford.EnterandBuy(alex, focus);

            IOrder skodaOrder = skoda.EnterandBuy(alex, fabia);

            if (focusOrder.DeliveryTime < skodaOrder.DeliveryTime)
            {
                skoda.CancelOrder(skodaOrder);
            }
            else
            {
                ford.CancelOrder(focusOrder);
            }

        }
    }
}
