using System.Diagnostics;
using System.Windows.Automation;

namespace UITests
{
    public class Tests
    {
        Process? appProcess;
        AutomationElement mainWindow;

        private const string AppPath = @"C:\Users\Milena\Desktop\Multi-Language-App\DotNetSolution\WpfApp\bin\Release\net8.0-windows\WpfApp.exe";

        [SetUp]
        public void Setup()
        {
            appProcess = Process.Start(AppPath);
            Thread.Sleep(2000);

            mainWindow = AutomationElement.RootElement.FindFirst(
                TreeScope.Children,
                new PropertyCondition(AutomationElement.NameProperty, "Multi-Language App"));

            Assert.IsNotNull(mainWindow, "Main window not found");
        }

        private void ClickButtonAndCheckOutput(string buttonName, string expectedOutput)
        {
            var button = mainWindow.FindFirst(TreeScope.Descendants,
                new PropertyCondition(AutomationElement.NameProperty, buttonName));
            Assert.IsNotNull(button, $"Button '{buttonName}' not found");

            var invokePattern = button.GetCurrentPattern(InvokePattern.Pattern) as InvokePattern;
            Assert.IsNotNull(invokePattern, $"Button '{buttonName}' does not support InvokePattern");
            invokePattern.Invoke();

            Thread.Sleep(500);

            var outputBox = mainWindow.FindFirst(TreeScope.Descendants,
                new PropertyCondition(AutomationElement.AutomationIdProperty, "OutputTextBox"));
            Assert.IsNotNull(outputBox, "OutputTextBox not found");

            var valuePattern = outputBox.GetCurrentPattern(ValuePattern.Pattern) as ValuePattern;
            Assert.That(valuePattern, Is.Not.Null, "OutputTextBox does not support ValuePattern");

            Assert.That(valuePattern.Current.Value, Is.EqualTo(expectedOutput));
        }

        [Test]
        public void Test_FortranButton()
        {
            ClickButtonAndCheckOutput("Fortran", "Hello there!");
        }

        [Test]
        public void Test_CppNativeButton()
        {
            ClickButtonAndCheckOutput("C++ Native", "Hello from C++ Native Project!");
        }

        [Test]
        public void Test_CliButton()
        {
            ClickButtonAndCheckOutput("C++/CLI", "Hello from C++/CLI Project!");
        }

        [Test]
        public void Test_NetFrameworkButton()
        {
            ClickButtonAndCheckOutput(".NET Framework", "Hello from .NET Framework Project!");
        }

        [Test]
        public void Test_NetStandardButton()
        {
            ClickButtonAndCheckOutput(".NET Standard", "Hello from .NET Standard Project!");
        }

        [TearDown]
        public void TearDown()
        {
            if (appProcess != null)
            {
                if (!appProcess.HasExited)
                {
                    appProcess.Kill();
                    appProcess.WaitForExit();
                }
                appProcess.Dispose();
                appProcess = null;
            }
        }
    }

}