using System;
using System.Text;

namespace ToolHelper
{
    public class SHA1Helper
    {
        /// <summary>
        /// string to sha1 encrypt
        /// </summary>
        /// <param name="str">input string</param>
        /// <returns>sha1 result</returns>
        public static string SHA1(string str)
        {
            var bts = Encoding.UTF8.GetBytes(str);
            using (var m = System.Security.Cryptography.SHA1.Create())
            {
                var result = m.ComputeHash(bts);
                return BitConverter.ToString(result).Replace("-", "");
            }
        }
    }
}
