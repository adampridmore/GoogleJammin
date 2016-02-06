using System;
using System.Collections.Generic;

namespace GoogleCodeJams
{
    public static class EnumerationHelper
    {
        public static IEnumerable<IEnumerable<T>> ChunkBySize<T>(this IEnumerable<T> seq, int chunkSize)
        {
            if (chunkSize <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(chunkSize), chunkSize.ToString());
            }

            var chunk = new List<T>();
            foreach (var t in seq)
            {
                if (chunk.Count == chunkSize)
                {
                    yield return chunk;
                    chunk = new List<T>();
                }

                chunk.Add(t);
            }

            if (chunk.Count > 0)
            {
                yield return chunk;
            }
        }
    }
}

