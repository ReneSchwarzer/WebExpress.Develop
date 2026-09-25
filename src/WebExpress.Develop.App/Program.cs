using System.Reflection;
using WebExpress.WebCore;

/// <summary>
/// Serves as the entry point for the application.
/// </summary>
internal class Program
{
    /// <summary>
    /// The entry point of the WebExpress.
    /// </summary>
    /// <param name="args">Command-line arguments passed to the application.</param>
    /// <returns>The exit code, not zero when the application could not start.</returns>
    private static int Main(string[] args)
    {
        var app = new WebEx()
        {
            Name = Assembly.GetExecutingAssembly().GetName().Name
        };

        return app.Execution(args);
    }
}