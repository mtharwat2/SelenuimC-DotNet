using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using SmartPatrolFramework.Configuration;

namespace SmartPatrolFramework.Helpers
{
    public class LogHelper
    {

        // log file (Global Declaration - dynamic)
        private static string _logFileName = string.Format("{0:yyyymmddhhmmss}", DateTime.Now);
        private static StreamWriter _streamw = null;



        //Create a file which can store the log information
        public static void CreateLogFile()
        {
            //String dir = @"d:\SmartPatrolLogFile\";
            //String dir = Settings.LogPath;

            //if (Directory.Exists(dir))
            //{
            //    _streamW = File.AppendText(dir + _logFileName + ".log");
            //}
            //else
            //{
            //    Directory.CreateDirectory(dir);
            //    _streamW = File.AppendText(dir + _logFileName + ".log");
            //}
        }


        // create a method which can write the test in the log file
        public static void Write(String logMessage)
        {
            //_streamW.Write("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            //_streamW.WriteLine("     {0}", logMessage);
            //_streamW.Flush();
        }


    }
}
