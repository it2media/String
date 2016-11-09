using System;
using Xunit;
using IT2media.Extensions.String;

namespace Tests
{
    public class StringExtensionsTest
    {
        [Fact]
        public void GetHashCodeUShort_ReturnsDifferentHashCodesOnDifferentStrings() 
        {
            var hash1 = "hallo".GetHashCodeUShort();
            var hash2 = "halloo".GetHashCodeUShort();

            Console.Write(hash1);
            
            Console.Write(hash2);

            Assert.True(hash1 != hash2);
        }
    }
}
