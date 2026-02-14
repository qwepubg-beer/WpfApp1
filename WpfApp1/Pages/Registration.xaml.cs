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

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        public Registration()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (mail.Text != null && login.Text != null)
            {
                Account editUser = Core.Context.Account.FirstOrDefault(u => u.Login.Contains(login.Text));
                Account editUser2 = Core.Context.Account.FirstOrDefault(u => u.E_mail.Contains(mail.Text));
                bool f1 = editUser == null && editUser2 == null;
                bool f2 = p1.Text == p2.Text;
                if (f1)
                {
                    if (f2)
                    {
                        Account newUser = new Account
                        {
                            E_mail = mail.Text,
                            Login = login.Text,
                            Password = p1.Text,
                        };
                        Core.Context.Account.Add(newUser);
                        Core.Context.SaveChanges();
                        MessageBox.Show("Вы зарегестрированы!");
                        Choose.user = newUser;
                        MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
                        mainWindow.MainFrame.Navigate(new ChooseFilm());
                    }
                    else
                    {
                        MessageBox.Show("Пароли не совпадают!");
                    }

                }
                else
                {
                    MessageBox.Show("Вы уже зарегестрированы!");
                }
            }
            else
            {
                MessageBox.Show("Заполните поля!");
            }
        }
    }
}
