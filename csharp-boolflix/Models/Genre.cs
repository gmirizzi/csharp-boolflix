using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace csharp_boolflix.Models
{
    [Table("genres")]
    public class Genre
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public List<Film> FilmsList { get; set; }
        public List<Serie> SeriesList { get; set; }
    }
}
