using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IT2media.Extensions.String
{
    public static class StringExtensions
    {
        public static ushort GetHashCodeUShort(this string str)
        {
            return (ushort)str.GetHashCode();
        }
    }
}
