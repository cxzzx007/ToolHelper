using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ToolHelper
{
    public class StringHelper
    {
        /// <summary>
        /// substring by start and end
        /// </summary>
        /// <param name="str">input string</param>
        /// <param name="start">start string</param>
        /// <param name="end">end string</param>
        /// <returns>substring by start and end rsult</returns>
        public static string Substring(string str, string start, string end)
        {
            Regex rg = new Regex($"(?<=({start}))[.\\s\\S]*?(?=({end}))", RegexOptions.Multiline | RegexOptions.Singleline);
            return rg.Match(str).Value;
        }
    }
}
