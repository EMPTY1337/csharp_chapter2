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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void numberTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            number.Text = numberTextBox.Text;
        }

        private void numberTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !int.TryParse(e.Text, out int result);
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            number.Text = smallSlider.Value.ToString("0");
        }

        private void bigSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            number.Text = bigSlider.Value.ToString("000-000-0000");
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton radioButton)
            {
                number.Text = radioButton.Content.ToString();
            }
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton radioButton)
            {
                number.Text = radioButton.Content.ToString();
            }
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton radioButton)
            {
                number.Text = radioButton.Content.ToString();
            }
        }

        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton radioButton)
            {
                number.Text = radioButton.Content.ToString();
            }
        }

        private void RadioButton_Checked_4(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton radioButton)
            {
                number.Text = radioButton.Content.ToString();
            }
        }

        private void RadioButton_Checked_5(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton radioButton)
            {
                number.Text = radioButton.Content.ToString();
            }
        }

        private void myListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (myListBox.SelectedItem is ListBoxItem listBoxItem)
            {
                number.Text = listBoxItem.Content.ToString();
            }
        }

        private void readOnlyComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (readOnlyComboBox.SelectedItem is ListBoxItem listBoxItem)
                number.Text = listBoxItem.Content.ToString();
        }
    }
}
