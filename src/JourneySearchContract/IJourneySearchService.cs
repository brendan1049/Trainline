namespace JourneySearchContract
{
    public interface IJourneySearchService
    {
        JourneySearchResponse PerformSearch(JourneySearchRequest request);
    }
}