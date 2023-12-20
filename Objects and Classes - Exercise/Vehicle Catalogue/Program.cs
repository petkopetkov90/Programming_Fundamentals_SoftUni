using System.Diagnostics.CodeAnalysis;

namespace Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<Vehicle> vehicles = new List<Vehicle>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] information = input.Split()
                    .ToArray();

                string type;
                if (information[0] == "car")
                {
                    type = "Car";
                }
                else
                {
                    type = "Truck";
                }
                Vehicle vehicle = new Vehicle();
                vehicle.Type = type;
                vehicle.Model = information[1];
                vehicle.Color = information[2];
                vehicle.HorsePower = int.Parse(information[3]);
                vehicles.Add(vehicle);
            }

            while ((input = Console.ReadLine()) != "Close the Catalogue")
            {
                int index = vehicles.FindIndex(vehicle => vehicle.Model == input);
                Console.WriteLine(vehicles[index]);
            }

            Console.WriteLine($"Cars have average horsepower of: {AverageHorsePower(vehicles, "Car"):f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {AverageHorsePower(vehicles, "Truck"):f2}.");
        }

        static double AverageHorsePower(List<Vehicle> vehicles, string type)
        {
            double sum = 0;
            int count = 0;
            for (int i = 0; i < vehicles.Count; i++)
            {
                if (vehicles[i].Type == type)
                {
                    count++;
                    sum += vehicles[i].HorsePower;
                }
            }
            if (sum == 0)
            {
                return 0;
            }
            return (sum / count);
        }
    }

    public class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
        public override string ToString()
        {
            return $"Type: {Type}\n" +
                $"Model: {Model}\n" +
                $"Color: {Color}\n" +
                $"Horsepower: {HorsePower}";
        }
    }
}