using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreAplication
{
    interface IStore
    {
        string Name { get; set; }
        string City { get; set; }
        IOrder EnterandBuy(ICustomer costumer, IProducer producer, IVehicule vehicule);

        void CancelOrder(IOrder order); 
        IOrder EnterandBuy(ICustomer alex, IVehicule focus);
    }
}
