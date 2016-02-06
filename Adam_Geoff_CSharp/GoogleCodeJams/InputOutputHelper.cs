using System;
using System.Collections.Generic;
using System.Linq;
using static System.Int32;
using static System.String;

namespace GoogleCodeJams
{
    static class InputOutputHelper
    {
        public static string ToOutputLines(this IEnumerable<string> lines)
        {
            var numbers = Enumerable.Range(1, MaxValue);

            var outputLines = numbers.Zip(lines, (lineCount, line) => $"Case #{lineCount}: {line}");

            return Join(Environment.NewLine, outputLines);
        }

        public static string[] ReadLines(string inputFile)
        {
            return inputFile.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}