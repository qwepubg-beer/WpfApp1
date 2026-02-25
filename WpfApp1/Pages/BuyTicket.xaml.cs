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

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для BuyTicket.xaml
    /// </summary>
    public partial class BuyTicket : Page
    {
        public BuyTicket()
        {
            InitializeComponent();
            MainClass.Session.Clear();  
            List<Session> users = Core.Context.Session.ToList();
            foreach (Session session in users) 
            {
                Buy buy = new Buy(session);
                MainClass.Session.Add(buy);
            }
            Tickets.ItemsSource=MainClass.Session;

        }

        private void Session_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Buy g=(Buy)Tickets.SelectedItem;
            if (g != null) { MainClass.BuyTik = g;}
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            mainWindow.MainFrame.Navigate(new ChooseSeat());
        }
    }
}
