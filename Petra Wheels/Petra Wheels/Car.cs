namespace PetraWheels
{
    public class Car : Vehicle
    {
        public int Seats { get; set; }

        public Car(int id, string plate, string model,
                   decimal dailyRate, int seats)
            : base(id, plate, model, dailyRate)
        {
            Seats = seats;
        }

        public override void ShowInfo()
        {
            
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Plate: {Plate}");
            Console.WriteLine($"Seats: {Seats}");
            Console.WriteLine($"Daily Rate: {DailyRate} JD");
            Console.WriteLine($"Status: {Status}");
        }
    }
}
