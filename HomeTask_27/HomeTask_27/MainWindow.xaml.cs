using System.Windows;

namespace Calculator
{
    public partial class MainWindow : Window
    {
        public MainViewModel ViewModel { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            ViewModel = (MainViewModel)Resources["ViewModel"];
        }
    }
}
