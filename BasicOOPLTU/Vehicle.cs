using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOPLTU
{
    internal class Vehicle : IDrivable
    {
        public string Brand { get; set; }

        public Vehicle(string brand)
        {
            Brand = brand;
        }

        public virtual string Drive(int distance)
        {
            //return $"Vehicle drove for {distance}"; 
            return $"{GetType().Name} drove for {distance}"; 
        }
    }
    internal class Car : Vehicle, IStoppable, IDrivable
    {
        public string Model { get; set; }
        public Car(string brand, string model) : base(brand)
        {
            Model = model; 
        }

        public override string Drive(int distance)
        {
            return $"{base.Drive(distance)} from car";
        }

        public void Stop()
        {
            Console.WriteLine("Car stopped.");
        }
    }

    internal class Saab : Car
    {
        public Saab(string model = "900"): base("Saab", model)
        {

        }

        public string SpecialMethod()
        {
            return "From Saab"; 
        }
    }
}
