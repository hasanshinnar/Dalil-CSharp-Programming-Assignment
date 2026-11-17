
using System;
using PetraWheels;

class Program
{
    static void Main(string[] args)
    {
        if (!LoginManager.Login())
        {
            return;
        }

        VehicleManager manager = new VehicleManager();

        Car car = new Car(
            manager.GenerateId(),
            "AB-123",
            "Toyota",
            30m,
            5
        );

        Motorcycle bike = new Motorcycle(
            manager.GenerateId(),
            "XY-456",
            "Honda",
            15m,
            250
        );
        Car secondCar = new Car(
          manager.GenerateId(),
          "CD-789",
         "Hyundai",
         25m,
          4
         );

        manager.AddVehicle(car);
        manager.AddVehicle(bike);
        manager.AddVehicle(secondCar);
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n===== PETRA WHEELS =====");
            Console.WriteLine("1. Add Vehicle");
            Console.WriteLine("2. Show Vehicles");
            Console.WriteLine("3. Rent Vehicle");
            Console.WriteLine("4. Return Vehicle");
            Console.WriteLine("5. Reports");
            Console.WriteLine("6. Exit");

            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    VehicleInput.AddVehicle(manager);
                    break;

                case "2":
                    manager.ShowAllVehicles();
                    break;

                case "3":
                    RentalInput.RentVehicle(manager);
                    break;

                case "4":
                    ReturnInput.ReturnVehicle(manager);
                    break;

                case "5":
                    ReportManager.ShowReports(manager);
                    break;

                case "6":
                    running = false;
                    Console.WriteLine("Thank you for using Petra Wheels!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please choose from 1 to 6.");
                    break;
            }
        }
    }
}
