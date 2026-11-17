
using System;

namespace PetraWheels
{
	public class ReportManager
	{
		public static void ShowReports(VehicleManager manager)
		{
			int totalVehicles = 0;
			int availableVehicles = 0;
			int rentedVehicles = 0;

			foreach (Vehicle vehicle in manager.GetAllVehicles())
			{
				totalVehicles++;

				if (vehicle.Status == VehicleStatus.Available)
				{
					availableVehicles++;
				}
				else
				{
					rentedVehicles++;
				}
			}

			Console.WriteLine("\n===== PETRA WHEELS REPORT =====");
			Console.WriteLine($"Total Vehicles: {totalVehicles}");
			Console.WriteLine($"Available Vehicles: {availableVehicles}");
			Console.WriteLine($"Rented Vehicles: {rentedVehicles}");

			Console.WriteLine("\n===== VEHICLE DETAILS =====");

			foreach (Vehicle vehicle in manager.GetAllVehicles())
			{
				vehicle.ShowInfo();
				Console.WriteLine("----------------");
			}
		}
	}
}
