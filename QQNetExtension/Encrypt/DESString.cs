﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace XQ.NetExtension.Encrypt
{
    /// <summary> 
    /// 加密
    /// </summary> 
    public class DESString
    {
        //默认密钥向量
        private static byte[] Keys = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };

        /// <summary>
        /// DES加密字符串
        /// </summary>
        /// <param name="encryptString">待加密的字符串</param>
        /// <param name="encryptKey">加密密钥,要求为8位</param>
        /// <returns>加密成功返回加密后的字符串,失败返回源串</returns>
        public static string Encode(string encryptString, string encryptKey)
        {
            encryptKey = XString.GetSubString(encryptKey, 8, "");
            encryptKey = encryptKey.PadRight(8, ' ');

            byte[] rgbKey = Encoding.UTF8.GetBytes(encryptKey.Substring(0, 8));
            byte[] rgbIV = Keys;
            byte[] inputByteArray = Encoding.UTF8.GetBytes(encryptString);
            DESCryptoServiceProvider dCSP = new DESCryptoServiceProvider();
            MemoryStream mStream = new MemoryStream();
            CryptoStream cStream = new CryptoStream(mStream, dCSP.CreateEncryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
            cStream.Write(inputByteArray, 0, inputByteArray.Length);
            cStream.FlushFinalBlock();
            return Convert.ToBase64String(mStream.ToArray());

        }

        /// <summary>
        /// DES解密字符串
        /// </summary>
        /// <param name="decryptString">待解密的字符串</param>
        /// <param name="decryptKey">解密密钥,要求为8位,和加密密钥相同</param>
        /// <returns>解密成功返回解密后的字符串,失败返源串</returns>
        public static string Decode(string decryptString, string decryptKey)
        {
            try
            {
                decryptKey = XString.GetSubString(decryptKey, 8, "");
                decryptKey = decryptKey.PadRight(8, ' ');
                byte[] rgbKey = Encoding.UTF8.GetBytes(decryptKey);
                byte[] rgbIV = Keys;
                byte[] inputByteArray = Convert.FromBase64String(decryptString);
                DESCryptoServiceProvider DCSP = new DESCryptoServiceProvider();

                MemoryStream mStream = new MemoryStream();
                CryptoStream cStream = new CryptoStream(mStream, DCSP.CreateDecryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
                cStream.Write(inputByteArray, 0, inputByteArray.Length);
                cStream.FlushFinalBlock();
                return Encoding.UTF8.GetString(mStream.ToArray());
            }
            catch
            {
                return "";
            }
        }




        /// <summary>
        /// 编码单引号
        /// </summary>
        /// <param name="str">需要处理的单引号</param>
        /// <returns>处理后的</returns>
        public static string XEncoding(string str)
        {
            str = str.Replace("'", "&xq");
            return str;
        }

        /// <summary>
        /// 解码单引号
        /// </summary>
        /// <param name="str">需要解码的单引号</param>
        /// <returns>处理后的</returns>
        public static string XDecoding(string str)
        {
            if (str != null)
            {
                str = str.Replace("&xq", "'");
            }
            return str;
        }

        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="instr"></param>
        /// <returns></returns>
        public static string encryptMD5(string instr)
        {
            try
            {
                byte[] bytes = Encoding.Default.GetBytes(instr);
                MD5CryptoServiceProvider provider = new MD5CryptoServiceProvider();
                return BitConverter.ToString(provider.ComputeHash(bytes)).ToLower().Replace("-", "");
            }
            catch
            {
                return "";
            }
        }
    }

}
