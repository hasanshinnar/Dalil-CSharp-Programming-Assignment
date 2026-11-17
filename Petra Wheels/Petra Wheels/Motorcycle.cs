
namespace PetraWheels
{
    public class Motorcycle : Vehicle
    {
        public int EngineSize { get; set; }

        public Motorcycle(int id, string plate, string model,
                          decimal dailyRate, int engineSize)
            : base(id, plate, model, dailyRate)
        {
            EngineSize = engineSize;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Plate: {Plate}");
            Console.WriteLine($"Engine Size: {EngineSize}");
            Console.WriteLine($"Daily Rate: {DailyRate}");
            Console.WriteLine($"Status: {Status}");
        }
    }
}
