using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XQ.NetExtension.NetExtension
{
    /// <summary>
    /// 数据库扩展类
    /// </summary>
    public static class DateTimeExtension
    {

        /// <summary>
        /// 当前日期转换字符串格式（yyyyMMdd）
        /// </summary>
        /// <returns></returns>
        public static string NowStrDate1()
        {
            return DateTime.Now.ToStrDate1();
        }

        /// <summary>
        /// 当前日期转换字符串格式（yyyy-MM-dd）
        /// </summary>
        /// <returns></returns>
        public static string NowStrDate2()
        {
            return DateTime.Now.ToStrDate2();
        }

        /// <summary>
        /// 日期转换字符串格式（yyyyMMdd）
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static string ToStrDate1(this DateTime @this)
        {
            return @this.ToString("yyyyMMdd");
        }

        /// <summary>
        /// 日期转换字符串格式（yyyy-MM-dd）
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static string ToStrDate2(this DateTime @this)
        {
            return @this.ToString("yyyy-MM-dd");
        }

        /// <summary>
        /// 日期转换字符串格式（HHmmss）
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static string ToStrTime1(this DateTime @this)
        {
            return @this.ToString("HHmmss");
        }

        /// <summary>
        /// 日期转换字符串格式（HH:mm:ss）
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static string ToStrTime2(this DateTime @this)
        {
            return @this.ToString("HH:mm:ss");
        }


        /// <summary>
        /// 日期转换字符串格式（yyyyMMddHHmmss）
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static string ToStrDateTime1(this DateTime @this)
        {
            return @this.ToString("yyyyMMddHHmmss");
        }

        /// <summary>
        /// 日期转换字符串格式（yyyy-MM-dd HH:mm:ss）
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static string ToStrDateTime2(this DateTime @this)
        {
            return @this.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
