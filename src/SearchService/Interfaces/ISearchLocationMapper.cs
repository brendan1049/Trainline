using SearchService.Contract;

namespace SearchService.Interfaces
{
    public interface ISearchLocationMapper
    {
        string MapToUkCode(Location loc);
    }
}
