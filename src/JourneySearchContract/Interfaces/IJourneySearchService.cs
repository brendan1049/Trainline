namespace JourneySearchContract.Interfaces
{
    public interface IJourneySearchService
    {
        JourneySearchResponse PerformSearch(JourneySearchRequest request);
    }
}