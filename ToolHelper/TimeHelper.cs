using System;
using System.Collections.Generic;
using System.Text;

namespace ToolHelper
{
    public class TimeHelper
    {
        /// <summary>
        /// unix timestamp  length 13
        /// </summary>
        /// <returns>timestamp</returns>
        public static string GetTimestamp()
        {
            DateTime dtStart = TimeZoneInfo.ConvertTime(new DateTime(1970, 1, 1), TimeZoneInfo.Local); 
            DateTime dtNow = DateTime.Now;
            return ((long)(dtNow - dtStart).TotalMilliseconds).ToString();
        }
        /// <summary>
        /// convert timestamp to datetime
        /// </summary>
        /// <param name="timestamp">unix timestamp length 13</param>
        /// <returns>datetime</returns>
        public static DateTime TimestampToDate(string timestamp)
        {
            DateTime dtStart = TimeZoneInfo.ConvertTime(new DateTime(1970, 1, 1), TimeZoneInfo.Local);
            long lTime = long.Parse(timestamp + "0000");
            TimeSpan toNow = new TimeSpan(lTime);
            return dtStart.Add(toNow);
        }
    }
}
