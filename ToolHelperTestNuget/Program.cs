using System;
using ToolHelper;

namespace ToolHelperTestNuget
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine($"123456:{MD5Helper.MD5("123456")}");
            // Console.WriteLine($"123456:{SHA1Helper.SHA1("123456")}");
            //var info = "针孔摄象，你懂的";
            //Console.WriteLine($"{info}:{IllegalWordHelper.Filter(info)}");
            //var info = "针孔摄象，你懂的";
            //var selfFilter = "针孔|你懂的|怎么说";
            //Console.WriteLine($"{info}:{IllegalWordHelper.Filter(info, selfFilter)}");

            //Console.WriteLine($"123456:{AESHelper.Encrypt("123456")}");

            //Console.WriteLine($"ApZg+nlV6IEE+Cly2o9inQ==:{AESHelper.Decrypt("ApZg+nlV6IEE+Cly2o9inQ==")}");

            //var selfKey = "abcdefghijklmnop";
            //var selfIV = new byte[] { 0x7f, 0x0a, 0x2d, 0x96, 0x94, 0xa5, 0xc2, 0x7b, 0xaa, 0x89, 0x00, 0x8b, 0xf3, 0xab, 0x15, 0xfd, };
            //Console.WriteLine($"123456:{AESHelper.Encrypt("123456", selfKey, selfIV)}");
            //var selfKey = "abcdefghijklmnop";
            //var selfIV = new byte[] { 0x7f, 0x0a, 0x2d, 0x96, 0x94, 0xa5, 0xc2, 0x7b, 0xaa, 0x89, 0x00, 0x8b, 0xf3, 0xab, 0x15, 0xfd, };
            //Console.WriteLine($"Vju1+MLzN5VUlNua+HhMkA==:{AESHelper.Decrypt("Vju1+MLzN5VUlNua+HhMkA==", selfKey, selfIV)}");

            //Console.WriteLine($"123456,{CheckHelper.IsIDNumber("123456")}");
            //Console.WriteLine($"123456,{CheckHelper.IsMobile("123456")}");

            // Console.WriteLine($"针孔摄像头,{StringHelper.Substring("针孔摄像头", "针孔", "头")}");

            //Console.WriteLine($"时间戳：{TimeHelper.GetTimestamp()}");
            //Console.WriteLine($"时间：{TimeHelper.TimestampToDate("1533570979682")}");

            //var path = @"C:\Project\study\Study\ToolHelper\ToolHelperTestNuget\huge.jpg";
            //Console.WriteLine($"base64 string:{ImageHelper.ImageToBase64(path)}");
            var path = @"C:\Project\study\Study\ToolHelper\ToolHelperTestNuget\huge.jpg";
            ImageHelper.Base64ToImage(ImageHelper.ImageToBase64(path), "e:/images/hugehello.jpg");
            Console.Read();
        }
    }
}
