using JourneySearchContract.Models;
using System.Collections.Generic;

namespace SearchService.Contract
{
    public class SearchResponse
    {
        public IEnumerable<Journey> Journeys { get; set; }
    }
}