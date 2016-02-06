using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace GoogleCodeJams.Tests
{
    [TestFixture]
    public class EnumerationHelperTests
    {
        [Test]
        public void ChunkBySize_for_4_items_of_size_2_Test()
        {
            var chunks = new List<int> { 1, 2, 3,4 }
                .ChunkBySize(2)
                .ToList();
            
            Assert.That(chunks, Has.Count.EqualTo(2));

            Assert.That(chunks[0], Is.EqualTo(new List<int> {1,2}));
            Assert.That(chunks[1], Is.EqualTo(new List<int> {3,4 }));
        }

        [Test]
        public void ChunkBySize_for_3_items_of_size_2_Test()
        {
            var chunks = new List<int> { 1, 2, 3 }
                .ChunkBySize(2)
                .ToList();

            Assert.That(chunks, Has.Count.EqualTo(2));

            Assert.That(chunks[0], Is.EqualTo(new List<int> { 1, 2 }));
            Assert.That(chunks[1], Is.EqualTo(new List<int> { 3}));
        }

        [Test]
        public void ChunkBySize_for_empty_list()
        {
            var chunks = Enumerable.Empty<int>()
                .ChunkBySize(2)
                .ToList();

            Assert.That(chunks, Has.Count.EqualTo(0));
        }
    }
}
