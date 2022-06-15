using System;

namespace Labwork8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String a = "a";
            String b = "b";
            Swap<String>(ref a, ref b);
            Console.WriteLine(a + " " + b);
        }
        static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
    }
}
