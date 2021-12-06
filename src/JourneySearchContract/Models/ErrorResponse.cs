using System.Text.Json.Serialization;

namespace JourneySearchContract.Models
{
    public class ErrorResponse
    {
        public string Title { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string[] Errors { get; set; }
        public string Detail { get; set; }
        public int Status { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string TraceId { get; set; }
    }
}
