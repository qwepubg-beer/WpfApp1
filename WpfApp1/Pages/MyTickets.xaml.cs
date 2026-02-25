using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
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
    /// Логика взаимодействия для MyTickets.xaml
    /// </summary>
    public partial class MyTickets : Page
    {
        public MyTickets()
        {
            InitializeComponent();
            List < Ticket > tic = Core.Context.Ticket.Where(a=>a.AccountID==MainClass.user.ID).ToList();
            List<ChooseTicket> ct=new List<ChooseTicket>(); 
            foreach(Ticket t in tic)
            {
                Session s = Core.Context.Session.First(u => u.ID == t.SessionID);
                Film f = Core.Context.Film.First(u => u.ID == s.FilmID);
                Room r = Core.Context.Room.First(u => u.ID == s.RoomID);
                ChooseTicket cht = new ChooseTicket(t,r,s,f);
                ct.Add(cht);
            }
            MyTickList.ItemsSource = ct;
 }

        private void FilmList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
