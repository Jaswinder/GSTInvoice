using System;
using System.IO;
using System.Linq;
using System.Text;

namespace ErrorLogger
{
    public class Log
    {
        private readonly string LogFolderPath;

        private static string LogFileName;

        private Log(LOGTYPE logtype)
        {
            LogFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\GleamBillLog\\";

            switch (logtype)
            {
                case LOGTYPE.GLEAMBILLERROR:
                    LogFileName = "GleamBillErrorLog_";
                    break;
                case LOGTYPE.DBUPGRADE:
                    LogFileName = "GleamBillDBUpgradeErrorLog_";
                    break;
            }
        }

        public static void Write(LOGTYPE logType, string message)
        {
            Log log = new Log(logType);
            log.WriteLogFile(message);
        }

        public static void Write(LOGTYPE logType, Exception message)
        {
            Log log = new Log(logType);
            log.WriteLogFile(log.CreateErrorMessage(message));
        }

        private string CreateErrorMessage(Exception exception)
        {
            StringBuilder messageBuilder = new StringBuilder();

            try
            {
                messageBuilder.AppendLine();
                messageBuilder.Append(DateTime.Now + " - " + exception.TargetSite);
                messageBuilder.Append("Error Message : " + exception.ToString());

                if (exception.InnerException != null)
                    messageBuilder.Append("InnerException :: " + exception.InnerException.ToString());

                messageBuilder.AppendLine();
                messageBuilder.Append("-------------------");
                return messageBuilder.ToString();
            }
            catch
            {
                messageBuilder.AppendLine();
                messageBuilder.Append("Exception:: Unknown Exception.");
                messageBuilder.AppendLine();
                messageBuilder.Append("-------------------");
                return messageBuilder.ToString();
            }
        }

        private void WriteLogFile(string message)
        {
            try
            {
                if (!Directory.Exists(LogFolderPath))
                    Directory.CreateDirectory(LogFolderPath);

                string logFilePath = Path.Combine(LogFolderPath, LogFileName + DateTime.Now.ToString("ddMMyyyy") + ".txt");
                int filecount = new DirectoryInfo(LogFolderPath).GetFileSystemInfos().Where(x => x.FullName.Contains(LogFileName)).Count();

                if (filecount >= 7 && !File.Exists(logFilePath))
                {
                    FileSystemInfo fileInfo = new DirectoryInfo(LogFolderPath).GetFileSystemInfos().Where(x => x.FullName.Contains(LogFileName)).OrderByDescending(fi => fi.CreationTime).Last();
                    File.Delete(fileInfo.FullName);
                }

                if (!File.Exists(logFilePath)) File.Create(logFilePath).Dispose();

                File.AppendAllText(logFilePath, DateTime.Now + " - " + message + Environment.NewLine);
            }
            catch (Exception) { }
        }
    }

    public enum LOGTYPE { DBUPGRADE, GLEAMBILLERROR }
}
