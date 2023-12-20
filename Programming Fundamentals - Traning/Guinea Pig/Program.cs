namespace Guinea_Pig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numbersStack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            Console.WriteLine(numbersStack.Peek());
        }
    }
}
