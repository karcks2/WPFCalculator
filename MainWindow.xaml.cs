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
        int num1;
        int num2;

        char op;

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

        private void btnMinusAndPlus_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(Display.Text, out double inputValue))
            {
                double result = -inputValue;

                Display.Text = result.ToString();
            }
        }

        private void btnDevide_Click(object sender, RoutedEventArgs e)
        {
            num1 = Int32.Parse(Display.Text);
            op = '/';
            Display.Clear();
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            num1 = Int32.Parse(Display.Text);
            op = '*';
            Display.Clear();
        }

        private void btnSubtract_Click(object sender, RoutedEventArgs e)
        {
            num1 = Int32.Parse(Display.Text);
            op = '-';
            Display.Clear();
        }

        private void btnAad_Click(object sender, RoutedEventArgs e)
        {
            num1 = Int32.Parse(Display.Text);
            op = '+';
            Display.Clear();
        }

        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
            num2 = Int32.Parse(Display.Text);
            int result = 0;

            if(op == '+')
            {
                result = num1 + num2;
            }
            if (op == '-')
            {
                result = num1 - num2;
            }
            if (op == '/')
            {
                result = num1 / num2;
            }
            if (op == '*')
            {
                result = num1 * num2;
            }
            Display.Text = result.ToString();
        }
    }
}