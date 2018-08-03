using System;
using ToolHelper;

namespace ToolHelperTestNuget
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"123456:{MD5Helper.MD5("123456")}");
            Console.WriteLine("Hello World!");
            Console.Read();
        }
    }
}
