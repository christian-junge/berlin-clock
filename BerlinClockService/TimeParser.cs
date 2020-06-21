using System;
using System.Text.RegularExpressions;

namespace BerlinClock.Service
{
    public class TimeParser : ITimeParser
    {
        private const string pattern = @"^(\d{2}):(\d{2}):(\d{2}$)";
        
        public TimeSpan ParseTimeString(string input) {
            throw new NotImplementedException();
        }
    }
}