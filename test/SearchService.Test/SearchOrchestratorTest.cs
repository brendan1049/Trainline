using FluentAssertions;
using JourneySearchContract;
using NSubstitute;
using SearchService.Contract;
using SearchService.Service;
using Xunit;

namespace SearchService.Test
{
    public class SearchOrchestratorTest
    {
        private readonly SearchOrchestrator _sut;
        private readonly ISearchLocationMapper _locationMapper;
        private readonly IJourneySearchService _journeySearchService;
        private readonly IJourneySearchResponseMapper _journeySearchResponseMapper;

        public SearchOrchestratorTest()
        {
            _locationMapper = Substitute.For<ISearchLocationMapper>();
            _journeySearchService = Substitute.For<IJourneySearchService>();
            _journeySearchResponseMapper = Substitute.For<IJourneySearchResponseMapper>();
            _sut = new SearchOrchestrator(_locationMapper, _journeySearchService, _journeySearchResponseMapper);
        }

        [Fact]
        public void PerformSearch()
        {
            //Setup
            var to = new Location();
            var from = new Location();
            var searchRequest = new SearchRequest{From = from, To = to};
            var journeySearchResponse = new JourneySearchResponse();
            var searchResponse = new SearchResponse();

            _locationMapper.MapToUkCode(from).Returns("orig");
            _locationMapper.MapToUkCode(to).Returns("Dest");
            _journeySearchService.PerformSearch(Arg.Is<JourneySearchRequest>(j => j.Origin == "orig" && j.Destination == "Dest"))
                .Returns(journeySearchResponse);
            _journeySearchResponseMapper.MapResponse(journeySearchResponse).Returns(searchResponse);
            
            //act
            var result = _sut.PerformSearch(searchRequest);
            
            //assert
            result.Should().Be(searchResponse);
        }
    }
}