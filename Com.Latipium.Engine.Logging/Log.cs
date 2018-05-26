using System;

namespace Com.Latipium.Engine.Logging {
    public static class Log {
        public const string Startup = "Startup";

        public static void Write(LogLevel level, string source, string message) {
            DateTime time = DateTime.Now;
            Console.WriteLine("[{0:D2}:{1:D2}:{2:D2}.{3:D3}] [{4,7}] [{5,10}] {6}",
                    time.Hour, time.Minute, time.Second, time.Millisecond,
                    level.ToString().ToUpper(), source, message);
        }

        public static void Write(LogLevel level, string source, string message, params string[] args) {
            Write(level, source, string.Format(message, args));
        }

        public static void Error(string source, string message) {
            Write(LogLevel.Error, source, message);
        }

        public static void Error(string source, string message, params string[] args) {
            Write(LogLevel.Error, source, message, args);
        }

        public static void Warning(string source, string message) {
            Write(LogLevel.Warning, source, message);
        }

        public static void Warning(string source, string message, params string[] args) {
            Write(LogLevel.Warning, source, message, args);
        }

        public static void Info(string source, string message) {
            Write(LogLevel.Info, source, message);
        }

        public static void Info(string source, string message, params string[] args) {
            Write(LogLevel.Info, source, message, args);
        }

        public static void Debug(string source, string message) {
            Write(LogLevel.Debug, source, message);
        }

        public static void Debug(string source, string message, params string[] args) {
            Write(LogLevel.Debug, source, message, args);
        }
    }
}
