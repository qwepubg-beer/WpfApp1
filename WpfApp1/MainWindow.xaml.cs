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
using WpfApp1.Pages;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Frame Frame => MainFrame;
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.NavigationService.Navigate(new ChooseFilm());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new ChooseFilm());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new Enter());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new Registration());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (MainClass.user!=null)
            {
                MainFrame.NavigationService.Navigate(new MyTickets());
            }
            else
            {
                var result=MessageBox.Show("Вы хотите войти в аккаунт?","Ошибка авторизации",MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes) { MainFrame.NavigationService.Navigate(new Enter()); }
                

            }

        }
    }
}

