using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        //[Fact]
        //public void ShouldTestParse()
        //{
            //Arrange
            //Act
            //Assert
            //dont need this fact!
       // }
        // TODO: Complete Something, if anything


        [Theory]
        //[InlineData(-84.677017, 34.073638)]
        [InlineData(-84.677017, 34.073638, "Taco Bell Acwort... (Free trial * Add to Cart for a full POI info)")]
        // [InlineData("1234,1234,1234")]
        public void ShouldParse(string line)
        {
            var parser = new TacoParser();

            var actual = parser.Parse(line);

            Assert.NotNull(actual);

            // TODO: Complete Should Parse
        }

        [Theory]
        [InlineData("null")]
        [InlineData("")]
        [InlineData("a,1")]
        public void ShouldFailParse(string line)
        {
            var parser = new TacoParser();

            var actual = parser.Parse(line);

            Assert.Null(actual);

            // TODO: Complete Should Fail Parse

        }
    }
}
