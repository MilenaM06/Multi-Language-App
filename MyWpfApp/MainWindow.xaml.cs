using System.Windows;
using MyNetStandardLib;
using MyNetFrameworkApp;

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
            string message = MyNetStandardLib.Greeter.SayHello();
            OutputTextBox.Text = message;
        }

        private void Net_Framework_Click(object sender, RoutedEventArgs e)
        {
            string message = MyNetFrameworkApp.Greeter.SayHello();
            OutputTextBox.Text = message;
        }
    }
}