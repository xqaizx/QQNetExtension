using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XQ.NetExtension.NetExtension
{
    /// <summary>
    /// 字符串扩展类
    /// </summary>
    public static class StringExtension
    {
        /// <summary>
        /// 去除字符串最后一个字符
        /// </summary>
        /// <param name="input">字符串</param>
        /// <param name="ch">最后字符</param>
        /// <returns>处理后的字符串</returns>
        public static string SubLastChar(this string @this, char ch)
        {
            if (@this.IsNullOrWhiteSpace()) return @this;
            if (@this.IndexOf(ch) < 0) return @this;

            @this = @this.Substring(0, @this.LastIndexOf(ch));
            return @this;
        }

        /// <summary>
        /// 验证String是否为空
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static bool IsNullOrWhiteSpace(this string @this)
        {
            return string.IsNullOrWhiteSpace(@this);
        }


        /// <summary>
        /// 将字符串截取成定长的字串
        /// </summary>
        /// <param name="str"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string[] ArrayListstr(this string @this, int length)
        {

            string[] strArray;
            try
            {
                if (length <= 0)
                {
                    length = @this.Length;
                }
                int num = 0;
                num = @this.Length / length;
                if (num <= 0)
                {
                    num = 1;
                }
                strArray = new string[num];
                for (int i = 0; i < num; i++)
                {
                    strArray[i] = @this.Substring(length * i, length);
                }
            }
            catch
            {
                strArray = new string[] { "异常信息" };
            }
            return strArray;
        }


    }
}
