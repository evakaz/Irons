using System;

namespace Iron
{
    class Program
    {


        static void Main(string[] args)
        {
            IIronRandomGenerator randomGenerator = new IronRandomGeneratorDefault();
            //Console.WriteLine("What do you want to do?()");
            Regular regular = new Regular(randomGenerator);
            Premium premium = new Premium(randomGenerator);
            Linen linen = new Linen(randomGenerator);
            Console.WriteLine(premium.DolroningTemp(154));
            Console.WriteLine(premium.timesUsed);
        }




    }
}
