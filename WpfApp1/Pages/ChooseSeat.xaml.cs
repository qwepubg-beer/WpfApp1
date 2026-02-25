using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для ChooseSeat.xaml
    /// </summary>
    public partial class ChooseSeat : Page
    {
        public ChooseSeat()
        {
            InitializeComponent();
            List<Seats> S = Core.Context.Seats.Where(u=> u.RoomID==MainClass.BuyTik.Session.RoomID).ToList();
            List<Ticket> t = Core.Context.Ticket.Where(u => u.SessionID== MainClass.BuyTik.Session.ID).ToList();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Ticket ticket = new Ticket(MainClass.BuyTik.Session.ID, MainClass.user.ID, MainClass.cs.Seat,DateTime.Now);
            Core.Context.Ticket.Add(ticket);    
            Core.Context.SaveChanges();
        }

        private void Session_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Seats.SelectedItem != null)
            { MainClass.cs = Seats.SelectedItem as Ssh;
            }

            
        }
    }
}
