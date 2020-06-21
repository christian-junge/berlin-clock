using System;

namespace BerlinClock.Service
{
    public class BerlinClockParser : IBerlinClockParser
    {
        private ITimeParser timeParser;

        public BerlinClockParser(ITimeParser iTimeParser)
        {
            timeParser = iTimeParser;
        }

        public string getBerlinTime(string input) {
            throw new NotImplementedException();
        }
    }
}