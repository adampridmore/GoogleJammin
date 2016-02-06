using System;
using System.Collections.Generic;
using System.IO;
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

        public static IEnumerable<string> Solver(IEnumerable<string> lines, bool skipFirstLine = true)
        {
            var skipCount = skipFirstLine ? 1:0;

            return lines
                .Skip(skipCount)
                .Select(SentenceWordReverse)
                .ToOutputLines();
        }

        public static IEnumerable<string> Solver(string inputText)
        {
            return Solver(new StringReader(inputText).ReadLines());
        }

        public static string SolverToString(string inputText)
        {
            return Join(Environment.NewLine, Solver(inputText));
        }
    }
}
