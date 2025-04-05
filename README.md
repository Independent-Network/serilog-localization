# serilog-localization

A set of extensive methods that is able to complete the localization of serilog, using resx file to store localization strings

# Usage

## Step 1 : Create your localization resources

Create a folder in your project which contains the localization strings. For example, you can create `Resources.resx`(default),`Resources.zh-CN.resx`(Chinese) and `Resources.en-US.resx`.

## Step 2 : Fill in your localization strings

You can use `debug.`,`info.`,`verbose.`,`error.`,`warning.`as key's prefix in default, or you can customize a prefix later

## Step 3 : Initialize the Extension

You can enable localization like this

```csharp
Log.Logger = new LoggerConfiguration()
    .WithLocalization(new ResourceManager(typeof(Your_Designer_Class),"zh-CN"))
    .MinimumLevel.Debug()
    .WriteTo.Console()
    .CreateLogger();
```

Unfortunately, the extension doesn't support runtime culture change, but it might be accessible in the future.
