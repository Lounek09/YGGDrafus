using System;
using System.IO;
using System.Text;

namespace YGGDrafus
{
    static class Logger
    {
        public static void Log(string line)
        {
            UnicodeEncoding uniencoding = new UnicodeEncoding();

            string logFilePath = Constant.Instance.LOG_PATH + "yggdrafus_log-" + DateTime.Now.ToString("MMddyyyy") + ".txt";
            string timestamp = "[" + DateTime.Now.ToString("HH:mm:ss:ffff") + "]";

            byte[] result = uniencoding.GetBytes(timestamp + line.Replace("\r", string.Empty).Replace("\n", string.Empty) + Environment.NewLine);

            using (FileStream SourceStream = File.Open(logFilePath, FileMode.OpenOrCreate))
            {
                SourceStream.Seek(0, SeekOrigin.End);
                SourceStream.Write(result, 0, result.Length);
            }


        }
    }
}
