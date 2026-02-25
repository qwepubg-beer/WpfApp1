using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class ChooseTicket
    {
        public Ticket ticket {  get; set; }
        public Room room { get; set; }
        public Session session { get; set; }
        public Film film { get; set; }
 
        public ChooseTicket(Ticket ticket,Room room,Session session,Film film)
        {
            this.ticket = ticket;
            this.room = room;
            this.session = session; 
            this.film = film;
            }
        
    }
}
