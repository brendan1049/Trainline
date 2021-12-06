using SearchService.Contract;

namespace SearchService.Service
{
    public interface ISearchLocationMapper
    {
        string MapToUkCode(Location loc);
    }

    public class SearchLocationMapper : ISearchLocationMapper
    {
        public string MapToUkCode(Location loc)
        {
            return loc.Code;
        }
    }
}