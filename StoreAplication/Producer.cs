using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreAplication
{
    public class Producer : IProducer
    {  
        public string Producer { get; set ; }

        public static implicit operator Producer(string v)
        {
            throw new NotImplementedException();
        }
    }
}
