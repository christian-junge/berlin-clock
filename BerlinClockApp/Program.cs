using System;
using BerlinClock.Service;

namespace BerlinClock.App
{
    class Program
    {
        private const string usageText = "Usage: berlin-clock hh:mm:ss";

        static int Main(string[] args)
        {
            if (args.Length != 1) {
                Console.WriteLine(usageText);
                
                return 1;
            }

            IBerlinClockParser clockParser = new BerlinClockParser(new TimeParser());
            Console.WriteLine(clockParser.getBerlinTime(args[0]));

            return 0;
        }
    }
}
