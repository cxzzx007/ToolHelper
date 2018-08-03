using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ToolHelper
{
    public class ImageHelper
    {
        /// <summary>
        ///image file convert to byte array
        /// </summary>
        /// <param name="path">image path</param>
        /// <returns>byte array result</returns>
        public static Byte[] ImageToByteArray(string path)
        {
            try
            {
                using (var fs = File.OpenRead(path))
                {
                    int filelength = 0;
                    filelength = (int)fs.Length;
                    Byte[] imagebyte = new Byte[filelength];
                    fs.Read(imagebyte, 0, filelength);
                    fs.Close();
                    return imagebyte;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// image file convert to base64 string
        /// </summary>
        /// <param name="path">image path</param>
        /// <returns>base64 string result</returns>
        public static string ImageToBase64(string path)
        {
            try
            {
                var byteArr = ImageToByteArray(path);
                return Convert.ToBase64String(byteArr);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
