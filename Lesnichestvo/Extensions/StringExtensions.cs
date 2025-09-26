using System.Security.Cryptography;
using System.Text;

namespace Lesnichestvo.Extensions
{
    public static class StringExtensions
    {
        public static string ToSHA1Hex(this string str)
        {
            byte[] encodedUFT8str = Encoding.UTF8.GetBytes(str);
            byte[] sha1str = SHA1.HashData(encodedUFT8str);
            return BitConverter.ToString(sha1str).Replace("-", "").ToLowerInvariant();
        }
    }
}
