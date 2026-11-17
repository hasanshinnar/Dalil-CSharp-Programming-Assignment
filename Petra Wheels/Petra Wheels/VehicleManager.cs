using System;
using System.Collections.Generic;

namespace PetraWheels
{
    public class VehicleManager
    {
        private List<Vehicle> vehicles = new List<Vehicle>();

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
    }
}