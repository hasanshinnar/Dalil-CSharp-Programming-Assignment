
using System.Collections.Generic;

namespace PetraWheels
{
    public class VehicleManager
    {
        private List<Vehicle> vehicles = new List<Vehicle>();

        private int nextId = 1;

        public int GenerateId()
        {
            return nextId++;
        }

        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public Vehicle FindVehicleByPlate(string plate)
        {
            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle.Plate == plate)
                {
                    return vehicle;
                }
            }

            return null;
        }
        public void ShowAllVehicles()
        {
            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.ShowInfo();
                Console.WriteLine("----------------");
            }
        }
        public List<Vehicle> GetAllVehicles()
        {
            return vehicles;
        }

    }
}
