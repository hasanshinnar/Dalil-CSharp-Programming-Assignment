using System;

namespace PetraWheels
{
    public class ReturnInput
    {
        public static void ReturnVehicle(VehicleManager manager)
        {
            Console.Write("Enter vehicle plate: ");
            string plate = Console.ReadLine();

            Vehicle vehicle = manager.FindVehicleByPlate(plate);

            if (vehicle == null)
            {
                Console.WriteLine("Vehicle not found!");
                return;
            }

            if (vehicle.Status == VehicleStatus.Available)
            {
                Console.WriteLine("This vehicle is not currently rented!");
                return;
            }

            vehicle.Status = VehicleStatus.Available;

            Console.WriteLine("Vehicle returned successfully!");
            Console.WriteLine($"Model: {vehicle.Model}");
            Console.WriteLine($"Plate: {vehicle.Plate}");
            Console.WriteLine($"Status: {vehicle.Status}");
        }
    }
}
