using System;
using System.Collections.Generic;
using System.Text; 
using System.IO;


namespace XQ.NetExtension.XLog
{
    public class XLogManager : IDisposable
    {
        private string logPath = string.Empty;
        private FileStream fs = null;
        private StreamWriter sw = null;

        private static XLogManager instance;
        private static object o = new object();

        private XLogManager()
        {
            try
            {
                string dicPath = string.Format(@"{0}\log", System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase);
                string fileName = string.Format("FileManager{0}.log", DateTime.Now.ToString("yyyyMMddHH"));
                logPath = string.Format(@"{0}\{1}", dicPath, fileName);
                if (!Directory.Exists(dicPath))
                {
                    Directory.CreateDirectory(dicPath);
                }
                if (!File.Exists(logPath))
                {

                    using (fs = new FileStream(logPath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                    {
                        using (sw = new StreamWriter(fs))
                        {
                            sw.WriteLine("创建日志:" + (DateTime.Now.ToString()));
                            sw.Flush();
                        }
                    }
                }
            }
            catch (System.Exception es)
            { 
                Console.WriteLine(es.Message);
            }
        }

        private static XLogManager GetInstance()
        {
            if (instance == null)
            {
                lock (o)
                {
                    if (instance == null)
                    {
                        instance = new XLogManager();
                    }
                }
            }
            return instance;
        }

        
        public static void LogError(Exception e)
        {
            instance = GetInstance();
            if (instance != null)
            {
                instance.XLogError(e);
            }
        }

        public static void LogError(string errormsg)
        {
            instance = GetInstance();
            if (instance != null)
            {
                instance.XLogError(errormsg);
            }
        }

        public static void LogInfo(string errormsg)
        {
            instance = GetInstance();
            if (instance != null)
            {
                instance.XLogInfo(errormsg);
            }
        }

        private void XLogInfo(string message){
            using (fs = new FileStream(logPath, FileMode.Append, FileAccess.Write))
            {
                using (sw = new StreamWriter(fs))
                {
                    sw.WriteLine(String.Format("FileManager Info:  DataTime-{0}  Info-{1}", DateTime.Now.ToString(), message));
                    sw.Flush();
                }
            }
        }



        private void XLogError(Exception ex)
        {
            XLogError(ex.Message);
        }

        private void XLogError(string errormsg)
        {
            using (fs = new FileStream(logPath, FileMode.Append, FileAccess.Write))
            {
                using (sw = new StreamWriter(fs))
                {
                    sw.WriteLine(String.Format("FileManager Error: DataTime-{0}  Message-{1}", DateTime.Now.ToString(), errormsg));
                    sw.Flush();
                }
            }
        }

        #region IDisposable 成员

        public void Dispose()
        {
            if (fs != null && sw != null)
            {
                try
                {
                    sw.Close();
                    fs.Close();
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
            }
        }

        #endregion
    }
}
