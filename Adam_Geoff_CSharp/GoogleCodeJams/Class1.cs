using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using NUnit.Framework;
using static System.String;

namespace GoogleCodeJams
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
            var inputFile = @"3
this is a test
foobar
all your base
";

            var expectedOutput = @"Case #1: test a is this
Case #2: foobar
Case #3: base your all";

            Assert.That(Problem1.Solver(inputFile), Is.EqualTo(expectedOutput));
        }

        [Test]
        public void Process_small_file()
        {
            var input = File.ReadAllText("../../B-small-practice.in");
            var results = Problem1.Solver(input);
            File.WriteAllText("../../B-small-practice.out", results);
        }

        [Test]
        public void Process_large_file()
        {
            var input = File.ReadAllText("../../B-large-practice.in");
            var results = Problem1.Solver(input);
            File.WriteAllText("../../B-large-practice.out", results);
        }
    }

    public class Problem1
    {
        public static string SentenceWordReverse(string text)
        {
            var words = text.Split(new[] {' '}, StringSplitOptions.None);
            return Join(" ", words.Reverse());
        }

        public static string Solver(string inputFile)
        {
            var lines = inputFile.Split(new [] {Environment.NewLine,"\r","\n"}, StringSplitOptions.RemoveEmptyEntries)
                .Skip(1);

            var reversedLines =  lines.Select(SentenceWordReverse);

            return ToOutputLines(reversedLines);
        }
        public static string ToOutputLines(IEnumerable<string> lines)
        {
            var numbers = Enumerable.Range(1, lines.Count());

            var outputLines = Enumerable.Zip(numbers, lines, (lineCount, line) => $"Case #{lineCount}: {line}");
            return Join(Environment.NewLine, outputLines);
        }
    }
}
