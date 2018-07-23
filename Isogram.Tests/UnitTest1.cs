using System;
using Xunit;

namespace Isogram.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void EmptyStringTest()
        {
            Assert.True(Class1.IsoGram(""));
        }

        [Fact]
        public void LowerCaseIsogramTest()
        {
            Assert.True(Class1.IsoGram("isogram"));
        }

        [Fact]
        public void ElevenTest()
        {
            Assert.False(Class1.IsoGram("eleven"));
        }

        [Fact]
        public void LongEnglishWordTest()
        {
            Assert.True(Class1.IsoGram("subdermatoglyphic"));
        }

        [Fact]
        public void DuplicatedMixedCaseTest()
        {
            Assert.True(Class1.IsoGram("Alphabet"));
        }

        [Fact]
        public void HyphenWordTest()
        {
            Assert.True(Class1.IsoGram("thumbscrew-japingly"));
        }

        [Fact]
        public void DuplicatedHyphenCaseTest()
        {
            Assert.True(Class1.IsoGram("six-year-old"));
        }

        [Fact]
        public void SpaceTest()
        {
            Assert.True(Class1.IsoGram("abc xyz"));
        }
    }
}
