using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cimema
{
    static public class Choose
    {
        static public bool Enter { get; set; }=false;
        public static Account  user { get; set; }
        static public List<Film> Film { get; set; }
        static public Film ChoosingFilm { get; set; }
    }
}
