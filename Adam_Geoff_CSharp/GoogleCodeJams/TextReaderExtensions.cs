using System.Collections.Generic;
using System.IO;

namespace GoogleCodeJams
{
    public static class TextReaderExtensions
    {
        public static IEnumerable<string> ReadLines(this TextReader reader)
        {
            for (var line = reader.ReadLine(); line != null; line = reader.ReadLine())
            {
                yield return line;
            }
        }
    }
}
