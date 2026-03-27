using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1.Pages;

namespace WpfApp1
{
    public class Regestration
    {
        static public bool Enter(string login, string password)
        {
            if (!string.IsNullOrWhiteSpace(login)|| !string.IsNullOrWhiteSpace(password))
            {
                Account editUser = Core.Context.Account.FirstOrDefault(u => u.Login==login);
                if (editUser != null)
                {
                    if (editUser.Password == password)
                    {
                        MainClass.user = editUser;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else {  return false; }
            }
            else
            {
                return false;
            }
        }
        static public bool Reg(string mail,string login, string password1, string password2)
        {
            if (string.IsNullOrWhiteSpace(mail) || string.IsNullOrWhiteSpace(login))
            {
                Account editUser = Core.Context.Account.FirstOrDefault(u => u.Login==login);
                bool f1 = editUser == null;
                bool f2 = password1 == password2;
                if (!f1)
                {
                    if (f2)
                    {
                        Account newUser = new Account
                        {
                            Login = login,
                            Password = password1
                        };
                        Core.Context.Account.Add(newUser);
                        Core.Context.SaveChanges();
                        MainClass.user = newUser;
                        MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
                        mainWindow.MainFrame.Navigate(new ChooseFilm());
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Пароли не совпадают!");
                        return false;
                    }

                }
                else
                {
                    MessageBox.Show("Вы уже зарегестрированы!");
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        }
}
