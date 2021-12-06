using System.Linq;
using JourneySearchContract;
using JourneySearchContract.Models;
using SearchService.Contract;
using SearchService.Interfaces;

namespace SearchService.Mappers
{

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