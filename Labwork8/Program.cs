using System;
using System.Collections.Generic;

namespace Labwork8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> inv = new List<Car>();
            //add elements to the list
            inv.Add(new Car("A", 5.9, 3));
            inv.Add(new Car("B", 8.2, 2));
            inv.Add(new Car("C", 3.5, 4));
            inv.Add(new Car("D", 1.8, 8));
            Console.WriteLine("Product list: ");
            foreach (Car item in inv)
            {
                Console.WriteLine(" " + item);
            }
        }
    }
}
