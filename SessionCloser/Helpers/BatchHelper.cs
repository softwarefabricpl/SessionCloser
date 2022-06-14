using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionCloser.Helpers
{
    public class BatchHelper
    {

        public static string WriteManualBatch(string content)
        {
            try
            {
                if (!Directory.Exists(ConfigurationManager.AppSettings["BatchFilePath"]))
                {
                    Directory.CreateDirectory(ConfigurationManager.AppSettings["BatchFilePath"]);
                }

                string path = Path.Combine(ConfigurationManager.AppSettings["BatchFilePath"], "killmanualbatch.bat");
                if (Directory.Exists(ConfigurationManager.AppSettings["BatchFilePath"]))
                {
                    using (var fs = new FileStream(path, FileMode.OpenOrCreate))
                    {
                        using (var str = new StreamWriter(fs))
                        {
                            str.BaseStream.Seek(0, SeekOrigin.End);
                            str.WriteLine(content);
                            str.Flush();
                        }
                    }
                }

                return path;

            }
            catch (Exception ex)
            {
                ErrorLogHelper.WriteLog(ex);
            }

            return string.Empty;
        }
        public static string WriteBatch(string content)
        {
            try
            {
                if (!Directory.Exists(ConfigurationManager.AppSettings["BatchFilePath"]))
                {
                    Directory.CreateDirectory(ConfigurationManager.AppSettings["BatchFilePath"]);
                }

                string path = Path.Combine(ConfigurationManager.AppSettings["BatchFilePath"], "killbatch.bat");
                if (Directory.Exists(ConfigurationManager.AppSettings["BatchFilePath"]))
                {
                    using (var fs = new FileStream(path, FileMode.OpenOrCreate))
                    {
                        using (var str = new StreamWriter(fs))
                        {
                            str.BaseStream.Seek(0, SeekOrigin.End);
                            str.WriteLine(content);
                            str.Flush();
                        }
                    }
                }

                return path;

            }
            catch (Exception ex)
            {
                ErrorLogHelper.WriteLog(ex);
            }

            return string.Empty;
        }
    }
}
