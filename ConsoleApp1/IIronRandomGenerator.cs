using System;
using System.Collections.Generic;
using System.Text;

namespace Iron
{
    public interface IIronRandomGenerator
    {
        public int GetForRange(int start, int end);
    }
}
