using System.IO;
using NUnit.Framework;

namespace GoogleCodeJams.Tests
{
    [TestFixture]
    public class Problem1Test
    {
        [Test]
        public void Reverse_the_worlds()
        {
            Assert.That(Problem1.SentenceWordReverse("this is a test"), Is.EqualTo("test a is this"));
        }

        [Test]
        public void Reverse_input_text()
        {
            const string inputFile = @"3
this is a test
foobar
all your base
";

            const string expectedOutput = @"Case #1: test a is this
Case #2: foobar
Case #3: base your all";

            Assert.That(Problem1.SolverToString(inputFile), Is.EqualTo(expectedOutput));
        }

        [Test]
        public void Process_small_file()
        {
            var input = File.ReadAllText("../../B-small-practice.in");
            var results = Problem1.Solver(input);
            File.WriteAllLines("../../B-small-practice.out", results);
        }

        [Test]
        public void Process_large_file()
        {
            var input = File.ReadAllText("../../B-large-practice.in");
            var results = Problem1.Solver(input);
            File.WriteAllLines("../../B-large-practice.out", results);
        }

        [Test]
        [Ignore]
        public void Process_vlarge_file()
        {
            var lines = File.ReadLines("../../E");
            var results = Problem1.Solver(lines, false);
            File.WriteAllLines("../../E.out", results);
        }
    }
}