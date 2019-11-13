using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreAplication
{
    class Order :IOrder
    {
    
        public ICustomer Customer { get ; set ; }
        public IVehicule Vehicule { get ; set; }
        public DateTime DeliveryTime { get ; set; }

        public Order(ICustomer customer, IVehicule vehicule, DateTime data)
        {
            this.Customer = customer;
            this.Vehicule = vehicule;
            this.DeliveryTime = data;  

        }
       
    }
}
