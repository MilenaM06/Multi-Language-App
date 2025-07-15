using Serilog;

namespace NetFrameworkApp
{
    public class GreeterFramework
    {
        public GreeterFramework() {
            Log.Information(".NET Framework Project Log - class GreeterFramework - Constructor  was called"); 
        }

        public string SayHello()
        {
            Log.Information(".NET Framework Project Log - class GreeterFramework - SayHello() was called");
            return "Hello from .NET Framework Project!";
        }
    }
}
