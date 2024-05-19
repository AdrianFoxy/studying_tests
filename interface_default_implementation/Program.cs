namespace interface_default_implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger consoleLogger = new ConsoleLogger();
            consoleLogger.Log(LogLevel.Debug, "some event");
            consoleLogger.Log(LogLevel.Warning, "some warning");
            consoleLogger.Log(LogLevel.Fatal, "some fatal error");

            consoleLogger.Foo(); // Extension methods
            consoleLogger.LogError("some error"); // Default implemedted method in interface
        }
    }
}