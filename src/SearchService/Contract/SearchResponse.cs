using System;
using System.Collections.Generic;

namespace SearchService.Contract
{
    public class SearchResponse
    {
        public IEnumerable<Journey> Journeys { get; set; }
    }

    public class Journey
    {
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
    }
}