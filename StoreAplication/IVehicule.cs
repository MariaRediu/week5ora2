using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreAplication
{
    interface IVehicule
    {
        Producer Producer { get; set; }
        decimal Price { get; set; }
        string Name { get; set; }

         
    }
}
