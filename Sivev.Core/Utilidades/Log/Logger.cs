namespace Sivev.Core.Utilidades.Log {
    public class Logger : IDisposable {
        private readonly string _logFilePath;
        private readonly StreamWriter _writer;

        public Logger(string moduleName) {
            var logDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LogProcesos");
            Directory.CreateDirectory(logDir);
            _logFilePath = Path.Combine(logDir, $"{moduleName}_{DateTime.Now:yyyyMMdd_HHmmss}.log");
            _writer = new StreamWriter(_logFilePath, true) { AutoFlush = true };
        }

        public void Log(string library, string method, string message) {
            string timestamp = DateTime.Now.ToString("HH:mm:ss.fff");
            _writer.WriteLine($"{timestamp} | {library} | {method} | {message}");
        }

        public void Dispose() {
            _writer?.Dispose();
        }
    }
}
