using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

using Renamer.Engine.Entities;

namespace Renamer.Front.Helpers
{
    internal class LogHelper
    {
        const int MAX_FILESIZE_MB = 10 * 1024 * 1024;

        const string DIRECTORY = "logs";
        const string FILENAME_LOG_01 = "logs\\logs_01.log";
        const string FILENAME_LOG_02 = "logs\\logs_02.log";

        private static readonly StringBuilder sb = new StringBuilder();

        public static void LogHeader(RenameSettings renameSettings)
        {
            sb.AppendLine("\r\n");
            sb.AppendLine("Rename Process - Date: " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + ", Type: " + renameSettings.RenameType + "\r\n");
            sb.AppendLine("**********************************************************************\r\n");
        }

        public static void LogInfo(string text)
        {
            sb.AppendLine(text);
        }

        public static void LogException(Exception ex)
        {
            sb.AppendLine(ex.Message + "\r\n");
        }

        public static Task SaveChangesAsync()
        {
            try
            {
                Directory.CreateDirectory(DIRECTORY);
                FileInfo fileInfo1 = new FileInfo(FILENAME_LOG_01);

                using (var sw = fileInfo1.AppendText())
                {
                    // logging
                    sw.WriteLine(sb.ToString());
                    sw.Close();

                    // log files rotation
                    if (fileInfo1.Length > MAX_FILESIZE_MB)
                    {
                        File.Create(FILENAME_LOG_02).Close();
                        fileInfo1.Replace(FILENAME_LOG_02, null, true);
                    }
                }

                sb.Clear();

                return Task.CompletedTask;
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
