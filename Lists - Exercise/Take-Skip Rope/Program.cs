namespace Take_Skip_Rope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            List<string> charNumbers = new List<string>();
            List<string> chars = new List<string>();

            ListsAdd(text, charNumbers, chars);

            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();

            ListSplit(charNumbers, takeList, skipList);

            List<string> result = new List<string>();

            while (chars.Count > 0 && takeList.Count > 0)
            {
                for (int i = 0; i < takeList[0]; i++)
                {
                    result.Add(chars[0]);
                    chars.RemoveAt(0);
                    if (chars.Count == 0)
                    {
                        break;
                    }
                }
                if (chars.Count == 0)
                {
                    break;
                }

                takeList.RemoveAt(0);
                
                if (skipList.Count > 0)
                {
                    for (int i = 0; i < skipList[0]; i++)
                    {
                        chars.RemoveAt(0);
                        if (chars.Count == 0)
                        {
                            break;
                        }
                    }
                    skipList.RemoveAt(0);
                }               
            }


            Console.WriteLine(string.Join("",result));
        }

        static void ListSplit(List<string> charNumbers, List<int> takeList, List<int> skipList)
        {
            for (int i = 0; i < charNumbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(int.Parse(charNumbers[i]));
                }
                else
                {
                    skipList.Add(int.Parse(charNumbers[i]));
                }
            }
        }

        static void ListsAdd(string text, List<string> charNumbers, List<string> chars)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    charNumbers.Add(text[i].ToString());
                }
                else
                {
                    chars.Add(text[i].ToString());
                }
            }
        }
    }
}