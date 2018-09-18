using Framework.TestStackWhite;
using System;
using System.IO;

namespace Framework.Utils
{
    public class DirectoryUtil
    {
        protected static Logger Log = Logger.Instance;

        private static object _syncRoot = new Object();

        public static void CreateDirectory(string dirPath)
        {
            lock (_syncRoot)
            {
                bool isExist = Directory.Exists(dirPath);

                if (!isExist)
                {
                    Log.Info($"Create new directory by path {dirPath}");
                    Directory.CreateDirectory(dirPath);
                }
            }            
        }
    }
}
