using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Compression;
using System.IO;

namespace ToolHelper
{
    public class FileHelper
    {
        /// <summary>
        /// zip file
        /// </summary>
        /// <param name="sourcePath">file path to zip</param>
        /// <param name="zipPath">zip file path</param>
        public static void Zip(string sourcePath, string zipPath)
        {
            ZipFile.CreateFromDirectory(sourcePath, zipPath);
        }
        /// <summary>
        /// exact file
        /// </summary>
        /// <param name="zipPath">zip file path</param>
        /// <param name="exactPath">exact file path</param>
        public static void UnZip(string zipPath, string exactPath)
        {
            ZipFile.ExtractToDirectory(zipPath, exactPath);
        }
        /// <summary>
        /// read text file as streamreader
        /// </summary>
        /// <param name="path">file path</param>
        /// <returns>streamreader</returns>
        public static StreamReader ReadText(string path)
        {
            return new StreamReader(path, Encoding.Default);
        }
        /// <summary>
        /// read text file as string
        /// </summary>
        /// <param name="path">file path</param>
        /// <returns>file string</returns>
        public static string ReadTextString(string path)
        {
            return File.ReadAllText(path);
        }
    }
}
