using System;
using System.Collections.Generic;
using System.Text;

namespace Iron
{
    class IronRandomGeneratorDefault : IIronRandomGenerator
    {
        public int GetForRange(int start, int end)
        {
            Random rnd = new Random();
            return rnd.Next(150, 200);
        }
    }
}
