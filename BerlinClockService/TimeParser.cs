using System;
using System.Text.RegularExpressions;

namespace BerlinClock.Service
{
    public class TimeParser : ITimeParser
    {
        private const string pattern = @"^(\d{2}):(\d{2}):(\d{2}$)";
        
        public TimeSpan ParseTimeString(string input) {
            if (IsValid(input)) {
                return TimeSpan.Parse(input);
            } else {
                throw new FormatException("Incorrect time format (hh:mm:ss)");
            }
        }

        private bool IsValid(string input) {
            MatchCollection matches = Regex.Matches(input, pattern);

            if (matches.Count != 1) {
                return false;
            }

            int hours = Int32.Parse(matches[0].Groups[1].Value);
            int minutes = Int32.Parse(matches[0].Groups[2].Value);
            int seconds = Int32.Parse(matches[0].Groups[3].Value);

            if (hours > 23 || minutes > 60 || seconds > 60) {
                return false;
            }

            return true;
        }
    }
}