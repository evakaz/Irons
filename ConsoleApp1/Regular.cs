using System;
using System.Collections.Generic;
using System.Text;

namespace Iron
{

    interface IIrons
    {
        string TurnOn();
        string TurnOff();
        string Descale();
        string DolroningTemp(int temperature);
        string DolroningProg(string ProgramName);
        string UseSteam();
        string Autodescale();
        string TurnTheLightOn();
    }


    public class Regular : IIrons
    {
        public string name;
        public int Temperature;
        public string ProgramName;
        public int timesUsed;
        public int timesSteamUsed;
        public bool lightOn;
        public bool steamIsBeingUsed;

        protected readonly IIronRandomGenerator randomGenerator;

        public Regular(IIronRandomGenerator randomGenerator)
        {
            this.randomGenerator = randomGenerator;

            Temperature = 0;
            ProgramName = "";
            this.name = "regular";
            this.timesUsed = 0;
            timesSteamUsed = 0;
            lightOn = false;
            steamIsBeingUsed = false;
        }
        public void Test()
        {
            Console.WriteLine("My name is " + this.name);
            Console.ReadKey();
        }

        public virtual string DolroningTemp(int temperature)
        {
            if (timesUsed < 3)
            {
                if (temperature >= 200 & temperature <= 230)
                {
                    this.ProgramName = "Linen program";
                }
                else if (temperature >= 150 & temperature <= 199)
                {
                    this.ProgramName = "Cotton program";
                }
                else if (temperature >= 120 & temperature <= 149)
                {
                    this.ProgramName = "Silk program";
                }
                else if (temperature >= 90 & temperature <= 119)
                {
                    this.ProgramName = "Synthetics program";
                }
                else
                {
                    return "Invalid temperature name for ironing.";
                }
                timesUsed++;
                //Console.WriteLine(timesUsed);
                if (steamIsBeingUsed & temperature >= 120)
                {
                    timesSteamUsed++;
                    steamIsBeingUsed = false;
                    return name + " is ironing with " + this.ProgramName + ". Ironing with steam.";

                }
                return name + " is ironing with " + this.ProgramName;
            }
            // timeUsed > 3
            return Autodescale();
        }


        public string DolroningProg(string ProgramName)
        {
            int num;
            if (timesUsed < 3)
            {
                if (ProgramName == "Linen")
                {
                    num = this.randomGenerator.GetForRange(200, 231);
                    Console.WriteLine("Ironing with steam");
                }
                else if (ProgramName == "Cotton")
                {
                    num = this.randomGenerator.GetForRange(150, 200);
                }
                else if (ProgramName == "Silk")
                {
                    num = this.randomGenerator.GetForRange(120, 150);
                }
                else if (ProgramName == "Synthetics")
                {
                    num = this.randomGenerator.GetForRange(90, 120);
                }
                else
                {
                    return "We do not have a program for ironing " + ProgramName;
                }

                timesUsed++;
                if (steamIsBeingUsed & num >= 120)
                {
                    timesSteamUsed++;
                    steamIsBeingUsed = false;
                    return name + " is ironing with " + num + " deegrees. Ironing with steam";

                }
                return name + " is ironing with " + num + " deegrees.";
            }
            
            Console.WriteLine("eskere");
            return Autodescale();
         
        }

        public virtual string Autodescale()
        {
            return "Machine has been used 3 times and need cleaning";
        }

        public string Descale()
        {
            timesUsed = 0;
            return "Machine is cleaned";
        }


        //
        public string UseSteam()
        {
            if (steamIsBeingUsed)
            {
                return "Steam is already on";
            }
 
            steamIsBeingUsed = true;
            if (timesSteamUsed >= 2)
            {
                TurnTheLightOn();
            }
            return "The iron doesn't need additional water";
        }

        public virtual string TurnTheLightOn()
        {
            return "This iron doesn't have light function";
        }


        public string TurnOn()
        {
            return "The iron is working.";
        }

        public string TurnOff()
        {
            return "The iron is not working";
        }
    }
}
