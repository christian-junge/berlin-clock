using System;

namespace BerlinClock.Service
{
    public interface ITimeParser
    {
        TimeSpan ParseTimeString(string input);
    }
}