using System;
using System.Collections.Generic;
using System.Text;

namespace XQ.NetExtension
{
    /// <summary>
    /// 随机数方法
    /// </summary>
    public class XRandom
    {
        /// <summary>
        /// 生产随机数
        /// </summary>
        /// <param name="strNum"></param>
        /// <returns></returns>
        public static string GetRandomNum(int strNum)
        {
            Random random = new Random();
            return random.Next(Convert.ToInt32(Math.Pow(10.0, (double)strNum))).ToString();
        }


        /// <summary>
        /// 生成指定范围的随机数
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static int Random(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

    }
}
