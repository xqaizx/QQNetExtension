using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace XQ.NetExtension.Encrypt
{
    public class EncryptString
    {      

        public static string CrownJoe(string str, bool bo)
        {
            char[] chArray = str.ToCharArray();
            string str2 = "";
            string str3 = "";
            for (int i = 0; i < chArray.Length; i++)
            {
                str3 = Convert.ToBase64String(Encoding.UTF8.GetBytes(chArray[i].ToString()));
                if (bo)
                {

                    str3 = str3 + XRandom.Random(10, 0x63).ToString();
                }
                str2 = str2 + str3;
            }
            return str2;
        }



       


        public static string JoeCrown(string str, int t)
        {
            string str2 = "";
            try
            {
                char[] chArray = str.ToCharArray();
                string[] strArray =XString.ArrayListstr(str, t);
                for (int i = 0; i < strArray.Length; i++)
                {
                    byte[] bytes = Convert.FromBase64String(strArray[i].ToString().Substring(0, 4));
                    str2 = str2 + Encoding.UTF8.GetString(bytes);
                }
                return str2;
            }
            catch
            {
                return "异常信息";
            }
        }











    }
}
