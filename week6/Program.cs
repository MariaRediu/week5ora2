using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            Add1(i); //facem o copie a lui i cand apelam metoda,dupa se adauga (in metoda trimitem o copie a lui i)


            var k = i;      
        }
        public static void Add1(int nr)
        {
            nr++;
        }
    }

    
}
