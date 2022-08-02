using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace csharp_boolflix.Models
{
    [Table("seasons")]
    public class Season
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Number { get; set; }
        public List<Episode> EpisodesList { get; set; }
        public Serie Serie { get; set; }
        public int SerieId { get; set; }
    }
}
