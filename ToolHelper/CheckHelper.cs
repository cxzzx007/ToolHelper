using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ToolHelper
{
    public class CheckHelper
    {
        /// <summary>
        /// check is mobile
        /// </summary>
        /// <param name="mobile">mobile number</param>
        /// <returns>true is mobile or false notmobile</returns>
        public static bool IsMobile(string mobile)
        {
            return Regex.IsMatch(mobile, @"^1\d{10}$");
        }
        /// <summary>
        /// check is idnumber
        /// </summary>
        /// <param name="idnumber">id number</param>
        /// <returns>true is idnumber or false not idnumber</returns>
        public static bool IsIDNumber(string idnumber)
        {
            return Regex.IsMatch(idnumber, @"^(\d{15}$|^\d{18}$|^\d{17}(\d|X|x))$");
        }
        /// <summary>
        /// check is chinese name
        /// </summary>
        /// <param name="name">name</param>
        /// <returns>true is chinesename or false not chinesename</returns>
        public static bool IsChineseName(string name)
        {
            return Regex.IsMatch(name, @"^[\u2E80-\uFE4F\w\u00B7]{1,12}$");
        }
        /// <summary>
        /// 字符串仅能是中文
        /// </summary>
        /// <param name="chinese"></param>
        /// <returns></returns>
        public static bool IsChinese(string chinese)
        {
            return Regex.IsMatch(chinese, @"^[\\u4e00-\\u9fa5]{0,}$");
        }
        /// <summary>
        /// check is email
        /// </summary>
        /// <param name="email">email</param>
        /// <returns>true is email or false not email</returns>
        public static bool IsEmail(string email)
        {
            return Regex.IsMatch(email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }
        /// <summary>
        /// check is number
        /// </summary>
        /// <param name="number">number</param>
        /// <returns>true is number or false not number</returns>
        public static bool IsNumber(string number)
        {
            return Regex.IsMatch(number, @"^[0-9]*$");
        }
        /// <summary>
        /// check is carnumber
        /// </summary>
        /// <param name="carnumber">carnumber</param>
        /// <returns>true is carnumber or false not carnumber</returns>
        public static bool IsCarNumber(string carnumber)
        {
            string express = @"^[\u4e00-\u9fa5-\w]{1,10}$"; return Regex.IsMatch(carnumber, express);
        }

        /// <summary>
        /// 密码的强度必须是包含大小写字母和数字的组合，不能使用特殊字符，长度在8-10之间
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool IsStrongPassword(string password)
        {
            string express = @"^(?=.*\\d)(?=.*[a-z])(?=.*[A-Z]).{8,10}$";
            return Regex.IsMatch(password, express);
        }
        /// <summary>
        /// 由数字、字母、或下划线组成的字符串
        /// </summary>
        /// <param name="variable"></param>
        /// <returns></returns>
        public static bool IsVariable(string variable)
        {
            return Regex.IsMatch(variable, @"^\\w+$");
        }
    }
}
