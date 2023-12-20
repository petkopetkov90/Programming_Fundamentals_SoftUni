namespace Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Catalog catalog = new Catalog();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] vehicleDetails = input.Split("/");

                if (vehicleDetails[0] == "Car")
                {
                    Car car = new Car();
                    car.Brand = vehicleDetails[1];
                    car.Model = vehicleDetails[2];
                    car.HorsePower = int.Parse(vehicleDetails[3]);
                    catalog.Cars.Add(car);
                }
                else
                {
                    Truck truck = new Truck();
                    truck.Brand = vehicleDetails[1];
                    truck.Model = vehicleDetails[2];
                    truck.Weight = int.Parse(vehicleDetails[3]);
                    catalog.Trucks.Add(truck);
                }
            }

            catalog.Cars = catalog.Cars.OrderBy(car => car.Brand).ToList();
            catalog.Trucks = catalog.Trucks.OrderBy(truck => truck.Brand).ToList();

            Console.WriteLine("Cars:");
            foreach (Car car in catalog.Cars)
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }
            Console.WriteLine("Trucks:");
            foreach (Truck truck in catalog.Trucks)
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }
    }

    public class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }
    public class Catalog
    {
        public Catalog()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
        public int Total { get; set; }
    }
}