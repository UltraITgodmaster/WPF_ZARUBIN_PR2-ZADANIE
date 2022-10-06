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

namespace WPF_ZARUBIN_PR2_ZADANIE
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Зарубин 402 группа и т.д.");
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            
        }
        
        

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Visibility = Visibility.Collapsed;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            window2.Show();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {

        }
    }
}
