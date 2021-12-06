using System.Collections.Generic;

namespace SearchService.Contract
{
    public class Location
    {
        public string Code { get; set; }
        public IEnumerable<string> Regions { get; set; }
    }
}