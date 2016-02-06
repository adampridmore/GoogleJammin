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
            return InputOutputHelper
                .ReadLines(inputFile)
                .Skip(1)
                .ChunkBySize(3)
                .Select(problem => ParseProblem(problem[1], problem[2]));
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
