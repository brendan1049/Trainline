using SearchService.Contract;
using SearchService.Interfaces;

namespace SearchService.Mappers
{
    public class SearchLocationMapper : ISearchLocationMapper
    {
        public string MapToUkCode(Location loc)
        {
            return loc.Code;
        }
    }
}