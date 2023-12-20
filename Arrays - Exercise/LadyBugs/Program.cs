namespace LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());

            int[] field = new int[fieldSize];
            long[] ladyBugs = Console.ReadLine().Split().Select(long.Parse).ToArray();

            for (int indexOfField = 0; indexOfField < fieldSize; indexOfField++)
            {
                for (int indexOfBugs = 0; indexOfBugs < ladyBugs.Length; indexOfBugs++)
                {
                    if (ladyBugs[indexOfBugs] == indexOfField)
                    {
                        field[indexOfField] = 1;
                    }
                }
            }

            bool end = false;

            while (!end)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    end = true;
                    break;
                }

                string[] command = input.Split().ToArray();
                int indexToPick = int.Parse(command[0]);
                string direction = command[1];
                long moves = long.Parse(command[2]);

                bool pickABug = false;

                if (indexToPick < fieldSize && indexToPick >= 0)
                {
                    if (field[indexToPick] == 1)
                    {
                        pickABug = true;
                        field[indexToPick] = 0;
                    }
                }
              
                long newIndexOfBug = indexToPick;

                if (pickABug)
                {

                    if (direction == "right")
                    {
                        newIndexOfBug += moves;
                    }
                    else
                    {
                        newIndexOfBug -= moves;
                    }
                }

                if (pickABug)
                {
                    while (newIndexOfBug < fieldSize && newIndexOfBug >= 0)
                    {

                        if (field[newIndexOfBug] == 0)
                        {
                            field[newIndexOfBug] = 1;
                            break;
                        }
                        else
                        {
                            if (direction == "right")
                            {
                                newIndexOfBug += moves;
                            }
                            else
                            {
                                newIndexOfBug -= moves;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}