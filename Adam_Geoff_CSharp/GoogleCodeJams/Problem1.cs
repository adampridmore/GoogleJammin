using System;
using System.Linq;
using static System.String;

namespace GoogleCodeJams
{
    public class Problem1
    {
        public static string SentenceWordReverse(string text)
        {
            var words = text.Split(new[] {' '}, StringSplitOptions.None);
            return Join(" ", words.Reverse());
        }

        public static string Solver(string inputFile)
        {
            return InputOutputHelper
                .ReadLines(inputFile)
                .Skip(1)
                .Select(SentenceWordReverse)
                .ToOutputLines();
        }
    }
}
