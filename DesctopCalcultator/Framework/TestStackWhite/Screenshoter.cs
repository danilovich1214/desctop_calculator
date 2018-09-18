using Framework.Utils;
using System;
using TestStack.White;

namespace Framework.TestStackWhite
{
    public class Screenshoter
    {
        protected static Logger Log = Logger.Instance;

        static Screenshoter()
        {
            DirectoryUtil.CreateDirectory(ResourcesUtil.ScreenshotsFolder);
        }

        private static string GetScreenshotName()
        {
            return DateTime.Now.ToString(CommonConstants.ScreenDateTimeFormat);
        }

        public static void TakeFullScreenshot()
        {
            string screenName = GetScreenshotName();
            Log.Info($"Take screenshot, screenshot name => {screenName}");            
            Desktop.CaptureScreenshot().Save(ResourcesUtil.GetScreenshotPath(screenName));
        }
    }
}
