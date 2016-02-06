using System;
using System.Collections.Generic;
using System.Linq;

namespace GoogleCodeJams
{
    internal class Problem2
    {
        public static int Solver(int[] vector1, int[] vector2)
        {
            return VectorProduct(vector1.OrderBy(x => x), vector2.OrderByDescending(x => x));
        }

        public static int VectorProduct(IEnumerable<int> vector1, IEnumerable<int> vector2)
        {
            return vector1.Zip(vector2, (a, b) => a * b).Sum();
        }

        public static IEnumerable<VectorPairs> ParseFileText(string inputFile)
        {
            var problemLines = InputOutputHelper
                .ReadLines(inputFile)
                .Skip(1);            

            var linesEnumerator = problemLines.GetEnumerator();
            while (linesEnumerator.MoveNext())
            {
                linesEnumerator.MoveNext();
                var line1 = linesEnumerator.Current;
                linesEnumerator.MoveNext();
                var line2 = linesEnumerator.Current;

                yield return ParseProblem(line1,line2);
            }
        }

        private static VectorPairs ParseProblem(string line1, string line2)
        {
            return new VectorPairs(ParseVectorLineToNumbers(line1), ParseVectorLineToNumbers(line2));
        }

        private static IEnumerable<int> ParseVectorLineToNumbers(string line)
        {
            return line
                .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);
        }

        public static string SolutionsToText(IEnumerable<int> solutions)
        {
            return solutions
                .Select(i=>i.ToString())
                .ToOutputLines();
        }
    }
}
