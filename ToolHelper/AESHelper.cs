using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ToolHelper
{
    public class AESHelper
    {
        /// <summary>
        /// key
        /// </summary>
        private static string Key
        {
            get
            {
                return "16a1d2522f1Xe5c4nM9cDbcZ25bc13c1";
            }
        }
        /// <summary>
        /// iv
        /// </summary>
        private static byte[] IV
        {
            get
            {
                return new byte[] { 0x7f, 0x0a, 0x2d, 0x96, 0x94, 0xa5, 0xc2, 0x7b, 0xaa, 0x89, 0x00, 0x8b, 0xf3, 0xab, 0x15, 0xfd, };
            }
        }
        /// <summary>
        /// aes encrypt
        /// </summary>
        /// <param name="str">input string</param>
        /// <returns>aes encrypt result</returns>
        public static string Encrypt(string str)
        {
            try
            {
                return Encrypt(str, Key, IV);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        /// <summary>
        /// aes encrypt
        /// </summary>
        /// <param name="str">input string</param>
        /// <param name="key">your private key length 16 or 32</param>
        /// <param name="iv">your private iv lenght 16</param>
        /// <returns>aes encrypt result</returns>
        public static string Encrypt(string str, string key = "", byte[] iv = null)
        {
            try
            {
                key = string.IsNullOrEmpty(key) ? Key : key;
                iv = iv == null ? IV : iv;
                using (var aes = Rijndael.Create())
                {
                    byte[] inputByteArray = Encoding.UTF8.GetBytes(str);
                    aes.Key = Encoding.UTF8.GetBytes(key);
                    aes.IV = iv;
                    byte[] cipherBytes = null;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            cs.Write(inputByteArray, 0, inputByteArray.Length);
                            cs.FlushFinalBlock();
                            cipherBytes = ms.ToArray();
                            cs.Close();
                            ms.Close();
                        }
                    }
                    return Convert.ToBase64String(cipherBytes);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// aes decrypt
        /// </summary>
        /// <param name="str">input string</param>
        /// <returns></returns>
        public static string Decrypt(string str)
        {
            try
            {
                return Decrypt(str, Key, IV);
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// aes decrypt
        /// </summary>
        /// <param name="str">input string</param>
        /// <param name="key">encrypt key</param>
        /// <param name="iv">encrypt iv</param>
        /// <returns>aes decrypt result</returns>
        public static string Decrypt(string str, string key = "", byte[] iv = null)
        {
            key = string.IsNullOrEmpty(key) ? Key : key;
            iv = iv == null ? IV : iv;
            using (var aes = Rijndael.Create())
            {
                byte[] cipherText = Convert.FromBase64String(str);
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;
                byte[] decryptBytes = new byte[cipherText.Length];
                using (MemoryStream ms = new MemoryStream(cipherText))
                {
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Read))
                    {
                        cs.Read(decryptBytes, 0, decryptBytes.Length);
                        cs.Close();
                        ms.Close();
                    }
                }
                return Encoding.UTF8.GetString(decryptBytes).Replace("\0", "");
            }
        }
    }
}
