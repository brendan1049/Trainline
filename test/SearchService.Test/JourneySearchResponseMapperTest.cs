using System;
using System.Linq;
using FluentAssertions;
using JourneySearchContract;
using SearchService.Service;
using Xunit;

namespace SearchService.Test
{
    public class JourneySearchResponseMapperTest
    {
        private readonly JourneySearchResponseMapper _sut;

        public JourneySearchResponseMapperTest()
        {
            _sut = new JourneySearchResponseMapper();
        }

        [Fact]
        public void MapResponse()
        {
            DateTime now = DateTime.Now;
            var input = new JourneySearchResponse
            {
                Journeys = new []
                {
                    new JourneySearchJourney
                    {
                        Origin = "To",
                        Destination = "From",
                        ArrivalTime = now,
                        DepartureTime = now.AddMinutes(10),
                    },
                    new JourneySearchJourney
                    {
                        Origin = "To",
                        Destination = "From",
                        ArrivalTime = now.AddMinutes(5),
                        DepartureTime = now.AddMinutes(15),
                    },
                }
            };
            var result = _sut.MapResponse(input);
            result.Journeys.Count().Should().Be(2);
            result.Journeys.First().Origin.Should().Be("To");
            result.Journeys.First().Destination.Should().Be("From");
            result.Journeys.First().ArrivalTime.Should().Be(now);
        }
    }
}