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
        /// 日期转换字符串格式（yyyyMMdd）
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static string ToStryyyyMMdd(this DateTime @this)
        {
            return @this.ToString("yyyyMMdd");
        }

         
    }
}
