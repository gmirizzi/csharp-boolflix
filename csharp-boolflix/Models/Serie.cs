using System.ComponentModel.DataAnnotations.Schema;

namespace csharp_boolflix.Models
{
    [Table("series")]
    public class Serie : Content
    {
        public List<Genre> GenresList { get; set; }
        public List<Language> LanguagesList { get; set; }
        public List<History>? HistoriesList { get; set; }
    }
}
