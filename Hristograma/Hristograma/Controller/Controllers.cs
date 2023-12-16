using Hristograma.Module;
using Hristograma.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Hristograma.Controller
{
   public class Controllers
    {
          Views display = new Views();
        public Controllers()
        {
            
            display.DisplayInput();

            Models models =new Models(display.numbers);

            display.P1 = models.CalculateP1();
            display.P2 = models.CalculateP2();
            display.P3 = models.CalculateP3();
            display.P4 = models.CalculateP4();
            display.P5 = models.CalculateP5();

            display.DisplayOutput();
        }

    }
}
