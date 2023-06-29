using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace Calculator
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string number;
        private string result;

        public MainViewModel()
        {
            SinCommand = new RelayCommand(ExecuteSinCommand);
            CosCommand = new RelayCommand(ExecuteCosCommand);
            FactorialCommand = new RelayCommand(ExecuteFactorialCommand);
        }

        public string Number
        {
            get { return number; }
            set
            {
                number = value;
                OnPropertyChanged();
            }
        }

        public string Result
        {
            get { return result; }
            set
            {
                result = value;
                OnPropertyChanged();
            }
        }

        public ICommand SinCommand { get; }
        public ICommand CosCommand { get; }
        public ICommand FactorialCommand { get; }

        private void ExecuteSinCommand(object parameter)
        {
            if (double.TryParse(Number, out double num))
            {
                double result = Math.Sin(num);
                Result = result.ToString();
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void ExecuteCosCommand(object parameter)
        {
            if (double.TryParse(Number, out double num))
            {
                double result = Math.Cos(num);
                Result = result.ToString();
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void ExecuteFactorialCommand(object parameter)
        {
            if (int.TryParse(Number, out int num) && num >= 0)
            {
                int result = CalculateFactorial(num);
                Result = result.ToString();
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

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}