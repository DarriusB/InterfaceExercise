﻿using System;
namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public SUV()
        {
        }

        public string CabinSize { get; set; }
        public int HeightFromGround { get; set; }
        public int VehYear { get; set; }
        public string VehMake { get; set; }
        public string VehModel { get; set; }
        public double WheelSize { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }

        public void EngineIsWorking()
        {
            Console.WriteLine("Yes! Engine is running."); ;
        }

        public void HornIsWorking()
        {
            Console.WriteLine("Honk, Honk");
        }
    }

}
