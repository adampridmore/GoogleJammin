using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace GoogleCodeJams.Tests
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
}