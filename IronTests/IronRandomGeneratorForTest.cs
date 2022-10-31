using System;
using System.Collections.Generic;
using System.Text;
using Iron;

namespace IronTests
{
    class IronRandomGeneratorForTest : IIronRandomGenerator
    {
        public int GetForRange(int start, int end)
        {
            return start;
        }
    }
}
