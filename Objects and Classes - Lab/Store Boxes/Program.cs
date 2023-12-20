namespace Store_Boxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            List<Box> boxes = new List<Box>();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] information = input.Split();

                Box box = new Box();
                box.Item.Name = information[1];
                box.Item.Price = double.Parse(information[3]);
                box.SerialNumber = int.Parse(information[0]);
                box.ItemQuantity = int.Parse(information[2]);
                box.PriceForBox = box.Item.Price * box.ItemQuantity;

                boxes.Add(box);
            }

            boxes = boxes.OrderByDescending(box => box.PriceForBox).ToList();

            foreach (Box box in boxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForBox:f2}");
            }
        }
    }

    public class Item
    {
        public string Name { get; set; }

        public double Price { get; set; }
    }

    public class Box
    {
        public Box()
        {
            Item = new Item();
        }
        public int SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public double PriceForBox { get; set; }
    }
}