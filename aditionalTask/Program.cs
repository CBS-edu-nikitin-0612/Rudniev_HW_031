using System;
using System.Collections;

namespace aditionalTask
{
    class AlphabetComparer : IComparer
    {
        CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();
        public int Compare(object x, object y)
        {
            return comparer.Compare(x, y);
        }
    }
    class ReverseAlphabetComparer : IComparer
    {
        CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();
        public int Compare(object x, object y)
        {
            return comparer.Compare(y, x);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            var sort = new SortedList(new CaseInsensitiveComparer())
            {
                { "Rudniev Vladyslav", "city Bucha, st. Komarova, house 8"},
                { "Mologoko Irina", "city Kiev, st. Shevchenko, house 113"},
                { "Zaiko Svetlana", "city Bucha, st. Ostrovskogo, house 20"},
            };
            sort.Add("Druman Oleg", "city Irpin, st. Mira, house 56, ap. 248");

            Console.WriteLine("Sorted collection to alphbet: ");
            
            foreach (DictionaryEntry element in sort)
                Console.WriteLine($"'{element.Key}' - '{element.Value}'");

            var reverseSort = new SortedList(sort, new ReverseAlphabetComparer());

            Console.WriteLine("\nSorted collection to reverse alphbet: ");
            foreach (DictionaryEntry element in reverseSort)
                Console.WriteLine($"'{element.Key}' - '{element.Value}'");
        }
    }
}
