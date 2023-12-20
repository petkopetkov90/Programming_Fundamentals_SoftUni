namespace Speed_Racing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carDetails = Console.ReadLine()
                    .Split()
                    .ToArray();

                Car car = new Car();
                car.Model = carDetails[0];
                car.FuelAmount = double.Parse(carDetails[1]);
                car.FuelConsumedPerKm = double.Parse(carDetails[2]);
                cars.Add(car);
            }
            string command;
            while((command = Console.ReadLine()) != "End")
            {
                string[] commands = command.Split()
                    .ToArray();
                Car currentCar = cars.First(car => car.Model == commands[1]);
                currentCar.CanMoveOrNot(double.Parse(commands[2]));
            }
            Console.WriteLine(string.Join("\n", cars));
        }
    }

    public class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumedPerKm { get; set; }
        public double DistanceTraveled { get; set; } = 0;
        public void CanMoveOrNot(double amountOfKm)
        {
            double fuelNeeded = FuelConsumedPerKm * amountOfKm;
            if (fuelNeeded > FuelAmount)
            {
                Console.WriteLine("Insufficient fuel for the drive");
                return;
            }
            FuelAmount -= fuelNeeded;
            DistanceTraveled += amountOfKm;
        }
        public override string ToString()
        {
            return $"{Model} {FuelAmount:f2} {DistanceTraveled}";
        }
    }
}