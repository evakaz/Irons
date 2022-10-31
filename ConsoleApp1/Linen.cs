using System;
using System.Collections.Generic;
using System.Text;

namespace Iron
{
    public class Linen : Regular
    {

        public Linen(IIronRandomGenerator randomGenerator) : base(randomGenerator)
        {
            name = "linen";
        }
    }
}
