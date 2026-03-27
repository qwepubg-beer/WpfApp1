using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
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
using static WpfApp1.Regestration;
namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для Enter.xaml
    /// </summary>
    public partial class Enter : Page
    {
        public Enter()
        {
            InitializeComponent();
        }
        /*
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (log.Text != null)
            {
                Account editUser = Core.Context.Account.FirstOrDefault(u => u.Login.Contains(log.Text));
                if (editUser != null)
                {
                    if (editUser.Password == pas.Text)
                    {
                        MessageBox.Show("Вы вошли в аккаунт");
                        MainClass.user = editUser;
                        MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
                        mainWindow.MainFrame.Navigate(new ChooseFilm());
                    }
                    else
                    {
                        MessageBox.Show("Неверный пароль!");
                    }
                }
                else { MessageBox.Show("Пользователь не найден!"); }
            }
            else
            {
                MessageBox.Show("Заполните поля!");
            }


        }*/
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(Enter(log.Text, pas.Text))
            {
                MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
                mainWindow.MainFrame.Navigate(new ChooseFilm());
            }
            else
            {
                MessageBox.Show("Пользователь не найден!");
            }
        }
    }
}
