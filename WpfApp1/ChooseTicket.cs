using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class ChooseTicket
    {
        Ticket ticket {  get; set; }
        Room room { get; set; }
        public ChooseTicket(Ticket ticket)
        {
            this.ticket = ticket;
            Session s = Core.Context.Session.First(u => u.ID == ticket.SessionID);
            Room r = Core.Context.Room.First(u => u.ID == s.RoomID);
            if(r!= null) {room= r;}
            {
                room = new Room();
            }
        }
    }
}
