using JourneySearchContract;
using SearchService.Contract;

namespace SearchService.Interfaces
{
    public interface IJourneySearchResponseMapper
    {
        SearchResponse MapResponse(JourneySearchResponse journeySearchRequest);
    }
}
