using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionCloser.Helpers
{
    public class LogHelper
    {
        public static void WriteLog(string methodName, string message)
        {
            try
            {
                string serviceLog = "///////////////////[" + DateTime.Now + "]///////////////////" + Environment.NewLine;
                serviceLog += methodName + "' - " + message;
                serviceLog += Environment.NewLine;

                if (!Directory.Exists(ConfigurationManager.AppSettings["LogFilePath"]))
                {
                    Directory.CreateDirectory(ConfigurationManager.AppSettings["LogFilePath"]);
                }

                string path = Path.Combine(ConfigurationManager.AppSettings["LogFilePath"], "SessionCloser_" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt");
                if (Directory.Exists(ConfigurationManager.AppSettings["LogFilePath"]))
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
            catch (Exception ex)
            {
                ErrorLogHelper.WriteLog(ex);
            }
        }
        public static void WriteMultiLog(string methodName, string message)
        {
            try
            {
                string serviceLog = "///////////////////[" + DateTime.Now + "]///////////////////" + Environment.NewLine;
                serviceLog += methodName;
                serviceLog += Environment.NewLine;
                serviceLog += message;
                serviceLog += Environment.NewLine;

                if (!Directory.Exists(ConfigurationManager.AppSettings["LogFilePath"]))
                {
                    Directory.CreateDirectory(ConfigurationManager.AppSettings["LogFilePath"]);
                }

                string path = Path.Combine(ConfigurationManager.AppSettings["LogFilePath"], "SessionCloser_" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt");
                if (Directory.Exists(ConfigurationManager.AppSettings["LogFilePath"]))
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
            catch (Exception ex)
            {
                ErrorLogHelper.WriteLog(ex);
            }
        }
    }
}
