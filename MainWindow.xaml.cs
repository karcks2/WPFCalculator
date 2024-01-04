using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFAppCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if (button != null)
            {
                string buttonText = button.Content.ToString();

                if (buttonText == ".")
                {
                    if (Display.Text.Contains("."))
                    {
                        return;
                    }
                }

                if (Display.Text == "0" && buttonText != ".")
                {
                    Display.Text = buttonText;
                }
                else
                {
                    Display.Text += buttonText;
                }
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = "";
        }
    }
}