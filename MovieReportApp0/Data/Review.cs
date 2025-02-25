namespace MovieReportApp0.Data
{
    public class Review
    {
        public int Id { get; set; }
        public int Rating { get; set; } 
        public string Comment { get; set; } = string.Empty;
        public int MovieId { get; set; }
        public int UserId { get; set; }
    }
}
