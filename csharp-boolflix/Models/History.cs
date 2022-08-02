using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace csharp_boolflix.Models
{
    [Table("histories")]
    public class History
    {
        [Key]
        public int Id { get; set; }
        public List<Film> FilmsList { get; set; }
        public List<Serie> SeriesList { get; set; }
    }
}
