namespace PetraWheels
{
    public enum VehicleStatus
    {
        Available,
        Rented
    }

    public abstract class Vehicle
    {
        public int Id { get; set; }

        public string Plate { get; set; }

        public string Model { get; set; }
        public VehicleStatus Status { get; set; }


        private decimal dailyRate;

        public decimal DailyRate
        {
            get
            {
                return dailyRate;
            }

            set
            {
                if (value > 0)
                {
                    dailyRate = value;
                }
                else
                {
                    throw new ArgumentException("Daily rate must be greater than zero.");
                }
            }

        }
        public Vehicle(int id, string plate, string model, decimal dailyRate)
        {
            Id = id;
            Plate = plate;
            Model = model;
            DailyRate = dailyRate;
            Status = VehicleStatus.Available;
        }
        public abstract void ShowInfo();

    }


}