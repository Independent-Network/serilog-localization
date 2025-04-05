using Serilog;
using Serilog.Localization;
using TestApp.Resources;
Console.OutputEncoding = System.Text.Encoding.UTF8;
Log.Logger = new LoggerConfiguration()
    .WithLocalization(typeof(Resource),"zh-CN")
    .MinimumLevel.Debug()
    .WriteTo.Console()
    .CreateLogger();
Log.Logger.DebugL("log");
