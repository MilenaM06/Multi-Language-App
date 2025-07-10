using System.Windows;
using MyCliProject;
using MyNetFrameworkApp;
using MyNetStandardLib;

namespace MyWpfApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Net_Standard_Click(object sender, RoutedEventArgs e)
        {
            string message = GreeterStandard.SayHello();
            OutputTextBox.Text = message;
        }

        private void Net_Framework_Click(object sender, RoutedEventArgs e)
        {
            string message = GreeterFramework.SayHello();
            OutputTextBox.Text = message;
        }

        private void Cli_Click(object sender, RoutedEventArgs e)
        {
            GreeterCli greeter = new GreeterCli();
            string message = greeter.SayHello();
            OutputTextBox.Text = message;
        }

        private void Cpp_Click(object sender, RoutedEventArgs e)
        {
            GreeterCpp greeter = new GreeterCpp();
            string message = greeter.SayHello();
            OutputTextBox.Text = message;
        }

    }
}