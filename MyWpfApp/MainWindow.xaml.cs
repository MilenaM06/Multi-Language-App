using System.Windows;
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
            string message = Greeter.SayHello();
            OutputTextBox.Text = message;
        }
    }
}