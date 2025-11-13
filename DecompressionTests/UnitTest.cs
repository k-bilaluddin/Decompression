using DeCodify;

namespace DecompressionTests
{
    public class UnitTest
    {
        [Theory]
        [InlineData("a3b2c1", "aaabbc")]
        [InlineData("ab2cd0ef1", "ababef")]
        [InlineData("xyz12", "xyzxyzxyzxyzxyzxyzxyzxyzxyzxyzxyzxyz")]
        [InlineData("hello0world1", "world")]
        [InlineData("x0", "")]
        [InlineData("123456", "")]
        public void DecodeString_WorksCorrectly(string input, string expected)
        {
            var decoder = new Decompression();
            Assert.Equal(expected, decoder.DecodeString(input));
        }
    }
}