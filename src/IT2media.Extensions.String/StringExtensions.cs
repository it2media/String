﻿namespace IT2media.Extensions.String
{
    public static class StringExtensions
    {
        /// <summary>
        /// Removes all leading occurrences of a given string from the current string object
        /// </summary>
        /// <param name="s"></param>
        /// <param name="trimString"></param>
        /// <returns></returns>
        public static string TrimStart(this string s, string trimString)
        {
            if (s == null) return null;
            if (string.IsNullOrEmpty(trimString)) return s;

            while (s.StartsWith(trimString))
            {
                s = s.Remove(0, trimString.Length);
            }

            return s;
        }

        /// <summary>
        /// Returns a ushort hash code for this string (for example useful for autogenerating EventIDs for the Windows Event Log based on the message string)
        /// </summary>
        /// <param name="s">the string</param>
        /// <returns>A ushort hash code</returns>
        public static ushort GetHashCodeUShort(this string s)
        {
            return (ushort)GetHashCodeInternal(s);
        }

        private static int GetHashCodeInternal(string s)
        {
            // This hash code is a simplified version of 
            // the GetHashCode() used in CoreFX Release 1.1.0 
            // https://github.com/dotnet/corefx/blob/release/1.1.0/src/Common/src/System/Text/StringOrCharArray.cs

            int count = s.Length;

            int hash1 = (5381 << 16) + 5381;
            int hash2 = hash1;

            for (int i = 0; i < count; ++i)
            {
                int c = s[i];
                hash1 = ((hash1 << 5) + hash1) ^ c;

                if (++i >= count)
                    break;

                c = s[i];
                hash2 = ((hash2 << 5) + hash2) ^ c;
            }

            return hash1 + (hash2 * 1566083941);
        }
    }
}
