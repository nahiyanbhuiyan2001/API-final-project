
namespace MyAPI.Models
{
    public class SoccerResult<TValue>
    {
        public int StatusCode { get; set; }
        public string? StatusDescription { get; set; }
        public IEnumerable<TValue>? Response { get; set; }
    }
}