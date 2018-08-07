using System;
using System.Collections.Generic;
using System.Text;

namespace ToolHelper
{
    public static class Extensions
    {
        public static string MD5(this ToolHelper toolHelper, string str)
        {
            return MD5Helper.MD5(str);
        }

    }
}
