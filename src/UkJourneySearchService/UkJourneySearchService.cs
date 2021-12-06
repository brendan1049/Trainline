using System;
using System.Collections.Generic;
using System.Linq;
using JourneySearchContract;
using JourneySearchContract.Interfaces;

namespace UkJourneySearchService
{
    public class UkJourneySearchService : IJourneySearchService
    {
        private readonly int _journeyCount = 6;

        public JourneySearchResponse PerformSearch(JourneySearchRequest request)
        {
            return new JourneySearchResponse
            {
                Journeys = MakeJourneys(request).ToList(),
            };
        }

        private IEnumerable<JourneySearchJourney> MakeJourneys(JourneySearchRequest request)
        {
            var rnd = new Random();

            for (int i = 0; i < _journeyCount; i++)
            {
                var departureTime = request.DepartureTime.AddMinutes(rnd.Next(rnd.Next()));
                var arrivalTime = departureTime.AddMinutes(rnd.Next());
                yield return new JourneySearchJourney
                {
                    Origin = request.Origin,
                    Destination = request.Destination,
                    DepartureTime = departureTime,
                    ArrivalTime = arrivalTime,
                };
            }
        }
    }
}