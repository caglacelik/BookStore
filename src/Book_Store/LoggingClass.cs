using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using System.IO;

namespace Book_Store
{
    /**   
     * @brief    This file includes order operations.
     */
    public static class LoggingClass
    {
        public static TimeZone localZone;
        public static DateTime currentDate;

        public static DateTime currentUTC;
        public static TimeSpan currentOffset;

        public static string Date;
        public static string Log;
        private static string fileName = "Logs.txt";

        /// <summary>
        /// This function does everything of the log proccess.
        /// </summary>
        /// <param name="Name">The name of customer.</param>
        /// <param name="BtnName">The text of the button</param>
        /// <returns> This function does not return a value </returns>
        public static void WriteLogWithButton(string Name ,string BtnName)
        {
            ClearCurrentLog();
            CurrentTime();
            LogFormat(Name, BtnName);
            writeLogToFile(Log);
        }

        /// <summary>
        /// This function does everything of the log proccess.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        public static void CurrentTime()
        {
            localZone = TimeZone.CurrentTimeZone;
            currentDate = DateTime.Now;
            currentUTC = localZone.ToUniversalTime(currentDate);
            currentOffset = localZone.GetUtcOffset(currentDate);
        }

        /// <summary>
        /// This function formats the log that is required.
        /// </summary>
        /// <param name="Name">The name of customer.</param>
        /// <param name="BtnName">The text of the button</param>
        /// <returns> This function does not return a value </returns>
        public static void LogFormat(string Name,string BtnName)
        {
            Log += "Customer : "+ Name + " ";
            Date = "Date: " + currentUTC + " UTC:" + currentOffset;
            Log += Date + " Button Name : " + BtnName;
        }

        /// <summary>
        /// This function clears the log string.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        public static void ClearCurrentLog()
        {
            Date = "";
            Log = "";
        }

        /// <summary>
        /// This function writes the log to the file.
        /// </summary>
        /// <param name="log">The full log string.</param>
        /// <returns> This function does not return a value </returns>
        public static void writeLogToFile(string log)
        {

            using (FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine(log);
            }
        }
    }
}
