using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Classes
{
    internal class WristWatch
    {
        enum Movement { mechanical, automatic, solar, kinetic, quartz, springDrive }
        Movement movement;

        enum Dials { analog, chronograph, digital, LED, hybrid }
        Dials dials;

        enum Visual { skeleton, tourbillon, moonPhase, sweepingHand }
        Visual visual;

        enum Style { nurse, luxury, fashion, dress, diver, military, pilot, racing, pocket }
        Style style;

        enum Functionality { smart, fitness, atomic, solarAtomic, ABC, vibrating }

        string color;

        string design;

        private Movement Movement1 { get => movement; set => movement = value; }
        private Dials Dials1 { get => dials; set => dials = value; }
        private Visual Visual1 { get => visual; set => visual = value; }
        private Style Style1 { get => style; set => style = value; }
        public string Color { get => color; set => color = value; }
        public string Design { get => design; set => design = value; }
    }
}
