using System.Configuration;

namespace Framework.TestStackWhite
{
    public class Configuration
    {
        /// <summary>
        /// get from app.config field ApplicationExePath
        /// </summary>
        public static string ApplicationExePath
        {
            get { return GetValue("ApplicationExePath"); }
        }

        /// <summary>
        /// get from app.config field MainWindowName
        /// </summary>
        public static string MainWindowName
        {
            get { return GetValue("MainWindowName"); }
        }

        /// <summary>
        /// get from app.config field ProcessName
        /// </summary>
        public static string ProcessName
        {
            get { return GetValue("ProcessName"); }
        }


        /// <summary>
        /// get from app.config field ImageFormat
        /// </summary>
        public static string ImageFormat
        {
            get { return GetValue("ImageFormat"); }
        }

        /// <summary>
        /// get from app.config field and converts into string
        /// </summary>
        protected static string GetValue(string key)
        {
            return GetEnviromentVar(key, ConfigurationManager.AppSettings.Get(key));
        }

        /// <summary>
        /// returns value of environment variable
        /// </summary>
        /// <param name="var">variable's name</param>
        /// <param name="defaultValue">default value, will be returned if env var was not setted</param>
        /// <returns>value of environment variable</returns>
        public static string GetEnviromentVar(string var, string defaultValue)
        {
            return System.Environment.GetEnvironmentVariable(var) ?? defaultValue;
        }
    }
}
