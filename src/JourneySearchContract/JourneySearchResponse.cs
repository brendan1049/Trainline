using System.Collections.Generic;

namespace JourneySearchContract
{
    public class JourneySearchResponse
    {
        public IEnumerable<JourneySearchJourney> Journeys { get; set; }
    }
}