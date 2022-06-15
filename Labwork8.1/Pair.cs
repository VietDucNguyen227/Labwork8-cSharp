using System;
using System.Collections.Generic;
using System.Text;

namespace Labwork8._1
{
    internal class Pair<T>
    {
        private T first;
        private T second;

        public Pair(T first, T second)
        {
            this.first = first;
            this.second = second;
        }
        public T First { get { return first; } }
        public T Second { get { return second; } }
    }
}
