using Serilog;

namespace NetStandardLib
{
    public class GreeterStandard
    {
        public GreeterStandard()
        {
            Log.Information(".NET Standard Project Log - class GreeterStandard - Constructor  was called");
        }

        public string SayHello()
        {          
            Log.Information(".NET Standard Project Log - class GreeterStandard - SayHello() was called");
            return "Hello from .NET Standard Project!";
        }
    }
}
