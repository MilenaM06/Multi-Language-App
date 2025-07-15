using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using NetStandardLib;
using NetFrameworkApp;
using CliProject;
using Serilog;

namespace WpfApp
{
    public partial class MainWindow : Window
    {
        // [DllImport("FortranProject.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hello")]
        // public static extern void hello([Out] StringBuilder buf, int buflen);
       
        public MainWindow()
        {
            InitializeComponent();
            Log.Logger = new LoggerConfiguration().WriteTo.File("Logs/dotnet_logs.txt").CreateLogger();
        }

        private void Fortran_Click(object sender, RoutedEventArgs e)
        {
            /*
            try
            {
                StringBuilder sb = new StringBuilder(256);
                hello(sb, sb.Capacity);
                OutputTextBox.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            */
            OutputTextBox.Text = "Hello there!";
        }

        private void Cpp_Click(object sender, RoutedEventArgs e)
        {
            GreeterCpp greeter = new GreeterCpp();
            string message = greeter.SayHello();
            OutputTextBox.Text = message;
        }
        private void Cli_Click(object sender, RoutedEventArgs e)
        {
            GreeterCli greeter = new GreeterCli();
            string message = greeter.SayHello();
            OutputTextBox.Text = message;
        }
        private void Net_Framework_Click(object sender, RoutedEventArgs e)
        {
            string message = GreeterFramework.SayHello();
            OutputTextBox.Text = message;
        }

        private void Net_Standard_Click(object sender, RoutedEventArgs e)
        {
            string message = GreeterStandard.SayHello();
            OutputTextBox.Text = message;
        }

    }
}