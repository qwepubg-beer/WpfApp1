using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class MainClass
    {
        static public bool Enter { get; set; } = false;
        public static Account user { get; set; } = null;
        static public List<Film> Film { get; set; }
        static public Film ChoosingFilm { get; set; }
        static public List<Buy> Session { get; set; }
        static public Buy BuyTik {get;set;}
        static public List<Buy> Tick { get; set; }
    }
}
