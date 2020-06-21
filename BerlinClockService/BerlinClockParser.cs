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
            TimeSpan time = timeParser.ParseTimeString(input);

            return getSecondString(time) + "\n" + getHourString(time) + "\n" + getMinuteString(time);
        }

        private string getHourString(TimeSpan time) {
            string firstLine = "";
            string secondLine = "";

            for (int i = 0; i < time.Hours / 5; i++) {
                firstLine += "R";
            }

            for (int i = 0; i < time.Hours % 5; i++) {
                secondLine += "R";
            }

            return firstLine.PadRight(4, 'O') + "\n" + secondLine.PadRight(4, 'O');
        }
        private string getMinuteString(TimeSpan time) {
            return "";
        }
        private string getSecondString(TimeSpan time) {
            return time.Seconds % 2 == 1 ? "Y" : "O";
        }
    }
}    }
}