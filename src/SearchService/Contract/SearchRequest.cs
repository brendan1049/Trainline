using System;

namespace SearchService.Contract
{
    public class SearchRequest
    {
        public Location From { get; set; }
        public Location To { get; set; }
        public DateTime DepartureTime { get; set; }
    }
}