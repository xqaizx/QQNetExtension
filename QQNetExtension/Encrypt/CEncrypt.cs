using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace XQ.NetExtension.Encrypt
{
    /// <summary>
    /// 加密码类
    /// </summary>
    public class CEncrypt
    {
        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public static string DesEncrypt(string inputString)
        {
            return DesEncrypt(inputString, Key);
        }
        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public static string DesDecrypt(string inputString)
        {
            return DesDecrypt(inputString, Key);
        }
        /// <summary>
        /// 密匙
        /// </summary>
        private static string Key
        {
            get
            {
                return "union009";
            }
        }
        /// <summary>
        /// 加密字符串
        /// 注意:密钥必须为８位
        /// </summary>
        /// <param name="strText">字符串</param>
        /// <param name="encryptKey">密钥</param>
        /// <param name="encryptKey">返回加密后的字符串</param>
        public static string DesEncrypt(string inputString, string encryptKey)
        {
            byte[] byKey = null;
            byte[] IV = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };
            try
            {
                byKey = System.Text.Encoding.UTF8.GetBytes(encryptKey.Substring(0, 8));
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                byte[] inputByteArray = Encoding.UTF8.GetBytes(inputString);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(byKey, IV), CryptoStreamMode.Write))
                    {
                        cs.Write(inputByteArray, 0, inputByteArray.Length);
                        cs.FlushFinalBlock();
                        return Convert.ToBase64String(ms.ToArray());
                    } 
                }

            }
            catch (System.Exception error)
            { 
                return null;
            }
        }
        /// <summary>
        /// 解密字符串
        /// </summary>
        /// <param name="this.inputString">加了密的字符串</param>
        /// <param name="decryptKey">密钥</param>
        /// <param name="decryptKey">返回解密后的字符串</param>
        public static string DesDecrypt(string inputString, string decryptKey)
        {
            byte[] byKey = null;
            byte[] IV = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };
            byte[] inputByteArray = new Byte[inputString.Length];
            try
            {
                byKey = System.Text.Encoding.UTF8.GetBytes(decryptKey.Substring(0, 8));
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                inputByteArray = Convert.FromBase64String(inputString);
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(byKey, IV), CryptoStreamMode.Write);
                cs.Write(inputByteArray, 0, inputByteArray.Length);
                cs.FlushFinalBlock();
                System.Text.Encoding encoding = new System.Text.UTF8Encoding();
                return encoding.GetString(ms.ToArray());
            }
            catch (System.Exception error)
            {
                //return error.Message;
                return null;
            }
        }



        /// <summary>
        /// 加密
        /// </summary>        
        public static string Encype(string str)
        {
            string temp = string.Empty;
            if (!string.IsNullOrEmpty(str))
            {
                str = Key + str + Key;
                char[] chars = str.ToCharArray();
                char ch;
                for (int i = 0; i < chars.Length; i++)
                {
                    ch = chars[i];
                    ch = (char)(((int)ch + 5));
                }

                temp = new string(chars);
            }
            return temp;
        }

        /// <summary>
        /// 解密
        /// </summary>        
        public static string DEncype(string str)
        {

            string temp = string.Empty;
            if (!string.IsNullOrEmpty(str))
            {
                char[] chars = str.ToCharArray();
                char ch;
                for (int i = 0; i < chars.Length; i++)
                {
                    ch = chars[i];
                    ch = (char)(((int)ch - 5));
                }
                temp = new string(chars).Replace(Key, "");
            }
            return temp;
        }
    }
}
