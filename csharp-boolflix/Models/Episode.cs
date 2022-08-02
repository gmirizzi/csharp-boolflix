using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace csharp_boolflix.Models
{
    [Table("episodes")]
    public class Episode
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Number { get; set; }
        public string Title { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }
        public Season Season { get; set; }
        public int SeasonId { get; set; }
    }
}