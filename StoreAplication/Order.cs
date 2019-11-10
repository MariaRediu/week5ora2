using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreAplication
{
    class Order:Customer
    {
        public string IdOrder { get; set; }
        public Order(string name,string Id) : base(name, Id)
        {
            this.IdOrder = Id;

        }
        public override void DisplayInfo()
        {
            
        }
    }
}
