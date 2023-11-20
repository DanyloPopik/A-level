
namespace HW_27._10
{
    public class Logger
    {

        private static Logger instance;
        private List<string> LogEntries;
        private object mesegge;

        private Logger()
        {
            LogEntries = new List<string>();
        }
        public static Logger Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Logger();
                }
                return instance;
            }
        }

        public void Log(string LogType, string massege)
        {
            string LogEntry = $"{DateTime.Now}: {LogType}: {mesegge}";
            LogEntries.Add(LogEntry);
            Console.WriteLine(LogEntry);
        }
        public List<string> GetLogEntries()
        {
            return LogEntries;
        }
    }
}
