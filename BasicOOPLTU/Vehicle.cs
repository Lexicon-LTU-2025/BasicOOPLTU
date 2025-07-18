﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOPLTU
{
    internal abstract class AbstractVehicle : IDrivable
    {
        private int fuel;

        protected bool ProtectedBool; 
        public abstract string Turn();
        public virtual string Drive(int distance)
        {
            //return $"Vehicle drove for {distance}"; 
            return $"{GetType().Name} drove for {distance}"; 
        }
    }

    internal class Vehicle : AbstractVehicle
    {
        public string Brand { get; protected set; }

        public Vehicle(string brand)
        {
            Brand = brand;
        }

        public override string Turn()
        {
            ProtectedBool = false;
            return "Turning"; 
        }
    }
    internal /*sealed*/ class Car : Vehicle, IStoppable, IDrivable
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
            ProtectedBool = false; 
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
