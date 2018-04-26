using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Theory]
        [InlineData("-84.677017, 34.073638, \"Taco Bell Acwort... (Free trial * Add to Cart for a full POI info)\"")]
        [InlineData("-84.677017, 34.073638")]
        public void ShouldParse(string line)
        {
            var parser = new TacoParser();

            var actual = parser.Parse(line);

            Assert.NotNull(actual);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("a,1")]
        [InlineData("abc,abc,abc")]
        [InlineData("1234,1234,1234")]
        public void ShouldFailParse(string line)
        {
            var parser = new TacoParser();

            var actual = parser.Parse(line);

            Assert.Null(actual);
        }
    }
}
