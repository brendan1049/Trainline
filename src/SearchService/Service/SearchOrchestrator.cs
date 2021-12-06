using JourneySearchContract;
using JourneySearchContract.Interfaces;
using SearchService.Contract;
using SearchService.Exceptions;

namespace SearchService.Service
{
    public interface ISearchOrchestrator
    {
        SearchResponse PerformSearch(SearchRequest request);
    }

    public class SearchOrchestrator : ISearchOrchestrator
    {
        private readonly ISearchLocationMapper _locationMapper;
        private readonly IJourneySearchService _journeySearchService;
        private readonly IJourneySearchResponseMapper _responseMapper;

        public SearchOrchestrator(ISearchLocationMapper locationMapper, IJourneySearchService journeySearchService, IJourneySearchResponseMapper responseMapper)
        {
            _locationMapper = locationMapper;
            _journeySearchService = journeySearchService;
            _responseMapper = responseMapper;
        }

        public SearchResponse PerformSearch(SearchRequest request)
        {
            throw new UnhandledException ("Testing Exception");

            var fromCode = _locationMapper.MapToUkCode(request.From);
            var toCode = _locationMapper.MapToUkCode(request.To);
            var journeyResults = _journeySearchService.PerformSearch(new JourneySearchRequest
            {
                Origin = fromCode,
                Destination = toCode,
                DepartureTime = request.DepartureTime,
            });
            return _responseMapper.MapResponse(journeyResults);
        }
    }
}