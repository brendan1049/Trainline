using System;
using System.ComponentModel.DataAnnotations;

namespace SearchService.Contract
{
    public class SearchRequest
    {
        [Required]
        public Location From { get; set; }
        [Required]
        public Location To { get; set; }
        [Required]
        public DateTime DepartureTime { get; set; }
    }
}