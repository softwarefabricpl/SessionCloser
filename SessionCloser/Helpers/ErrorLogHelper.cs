using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionCloser.Helpers
{
    public class ErrorLogHelper
    {
        public static void WriteLog(Exception ex)
        {
            try
            {
                string serviceLog = "///////////////////[" + DateTime.Now + "]///////////////////" + Environment.NewLine;
                serviceLog += "Message: " + ex.Message;
                if (!string.IsNullOrEmpty(ex.StackTrace))
                    serviceLog += Environment.NewLine + "StackTrace: " + ex.StackTrace;
                 
                serviceLog += Environment.NewLine;

                if (!Directory.Exists(ConfigurationManager.AppSettings["ErrerLogFilePath"]))
                {
                    Directory.CreateDirectory(ConfigurationManager.AppSettings["ErrerLogFilePath"]);
                }

                string path = Path.Combine(ConfigurationManager.AppSettings["ErrerLogFilePath"], "SessionCloser_" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt");
                if (Directory.Exists(ConfigurationManager.AppSettings["ErrerLogFilePath"]))
                {
                    using (var fs = new FileStream(path, FileMode.OpenOrCreate))
                    {
                        using (var str = new StreamWriter(fs))
                        {
                            str.BaseStream.Seek(0, SeekOrigin.End);
                            str.WriteLine(serviceLog);
                            str.Flush();
                        }
                    }
                }
            }
            catch
            {
            }
        }

        public static void WriteLog(string methodName, string message)
        {
            try
            {
                string serviceLog = "///////////////////[" + DateTime.Now + "]///////////////////" + Environment.NewLine;
                serviceLog += methodName + "' - " + message;
                serviceLog += Environment.NewLine;

                if (!Directory.Exists(ConfigurationManager.AppSettings["ErrerLogFilePath"]))
                {
                    Directory.CreateDirectory(ConfigurationManager.AppSettings["LErrerLogFilePathogFilePath"]);
                }

                string path = Path.Combine(ConfigurationManager.AppSettings["ErrerLogFilePath"], "SessionCloser_" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt");
                if (Directory.Exists(ConfigurationManager.AppSettings["ErrerLogFilePath"]))
                {
                    using (var fs = new FileStream(path, FileMode.OpenOrCreate))
                    {
                        using (var str = new StreamWriter(fs))
                        {
                            str.BaseStream.Seek(0, SeekOrigin.End);
                            str.WriteLine(serviceLog);
                            str.Flush();
                        }
                    }
                }

            }
            catch
            {
            }
        }
    }
}
