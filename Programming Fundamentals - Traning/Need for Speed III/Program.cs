namespace Need_for_Speed_III
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < numbersOfCars; i++)
            {
                string[] carDetails = Console.ReadLine().Split("|");
                string carType = carDetails[0];
                int mileage = int.Parse(carDetails[1]);
                int fuel = int.Parse(carDetails[2]);
                if (fuel > 75)
                {
                    fuel = 75;
                }
                Car car = new Car(carType, mileage, fuel);
                cars.Add(car);
            }

            string input;
            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] commands = input.Split(" : ");
                string command = commands[0];
                string carType = commands[1];
                Car currentCar = cars.FirstOrDefault(x => x.Type == carType);

                if (command == "Drive")
                {
                    int distance = int.Parse(commands[2]);
                    int fuel = int.Parse(commands[3]);
                    DriveCar(cars, currentCar, distance, fuel);
                    if (currentCar.Mileage >= 100000)
                    {
                        Console.WriteLine($"Time to sell the {currentCar.Type}!");
                        cars.Remove(currentCar);
                    }
                }
                else if (command == "Refuel")
                {
                    int fuel = int.Parse(commands[2]);
                    RefillTheTank(cars, currentCar, fuel);
                }
                else if (command == "Revert")
                {
                    int kilometers = int.Parse(commands[2]);
                    RevertKilometers(cars, currentCar, kilometers);
                }
            }

            Console.WriteLine(string.Join("\n", cars));
        }

        private static void RevertKilometers(List<Car> cars, Car currentCar, int kilometers)
        {
            currentCar.Mileage -= kilometers;
            if (currentCar.Mileage < 10000)
            {
                currentCar.Mileage = 10000;
                return;
            }

            Console.WriteLine($"{currentCar.Type} mileage decreased by {kilometers} kilometers");
        }

        private static void RefillTheTank(List<Car> cars, Car currentCar, int fuel)
        {
            int refueledAmount = fuel;
            currentCar.Fuel += fuel;
            if (currentCar.Fuel > 75)
            {
                refueledAmount -= currentCar.Fuel - 75;
                currentCar.Fuel = 75;
            }

            Console.WriteLine($"{currentCar.Type} refueled with {refueledAmount} liters");
        }

        private static void DriveCar(List<Car> cars, Car currentCar, int distance, int fuel)
        {
            if (currentCar.Fuel < fuel)
            {
                Console.WriteLine("Not enough fuel to make that ride");
                return;
            }

            currentCar.Fuel -= fuel;
            currentCar.Mileage += distance;
            Console.WriteLine($"{currentCar.Type} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
        }
    }

    class Car
    {
        public Car(string type, int mileage, int fuel)
        {
            Type = type;
            Mileage = mileage;
            Fuel = fuel;
        }

        public string Type { get; set; }
        public int Mileage { get; set; }
        public int Fuel { get; set; }

        public override string ToString()
        {
            return $"{Type} -> Mileage: {Mileage} kms, Fuel in the tank: {Fuel} lt.";
        }
    }
}
