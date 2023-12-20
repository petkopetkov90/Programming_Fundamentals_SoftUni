namespace Raw_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < totalCars; i++)
            {
                string[] carDetails = Console.ReadLine()
                    .Split()
                    .ToArray();

                Engine engine = new Engine(int.Parse(carDetails[1]), int.Parse(carDetails[2]));
                Cargo cargo = new Cargo(int.Parse(carDetails[3]), carDetails[4]);

                Car car = new Car(carDetails[0], engine, cargo);
                cars.Add(car);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                foreach (Car car in cars)
                {
                    if (car.Cargo.CargoWeight < 1000 && car.Cargo.CargoType == "fragile")
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
            else if (command == "flamable")
            {
                foreach (Car car in cars)
                {
                    if (car.Engine.EnginePower > 250 && car.Cargo.CargoType == "flamable")
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
        }
    }

    public class Car
    {
        public Car(string model, Engine engine, Cargo cargo)
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
    }
    public class Engine
    {
        public Engine(int engineSpeed, int enginePower)
        {
            EngineSpeed = engineSpeed;
            EnginePower = enginePower;
        }

        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }
    }
    public class Cargo
    {
        public Cargo(int cargoWeight, string cargoType)
        {
            CargoWeight = cargoWeight;
            CargoType = cargoType;
        }

        public int CargoWeight { get; set; }
        public string CargoType { get; set; }
    }
}