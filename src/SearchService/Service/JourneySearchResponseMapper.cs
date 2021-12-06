using System.Linq;
using JourneySearchContract;
using SearchService.Contract;

namespace SearchService.Service
{
    public interface IJourneySearchResponseMapper
    {
        SearchResponse MapResponse(JourneySearchResponse journeySearchRequest);
    }

    public class JourneySearchResponseMapper : IJourneySearchResponseMapper
    {
        public SearchResponse MapResponse(JourneySearchResponse journeySearchRequest)
        {
            return new SearchResponse
            {
                Journeys = journeySearchRequest.Journeys.Select(inputJourney => new Journey
                {
                    Origin = inputJourney.Origin,
                    Destination = inputJourney.Destination,
                    DepartureTime = inputJourney.DepartureTime,
                    ArrivalTime = inputJourney.ArrivalTime,
                }).ToList(),
            };
        }
    }
}