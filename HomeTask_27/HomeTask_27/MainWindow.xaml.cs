using System;
using System.Windows;

namespace Calculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SinButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(numberTextBox.Text, out double number))
            {
                double result = Math.Sin(number);
                resultTextBox.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void CosButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(numberTextBox.Text, out double number))
            {
                double result = Math.Cos(number);
                resultTextBox.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void FactorialButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(numberTextBox.Text, out int number) && number >= 0)
            {
                int result = CalculateFactorial(number);
                resultTextBox.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Please enter a non-negative integer.");
            }
        }

        private int CalculateFactorial(int number)
        {
            if (number == 0)
                return 1;
            else
                return number * CalculateFactorial(number - 1);
        }
    }
}
