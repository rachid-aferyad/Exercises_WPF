using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Increment_Decrement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _value;
        public MainWindow()
        {
            InitializeComponent();
            Result.Text = _value.ToString();
        }

        private void IncrementButton_Click(object sender, RoutedEventArgs e)
        {
            Button incrementButton = e.OriginalSource as Button;
            if (_value < 9)
                _value++;

            Result.Text = _value.ToString();
        }

        private void DecrementButton_Click(object sender, RoutedEventArgs e)
        {
            Button decrementButton = e.OriginalSource as Button;
            if (_value > 0)
                _value--;

            Result.Text = _value.ToString();
        }

        private void Button_Clicked(object sender, RoutedEventArgs e)
        {
            if (_value == 9)
                IncrementButton.IsEnabled = false;
            else if (_value == 0)
                DecrementButton.IsEnabled = false;
            else
            {
                IncrementButton.IsEnabled = true;
                DecrementButton.IsEnabled = true;
            }
        }
    }
}
