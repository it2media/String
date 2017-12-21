using Xunit;

namespace IT2media.Extensions.String.Test
{
    public class StringExtensionsTest
    {
        [Fact]
        public void GetHashCodeUShort_ReturnsDifferentHashCodesOnDifferentStrings() 
        {
            var hash1 = "hello".GetHashCodeUShort();
            var hash2 = "helloo".GetHashCodeUShort();

            Assert.True(hash1 != hash2);
        }

        [Theory]
        [InlineData("hahaha")]
        [InlineData("")]
        public void TrimStart_LoopTestUntilEmpty(string value)
        {
            var result = value.TrimStart("ha");

            Assert.True(result == string.Empty);
        }

        [Theory]
        [InlineData("hahahafinished")]
        public void TrimStart_LoopTestUntilAllDone(string value)
        {
            var result = value.TrimStart("ha");

            Assert.True(result == "finished");
        }

        [Theory]
        [InlineData(null)]
        public void TrimStart_InputNullOutputNull(string value)
        {
            var result = value.TrimStart("ha");

            Assert.True(result == null);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void TrimStart_TrimWithNullOrEmptyReturnsOriginalString(string value)
        {
            var result = "input".TrimStart(value);

            Assert.True(result == "input");
        }
    }
}
