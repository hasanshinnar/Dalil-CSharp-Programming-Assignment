using System;
using System.Collections.Generic;
using PetraWheels;

class Program
{
    static void Main(string[] args)
    {
        List<Vehicle> vehicles = new List<Vehicle>();

        Car initialCar = new Car(1, "AB-123", "Toyota", 30m, 5);
        Motorcycle initialBike = new Motorcycle(2, "XY-456", "Honda", 15m, 250);

        vehicles.Add(initialCar);
        vehicles.Add(initialBike);

        Console.WriteLine("Choose vehicle type:");
        Console.WriteLine("1. Car");
        Console.WriteLine("2. Motorcycle");
        Console.Write("Your choice: ");

        string choice = Console.ReadLine();
        int newId = vehicles.Count + 1;

        if (choice == "1")
        {
            Console.Write("Enter car plate: ");
            string plate = Console.ReadLine();

            bool plateExists = false;

            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle.Plate == plate)
                {
                    plateExists = true;
                    break;
                }
            }

            if (plateExists)
            {
                Console.WriteLine("This plate already exists!");
            }
            else
            {
                Console.Write("Enter car model: ");
                string model = Console.ReadLine();

                Console.Write("Enter car daily rate: ");
                decimal dailyRate = decimal.Parse(Console.ReadLine());

                Console.Write("Enter car seating capacity: ");
                int seats = int.Parse(Console.ReadLine());

                Car newCar = new Car(newId, plate, model, dailyRate, seats);
                vehicles.Add(newCar);

                Console.WriteLine("Car added successfully!");
            }
        }
        else if (choice == "2")
        {
            Console.Write("Enter motorcycle plate: ");
            string plate = Console.ReadLine();

            bool plateExists = false;

            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle.Plate == plate)
                {
                    plateExists = true;
                    break;
                }
            }

            if (plateExists)
            {
                Console.WriteLine("This plate already exists!");
            }
            else
            {
                Console.Write("Enter motorcycle model: ");
                string model = Console.ReadLine();

                Console.Write("Enter motorcycle daily rate: ");
                decimal dailyRate = decimal.Parse(Console.ReadLine());

                Console.Write("Enter motorcycle engine capacity (cc): ");
                int engineCapacity = int.Parse(Console.ReadLine());

                Motorcycle newBike = new Motorcycle(newId, plate, model, dailyRate, engineCapacity);
                vehicles.Add(newBike);

                Console.WriteLine("Motorcycle added successfully!");
            }
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }
}