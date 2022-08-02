using System.ComponentModel.DataAnnotations.Schema;

namespace csharp_boolflix.Models
{
    [Table("films")]
    public class Film : Content
    {
        public int Duration { get; set; }
        public List<Genre> GenresList { get; set; }
        public List<Language> LanguagesList { get; set; }
    }
}
