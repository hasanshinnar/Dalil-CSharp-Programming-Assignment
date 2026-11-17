using System;

namespace PetraWheels
{
    public class VehicleInput
    {
        public static void AddVehicle(VehicleManager manager)
        {
            Console.WriteLine("\n1. Car");
            Console.WriteLine("2. Motorcycle");
            Console.Write("Choose vehicle type: ");

            string type = Console.ReadLine();

            if (type != "1" && type != "2")
            {
                Console.WriteLine("Invalid vehicle type!");
                return;
            }

            Console.Write("Enter plate: ");
            string plate = Console.ReadLine();

            if (manager.FindVehicleByPlate(plate) != null)
            {
                Console.WriteLine("Plate already exists!");
                return;
            }

            Console.Write("Enter model: ");
            string model = Console.ReadLine();

            Console.Write("Enter daily rate: ");

            if (!decimal.TryParse(Console.ReadLine(), out decimal rate) || rate <= 0)
            {
                Console.WriteLine("Invalid daily rate!");
                return;
            }

            if (type == "1")
            {
                Console.Write("Enter seats: ");

                if (!int.TryParse(Console.ReadLine(), out int seats) || seats <= 0)
                {
                    Console.WriteLine("Invalid seats!");
                    return;
                }

                Car newCar = new Car(
                    manager.GenerateId(), plate, model, rate, seats);

                manager.AddVehicle(newCar);

                Console.WriteLine("Car added successfully!");
            }
            else
            {
                Console.Write("Enter engine capacity (cc): ");

                if (!int.TryParse(Console.ReadLine(), out int engineCapacity) || engineCapacity <= 0)
                {
                    Console.WriteLine("Invalid engine capacity!");
                    return;
                }

                Motorcycle newBike = new Motorcycle(
                    manager.GenerateId(), plate, model, rate, engineCapacity);

                manager.AddVehicle(newBike);

                Console.WriteLine("Motorcycle added successfully!");
            }
        }
    }
}
