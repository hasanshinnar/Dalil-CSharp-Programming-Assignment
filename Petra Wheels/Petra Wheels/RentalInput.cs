
using System;

namespace PetraWheels
{
    public class RentalInput
    {
        public static void RentVehicle(VehicleManager manager)
        {
            Console.Write("Enter vehicle plate: ");
            string plate = Console.ReadLine();

            Vehicle vehicle = manager.FindVehicleByPlate(plate);

            if (vehicle == null)
            {
                Console.WriteLine("Vehicle not found!");
                return;
            }

            if (vehicle.Status == VehicleStatus.Rented)
            {
                Console.WriteLine("Vehicle is already rented!");
                return;
            }

            Console.Write("Enter customer name: ");
            string customerName = Console.ReadLine();

            int age;

            try
            {
                Console.Write("Enter customer age: ");
                age = int.Parse(Console.ReadLine());

                if (age < 18)
                {
                    Console.WriteLine("Customer must be at least 18 years old!");
                    return;
                }
            }
            catch
            {
                Console.WriteLine("Invalid age!");
                return;
            }

            int days;

            try
            {
                Console.Write("Enter rental days: ");
                days = int.Parse(Console.ReadLine());

                if (days <= 0)
                {
                    Console.WriteLine("Rental days must be greater than zero!");
                    return;
                }
            }
            catch
            {
                Console.WriteLine("Invalid number of days!");
                return;
            }

            decimal total = vehicle.DailyRate * days;

            if (days >= 7)
            {
                total *= 0.90m;
                Console.WriteLine("10% discount applied!");
            }

            vehicle.Status = VehicleStatus.Rented;

            Console.WriteLine("\n===== RENTAL SUMMARY =====");
            Console.WriteLine($"Customer: {customerName}");
            Console.WriteLine($"Vehicle: {vehicle.Model}");
            Console.WriteLine($"Plate: {vehicle.Plate}");
            Console.WriteLine($"Days: {days}");
            Console.WriteLine($"Total: {total:F2} JD");
            Console.WriteLine("Rental completed successfully!");
        }
    }
}
