using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreAplication
{
    public class Car : IVehicule, ICloneable
    {

        public Producer Producer { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }


        public Car(Producer producer, string name, decimal price)
        {
            this.Producer = producer;
            this.Name = name;
            this.Price = price;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("\nThe name of the car is:" + Name);
            Console.WriteLine("The price of the car is:" + Price);
            Console.WriteLine("The model of the car is:" + Producer);

        }

        public override bool Equals(object param)
        {
            Car masina = param as Car;
            if (masina == null)
                return false;
            if (!Object.Equals(this.Name, masina.Name))
                return false;
            if (!Object.Equals(this.Producer, masina.Producer))
                return false;
            if (!Object.Equals(this.Price, masina.Price))
                return false;
            return true;
        }

        public static bool operator ==(Car masina1,
                                  Car masina2)
        {
            return Car.Equals(masina1, masina2);
        }
        public static bool operator !=(Car masina1,
                                  Car masina2)
        {
            return !(Car.Equals(masina1, masina2));
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
        public static Car DeepCopy(Car other)
        {
            return new Car(other.Name, other.Producer,other);
        }

        public object Clone()
        {
            return this.MemberwiseClone();
           
        }
    }
}
