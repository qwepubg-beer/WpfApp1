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
    /// Логика взаимодействия для MyTickets.xaml
    /// </summary>
    public partial class MyTickets : Page
    {
        public MyTickets()
        {
            InitializeComponent();
            List < Ticket > tic = Core.Context.Ticket.Where(a=>a.AccountID==MainClass.user.ID  && a.PurchaseDate >= DateTime.Now).ToList();
            if (tic.Count > 0)
            {
                Tickets.ItemsSource = tic;
                Tickets.IsEnabled = true;
            }
            else
            {
                Mes.Text = "У вас не активных билетов";
            }
            foreach(Ticket t in tic)
            {
                ChooseTicket cht = new ChooseTicket(t);
                MainClass.ChooseTickets.Add(cht);
            }
            Tickets.ItemsSource = MainClass.ChooseTickets;


        }
    }
}
