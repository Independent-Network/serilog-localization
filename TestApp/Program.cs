using Serilog;
using Serilog.Localization;
using TestApp.Resources;
Console.OutputEncoding = System.Text.Encoding.UTF8;
Log.Logger = new LoggerConfiguration()
    .WithLocalization(typeof(Resource),"zh-CN")
    .MinimumLevel.Debug()
    .WriteTo.Console()
    .CreateLogger();
CultureManager.Current = new System.Globalization.CultureInfo("en-US");
Log.Logger.DebugL("log");
