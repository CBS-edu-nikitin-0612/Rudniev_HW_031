using System;
using System.Collections.Generic;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, double> collection1 = new Dictionary<int, double>();
            collection1.Add(1001, 90004000);
            collection1.Add(2301, 206800);

            SortedDictionary<int, double> collection2 = new SortedDictionary<int, double>();
            collection2.Add(1001, 90004000);
            collection2.Add(2301, 206800);
        }
    }
}
