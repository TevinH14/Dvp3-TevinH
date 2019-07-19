using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamiltonTevin_Assignment2
{
   public class MovieArgs: EventArgs
   {
        public string _title;
        public string _YearReleased;
        public  string _publisher;
        public string _director;
        public string _genre;

        public MovieArgs(string t,string y,string p,string d,string g)
        {
            _title = t;
            _YearReleased = y;
            _publisher = p;
            _director = d;
            _genre = g;
        }
        public override string ToString()
        {
            return _title;
        }
    }
}
