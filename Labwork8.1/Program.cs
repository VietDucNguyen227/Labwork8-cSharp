using System;

namespace Labwork8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pair<String> pair = new Pair<string>("An", "Nga");
            Console.WriteLine("({0},{1})", pair.First, pair.Second);
            Console.ReadLine();
        }
    }
}
