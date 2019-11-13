using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreAplication
{
   public  class Customer :ICustomer
    {
        public string Name { get; set; } 
       
        public Customer(string name)
        {
            this.Name = name;
          
        }
    }
}
