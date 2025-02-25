using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieReportApp0.Models
{
    [Table("MovieGenre")]

    public class MovieGenreModels
    {
        [Key, Required]
        public int MovieId { get; set; }
        public int GenreId { get; set; }
    }
}
