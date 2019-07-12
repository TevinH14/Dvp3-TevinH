using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TevinHamilton_CodeExercise1_EventHandlers
{
    class CharArgs:EventArgs
    {
        public string Name { get; set; }
        public string Summery { get; set; }
        public decimal Credits { get; set; }
    }
}
