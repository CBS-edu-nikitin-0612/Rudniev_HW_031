using System;
using System.Collections.Specialized;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            NameValueCollection shopList = new NameValueCollection();
            shopList.Add("Vladyslav Rudniev", "tomato");
            shopList.Add("Vladyslav Rudniev", "potato");
            shopList.Add("Druman Oleg", "tomato");
            shopList.Add("Druman Oleg", "potato");

            Console.WriteLine("values by name 'Vladyslav Rudniev': ");
            Console.WriteLine(shopList.Get("Vladyslav Rudniev"));

            Console.WriteLine("Names by value 'tomato': ");
            for (int i = 0; i < shopList.Count; i++)
                if (shopList.Get(i).Contains("tomato"))
                    Console.WriteLine(shopList.GetKey(i));
        }
    }
}
