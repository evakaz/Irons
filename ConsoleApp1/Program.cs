using System;

namespace Iron
{
    class Program
    {


        static void Main(string[] args)
        {
            IIronRandomGenerator randomGenerator = new IronRandomGeneratorDefault();
            Regular regular = new Regular(randomGenerator);
            Premium premium = new Premium(randomGenerator);
            Linen linen = new Linen(randomGenerator);
            Console.WriteLine(premium.DoIroning(154));
            Console.WriteLine(premium.timesUsed);
        }




    }
}
