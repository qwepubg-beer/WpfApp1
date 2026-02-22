using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class Buy
    {
        public Session Session { get; set; }
        public int Number {  get; set; }   
        public string Film {  get; set; }
        public int Seat { get; set; }
        public Buy(Session session)
        {
            Session = session;
            Film film = Core.Context.Film.First(u => u.ID== session.FilmID);
            Room room = Core.Context.Room.First(u => u.ID == session.RoomID);
            Number= room.Number;
            Seat = room.TotalSeats;
            Film = film.Name;
        }
    }
}
