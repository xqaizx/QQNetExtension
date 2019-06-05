using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XQ.NetExtension.Encrypt
{
    public class htmlEncrypt
    {


        /// 编码单引号
        /// </summary>
        /// <param name="str">需要处理的单引号</param>
        /// <returns>处理后的</returns>
        public static string Encoding(string str)
        {
            str = str.Replace("'", "&xq");
            return str;
        }

        /// <summary>
        /// 解码单引号
        /// </summary>
        /// <param name="str">需要解码的单引号</param>
        /// <returns>处理后的</returns>
        public static string Decoding(string str)
        {
            if (str != null)
            {
                str = str.Replace("&xq", "'");
            }
            return str;
        }
    }
}