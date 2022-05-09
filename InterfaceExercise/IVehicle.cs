using System;
namespace InterfaceExercise
{
    public interface IVehicle : ICompany
    {
        public int VehYear { get; set; }
        public string VehMake { get; set; }
        public string VehModel { get; set; }
        public double WheelSize { get; set; }

        public void EngineIsWorking();
        public void HornIsWorking();
    }
}
