﻿using System;

namespace JourneySearchContract
{
    public class JourneySearchJourney
    {
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
    }
}