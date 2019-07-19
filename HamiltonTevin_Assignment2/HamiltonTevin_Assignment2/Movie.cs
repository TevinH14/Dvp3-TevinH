using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamiltonTevin_Assignment2
{
   public  class MovieArgs: EventArgs
   {
        string _titel;
        string _YearReleased;
        string _publisher;
        string _director;
        string _genre;

        public MovieArgs(string t,string y,string p,string d,string g)
        {
            _titel = t;
            _YearReleased = y;
            _publisher = p;
            _director = d;
            _genre = g;
        }
        public override string ToString()
        {
            return _titel;
        }
    }
}
