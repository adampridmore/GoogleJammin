using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Int32;

namespace GoogleCodeJams
{
    static class InputOutputHelper
    {
        public static IEnumerable<string> ToOutputLines(this IEnumerable<string> lines)
        {
            return Enumerable
                .Range(1, MaxValue)
                .Zip(lines, (lineCount, line) => $"Case #{lineCount}: {line}")
                ;
        }

        public static string ToOutputLinesString(this IEnumerable<string> lines)
        {
            return string.Join(Environment.NewLine, lines.ToOutputLines());
        }

        public static void ToOutputLinesTextWriter(this IEnumerable<string> lines, TextWriter textWriter)
        {
            foreach(string line in lines.ToOutputLines())
            {
                textWriter.Write(line);
            }
        }
    }
}