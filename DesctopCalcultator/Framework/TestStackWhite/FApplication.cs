using TestStack.White;
using TestStack.White.UIItems.WindowItems;

namespace Framework.TestStackWhite
{
    public class FApplication: BaseEntity
    {   
        private static FApplication _currentInstance;
        private static Application _currentAppInstance;
        private static Window _currentWindow;

        public Window CurrentWindow => _currentWindow;
        public Application Application => _currentAppInstance;

        public static FApplication Instance
        {
            get { return _currentInstance ?? (_currentInstance = new FApplication()); }
        }        

        private FApplication()
        {
            
        }

        public void SwitchToMainWindow()
        {
            SwitchToWindow(Configuration.MainWindowName);
        }

        public void SwitchToWindow(string windowName)
        {
            Info($"Switch to window '{windowName}'");
            _currentWindow = Application.GetWindow(windowName);
        }

        public void LaunchApplication()
        {
            string appPath = Configuration.ApplicationExePath;
            Info($"Launching application by path {appPath}");
            try
            {
                _currentAppInstance = Application.Launch(appPath);
            }
            catch (WhiteException e)
            {
                Fatal("Application was not running. " + e.Message);
            }
            
            SwitchToMainWindow();
        }

        public void CloseApplication()
        {
            if (_currentAppInstance != null)
            {
                Info("Closing application");
                _currentAppInstance.Close();
                _currentAppInstance.Dispose();
                _currentAppInstance = null;
            }            
        }

        protected override string FormatLogMsg(string message)
        {
            return message;
        }
    }
}
