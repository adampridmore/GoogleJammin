using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using NUnit.Framework;

namespace GoogleCodeJams
{
    [TestFixture]
    class Problem2Tests
    {
        [Test]
        public void Five_numbers()
        {
            Assert.That(Problem2.Solver(new[] {1, 2, 3, 4, 5}, new[] {1, 0, 1, 0, 1}), Is.EqualTo(6));
        }

        [Test]
        public void Three_numbers_with_negatives()
        {
            Assert.That(Problem2.Solver(new[] { 1,3,-5}, new[] { -2,4,1}), Is.EqualTo(-25));
        }

        [Test]
        public void Vector_product()
        {
            Assert.That(Problem2.VectorProduct(new[] { 1, 2, 3 }, new[] { 2,2,2}), Is.EqualTo(12));
        }

        [Test]
        public void parse_input_file()
        {
            var inputFile = @"2
3
1 3 -5
-2 4 1
5
1 2 3 4 5
1 0 1 0 1
";

            List<VectorPairs> vectorPairs = Problem2.ParseFileText(inputFile).ToList();
            Assert.That(vectorPairs.Count, Is.EqualTo(2));

            Assert.That(vectorPairs[0].First, Is.EqualTo(new[] {1, 3, -5}));
            Assert.That(vectorPairs[0].Second, Is.EqualTo(new[] { -2, 4,1}));
        }

        [Test]
        public void vectorsPair_list_to_output_text()
        {
            var solutions = new List<int> {1, -2};
            string expectedText = @"Case #1: 1
Case #2: -2";
            Assert.That(Problem2.SolutionsToText(solutions), Is.EqualTo(expectedText));
        }
    }

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

    internal class Problem2
    {
        public static int Solver(int[] vector1, int[] vector2)
        {
            return VectorProduct(vector1.OrderBy(x => x), vector2.OrderByDescending(x => x));
        }

        public static int VectorProduct(IEnumerable<int> vector1, IEnumerable<int> vector2)
        {
            return Enumerable.Zip(vector1, vector2, (a, b) => a * b).Sum();
        }

        public static IEnumerable<VectorPairs> ParseFileText(string inputFile)
        {
            var lines = inputFile.Split(new [] {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries);

            var problemLines = lines.Skip(1);

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
            return Problem1.ToOutputLines(solutions.Select(i=>i.ToString()));
        }
    }
}
