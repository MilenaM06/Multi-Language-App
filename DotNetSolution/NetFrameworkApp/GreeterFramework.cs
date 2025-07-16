using Serilog;

namespace NetFrameworkApp
{
    public class GreeterFramework
    {
        public string SayHello()
        {
            Log.Information(".NET Framework Project Log - class GreeterFramework - SayHello() was called");
            return "Hello from .NET Framework Project!";
        }
    }
}
