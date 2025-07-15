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
        private GreeterCpp greeterCpp;
        private GreeterCli greeterCli;
        private GreeterFramework greeterFramework;
        private GreeterStandard greeterStandard;
        public MainWindow()
        {
            InitializeComponent();
            Log.Logger = new LoggerConfiguration().WriteTo.File("Logs/dotnet_logs.txt").CreateLogger();
            greeterCpp = new GreeterCpp();
            greeterCli = new GreeterCli();
            greeterFramework = new GreeterFramework();
            greeterStandard = new GreeterStandard();
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
            string message = greeterCpp.SayHello();
            OutputTextBox.Text = message;
        }
        private void Cli_Click(object sender, RoutedEventArgs e)
        {          
            string message = greeterCli.SayHello();
            OutputTextBox.Text = message;
        }
        private void Net_Framework_Click(object sender, RoutedEventArgs e)
        {
            string message = greeterFramework.SayHello();
            OutputTextBox.Text = message;
        }

        private void Net_Standard_Click(object sender, RoutedEventArgs e)
        {
            string message = greeterStandard.SayHello();
            OutputTextBox.Text = message;
        }

    }
}