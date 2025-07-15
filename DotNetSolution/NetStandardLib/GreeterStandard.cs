using Serilog;

namespace NetStandardLib
{
    public class GreeterStandard
    {
        public static string SayHello()
        {          
            Log.Information(".NET Standard Project Log - class GreeterStandard - SayHello() was called");
            return "Hello from .NET Standard Project!";
        }
    }
}
