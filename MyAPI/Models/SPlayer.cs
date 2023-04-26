using System.ComponentModel.DataAnnotations;

namespace MyAPI.Models
{
    public class SPlayer
    {
        [Key]
        public string PlayerName { get; set; }
        public int TeamNum { get; set; }
        public int Goals { get; set; }
        public int Assists { get; set; }
        public string Top10 { get; set; }
    }
}