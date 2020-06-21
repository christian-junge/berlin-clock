using System;

namespace BerlinClock.Service
{
    public interface IBerlinClockParser
    {
        string getBerlinTime(string input);
    }
}