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
    /// Логика взаимодействия для ChooseSeat.xaml
    /// </summary>
    public partial class ChooseSeat : Page
    {
        public ChooseSeat()
        {
            InitializeComponent();
            List<int> h=new List<int>();
            List<int> h2 = new List<int>();
            for (int i=1;i<=MainClass.BuyTik.Seat;i++)
            {
                h.Add(i);
            }
            List<Ticket> Tickets = Core.Context.Ticket.Where(i => i.SessionID==MainClass.BuyTik.Session.ID).ToList();

            foreach (Ticket ticket in Tickets)
            {
                h2.Add(ticket.SeatNumber);
            }
            h= h.Except(h2).ToList();
            Seats.ItemsSource = h;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Ticket ticket = new Ticket(MainClass.BuyTik.Session.ID, MainClass.user.ID, MainClass.cs);
            Core.Context.Ticket.Add(ticket);    
            Core.Context.SaveChanges();
        }

        private void Session_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Seats.SelectedItem != null)
            { MainClass.cs = (int)Seats.SelectedItem;
            }

            
        }
    }
}
