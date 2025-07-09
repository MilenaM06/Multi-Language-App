using System.Windows;

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

        private void Cli_Click(object sender, RoutedEventArgs e)
        {
            MyCliProject.Greeter greeter = new MyCliProject.Greeter();
            string message = greeter.SayHello();
            OutputTextBox.Text = message;
        }
    }
}