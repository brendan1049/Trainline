using Microsoft.AspNetCore.Mvc;
using SearchService.Contract;
using SearchService.Service;

namespace SearchService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SearchController : ControllerBase
    {
        private readonly ISearchOrchestrator _searchOrchestrator;

        public SearchController(ISearchOrchestrator searchOrchestrator)
        {
            _searchOrchestrator = searchOrchestrator;
        }

        [HttpPost]
        public IActionResult Index([FromBody]SearchRequest request)
        {
            var searchResponse = _searchOrchestrator.PerformSearch(request);
            return Ok(searchResponse);
        }
    }
}