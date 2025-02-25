using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieReportApp0.Models
{
    [Table("Review")]
    public class ReviewModels
    {
        [Key, Required]
        public int Id { get; set; }
        public int Rating { get; set; } // 1 - 10
        public string Comment { get; set; } = string.Empty;
        public int MovieId { get; set; }
        public int UserId { get; set; }
    }
}
