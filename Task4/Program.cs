using System.Collections;
using System.Collections.Specialized;

namespace Task4
{
    class MyComparer : IEqualityComparer
    {
        CaseInsensitiveComparer caseInsensitiveComparer = new CaseInsensitiveComparer();
        public new bool Equals(object x, object y)
        {
            return caseInsensitiveComparer.Compare(x, y) == 0;
        }

        public int GetHashCode(object obj)
        {
            return obj.ToString().ToLower().GetHashCode();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            OrderedDictionary collection = new OrderedDictionary(new MyComparer());

        }
    }
}
