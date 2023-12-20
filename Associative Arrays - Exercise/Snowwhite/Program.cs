namespace Snowwhite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dwarf> dwarfs = new List<Dwarf>();
            Dictionary<string, DwarfHat> dwarfHats = new Dictionary<string, DwarfHat>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Once upon a time")
            {
                string[] dwarfDetails = input.Split(" <:> ");
                string dwarfName = dwarfDetails[0];
                string dwarfHatColor = dwarfDetails[1];
                int dwarfPhysics = int.Parse(dwarfDetails[2]);


                if (dwarfs.Select(x => x.Name).Contains(dwarfName) && dwarfs.Where(dwarf => dwarf.Name == dwarfName).Select(x => x.Hat.Color).Contains(dwarfHatColor))
                {
                    if (dwarfs.Single(x => x.Name == dwarfName && x.Hat.Color == dwarfHatColor).Physics < dwarfPhysics)
                    {
                        dwarfs.Single(x => x.Name == dwarfName && x.Hat.Color == dwarfHatColor).Physics = dwarfPhysics;
                    }
                }
                else
                {
                    DwarfHat dwarfHat = new DwarfHat(dwarfHatColor, 1);
                    if (dwarfHats.ContainsKey(dwarfHatColor))
                    {
                        dwarfHats[dwarfHatColor].Count++;
                    }
                    else
                    {
                        dwarfHats.Add(dwarfHatColor, dwarfHat);
                    }

                    Dwarf dwarf = new Dwarf(dwarfName, dwarfHats[dwarfHatColor], dwarfPhysics);
                    dwarfs.Add(dwarf);
                }


            }

            foreach (var dwarf in dwarfs.OrderByDescending(x => x.Physics).ThenByDescending(x => x.Hat.Count))
            {
                Console.WriteLine($"({dwarf.Hat.Color}) {dwarf.Name} <-> {dwarf.Physics}");
            }
        }

        public class Dwarf
        {
            public Dwarf(string name, DwarfHat hat, int physics)
            {
                Name = name;
                Hat = hat;
                Physics = physics;
            }

            public string Name { get; set; }
            public DwarfHat Hat { get; set; }
            public int Physics { get; set; }

        }
        public class DwarfHat
        {
            public DwarfHat(string name, int count)
            {
                Color = name;
                Count = count;
            }

            public string Color { get; set; }
            public int Count { get; set; }

        }
    }
}