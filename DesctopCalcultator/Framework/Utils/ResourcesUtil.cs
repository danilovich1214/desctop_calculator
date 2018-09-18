using Framework.TestStackWhite;
using System;
using System.IO;

namespace Framework.Utils
{
    public class ResourcesUtil
    {
        private static string BinPath { get; set; }
        public static string ScreenshotsFolder { get; set; }

        static ResourcesUtil()
        {
            BinPath = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;

            if (String.IsNullOrEmpty(BinPath))
                throw new Exception("Unable to find out the assembly codebase path");

            ScreenshotsFolder = Path.Combine(BinPath, "Screenshots");
        }

        public static string GetScreenshotPath(string screenName)
        {
            return Path.Combine(ScreenshotsFolder, $"{screenName}.{Configuration.ImageFormat}");
        }        
    }
}
