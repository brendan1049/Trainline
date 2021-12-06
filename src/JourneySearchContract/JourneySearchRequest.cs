using System;

namespace JourneySearchContract
{
    public class JourneySearchRequest
    {
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime DepartureTime { get; set; }
    }
}