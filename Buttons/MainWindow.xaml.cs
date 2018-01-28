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

//Создать приложение с кнопками трёх разных форм. Формы создавать посредством шаблонов.

namespace Buttons
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

        private void Click2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button 2 clicked");
        }

        private void Click1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button 1 clicked");
        }

        private void Click3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button 3 clicked");
        }
    }
}
