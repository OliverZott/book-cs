using System.Diagnostics;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Instrumenting
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write to text file in project folder
            Trace.Listeners.Add(new TextWriterTraceListener(File.CreateText("log.txt")));
            // Text writer is buffered, this option calls Flush on all Listeners after writing
            Trace.AutoFlush = true;


            // Switching trace level
            // Used to build key/value based configuration settings for use in an application.
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            // Builds an Microsoft.Extensions.Configuration.IConfiguration with keys and values
            IConfigurationRoot configuration = builder.Build();

            // Provides a multilevel switch to control tracing and debug output
            var ts = new TraceSwitch(displayName: "TraceLevelSwitch Displayname", description: "This switch is set via a JSON config.");

            
            configuration.GetSection("TraceLevelSwitch7").Bind(ts);


            System.Console.WriteLine($"'TraceSwitch' instance called with: Name='{ts.DisplayName}', Description='{ts.Description}'");
            Trace.WriteLineIf(ts.TraceError, "Trace Error");
            Trace.WriteLineIf(ts.TraceWarning, "Trace Warning");
            Trace.WriteLineIf(ts.TraceInfo, "Trace Info");
            Trace.WriteLineIf(ts.TraceVerbose, "Trace Verbose");


            Debug.WriteLine("This is \"Debug\"");
            Trace.WriteLine("This is \"Trace\"");

        }
    }
}
