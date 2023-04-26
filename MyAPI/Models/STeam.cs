using System.ComponentModel.DataAnnotations;

namespace MyAPI.Models
{
    public class STeam
    {
        [Key]
        public int TeamNum { get; set; }
        public int TableRank { get; set; }
        public int LastYearPos { get; set; }
        public string UCLQualify { get; set; }   
        
        //public List<SPlayer> Players { get; set; }
        //child to team code line
    }
}
