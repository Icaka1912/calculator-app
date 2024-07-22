using System.Reflection.Emit;
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

namespace Calculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Image image = new Image();
        }

        private void ButtonZero_Click(object sender, RoutedEventArgs e)
        {
            DisplayBox.Text += "0";
        }

        private void ButtonOne_Click(object sender, RoutedEventArgs e)
        {
            DisplayBox.Text += "1";
        }

        private void ButtonTwo_Click(object sender, RoutedEventArgs e)
        {
            DisplayBox.Text += "2";
        }

        private void ButtonThree_Click(object sender, RoutedEventArgs e)
        {
            DisplayBox.Text += "3";
        }

        private void ButtonFour_Click(object sender, RoutedEventArgs e)
        {
            DisplayBox.Text += "4";
        }

        private void ButtonFive_Click(object sender, RoutedEventArgs e)
        {
            DisplayBox.Text += "5";
        }

        private void ButtonSix_Click(object sender, RoutedEventArgs e)
        {
            DisplayBox.Text += "6";
        }

        private void ButtonSeven_Click(object sender, RoutedEventArgs e)
        {
            DisplayBox.Text += "7";
        }

        private void ButtonEight_Click(object sender, RoutedEventArgs e)
        {
            DisplayBox.Text += "8";
        }

        private void ButtonNine_Click(object sender, RoutedEventArgs e)
        {
            DisplayBox.Text += "9";
        }

        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            if (OperandDisplayBox.Text == "")
            {
                OperatorDisplayBox.Text = "-";
                OperandDisplayBox.Text = DisplayBox.Text;
                DisplayBox.Text = "";


            }
            else
            {
                OperatorDisplayBox.Text = "-";
            }

        }

        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            if (OperandDisplayBox.Text == "")
            {
                OperatorDisplayBox.Text = "+";
                OperandDisplayBox.Text = DisplayBox.Text;
                DisplayBox.Text = "";

            }
            else
            {
                OperatorDisplayBox.Text = "+";
            }


        }

        private void ButtonEqual_Click(object sender, RoutedEventArgs e)
        {
            double firstNum = 0;

            if (OperandDisplayBox.Text != "")
            {
                firstNum = double.Parse(OperandDisplayBox.Text);
            }

            double secondNum = 0;
            if (DisplayBox.Text != "")
            {
                secondNum = double.Parse(DisplayBox.Text);
            }

            string operatorSign = OperatorDisplayBox.Text;
            double result = 0;
            if (operatorSign == "+")
            {
                result = firstNum + secondNum;
            }
            else if (operatorSign == "-")
            {
                result = firstNum - secondNum;
            }
            else if (operatorSign == "X")
            {
                 result = firstNum * secondNum;
            }
            else if (operatorSign == "÷")
            {
                result = firstNum / secondNum;
            }         
            DisplayBox.Text = result.ToString();
            OperatorDisplayBox.Text = "";
            OperandDisplayBox.Text = "";            
        }
        private void ButtonMultiplier_Click(object sender, RoutedEventArgs e)
        {
            if (OperandDisplayBox.Text == "")
            {
                OperatorDisplayBox.Text = "X";
                OperandDisplayBox.Text = DisplayBox.Text;
                DisplayBox.Text = "";

            }
            else
            {
                OperatorDisplayBox.Text = "X";
            }
        }

        private void ButtonDivision_Click(object sender, RoutedEventArgs e)
        {
            if (OperandDisplayBox.Text == "")
            {
                OperatorDisplayBox.Text = "÷";
                OperandDisplayBox.Text = DisplayBox.Text;
                DisplayBox.Text = "";

            }
            else
            {
                OperatorDisplayBox.Text = "÷";
            }
        }
        }
    }            
