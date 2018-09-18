using log4net;
using log4net.Config;

namespace Framework.TestStackWhite
{
    public class Logger
    {
        private readonly ILog _log;
        private static Logger _instance;
    
        public static readonly string LogDelimiter = "::";                         

        private Logger()
        {
            XmlConfigurator.Configure();
            _log = LogManager.GetLogger("Console");
        }

        public static Logger Instance => _instance ?? (_instance = new Logger());

        public void Fail(string message)
        {
            _log.Fatal(message);            
        }

        public void Info(string message)
        {
            _log.Info(message);
        }
        
        public void Debug(string message)
        {
            _log.Debug(message);
        }

        public void Warn(string message)
        {
            _log.Warn(message);
        }

        public void Error(string message)
        {
            _log.Error(message);
        }
    }
}
