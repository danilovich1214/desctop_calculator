using Framework.TestStackWhite;
using System.Diagnostics;

namespace Framework.Utils
{
    public class ProcessesUtil
    {
        protected static Logger Log = Logger.Instance;

        public static void CloseProcessesByName(string procName)
        {
            Log.Info($"Get processes by name '{procName}'");
            Process[] processes = Process.GetProcessesByName(procName);     

            if (processes.Length == 0)
            {
                Log.Info("There are no processes");
                return;
            }

            foreach (Process proc in processes)
            {
                Log.Info($"Close process '{proc.ProcessName}'");
                proc.CloseMainWindow();
                proc.Close();
            }
        }
    }
}
