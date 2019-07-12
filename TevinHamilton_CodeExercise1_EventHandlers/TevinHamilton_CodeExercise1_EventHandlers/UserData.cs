using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TevinHamilton_CodeExercise1_EventHandlers
{
    class UserData
    {

        public string Name { get; set; }
        public string Summery { get; set; }
        public decimal Credits { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
