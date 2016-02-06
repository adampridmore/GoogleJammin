using System.Collections.Generic;

namespace GoogleCodeJams
{
    internal class VectorPairs
    {
        public IEnumerable<int> First { get; }
        public IEnumerable<int> Second { get; }

        public VectorPairs(IEnumerable<int> first, IEnumerable<int> second)
        {
            First = first;
            Second = second;
        }
    }
}