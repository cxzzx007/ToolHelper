using System;
using System.Text;

namespace ToolHelper
{
    public class MD5Helper
    {
        /// <summary>
        /// string to md5 encrypt
        /// </summary>
        /// <param name="str">input string</param>
        /// <returns>md5 result</returns>
        public static string MD5(string str)
        {
            var bts = Encoding.UTF8.GetBytes(str);
            using (var m = System.Security.Cryptography.MD5.Create())
            {
                var result = m.ComputeHash(bts);
                return BitConverter.ToString(result).Replace("-", "");
            }
        }
    }
}
