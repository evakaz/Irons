using System;
using System.Collections.Generic;
using System.Text;

namespace Iron
{
    public class Premium : Regular
    {

        public Premium(IIronRandomGenerator randomGenerator) : base(randomGenerator)
        {
            name = "premium";
        }
        public override string Autodescale()
        {
            timesUsed = 0;
            return "Machine is cleaned";
        }


        public override string TurnTheLightOn()
        {
            lightOn = true;
            return "The light is on";
        }

    }
}
