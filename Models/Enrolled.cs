namespace linQSami_queries_blazor_server_assignment_4.Models
{
    public class Enrolled
    {
        public int Id { get; set; }
        public int Cid { get; set; }
        public Class Class { get; set; }
        public int Sid { get; set; }
        public Student Student { get; set; }

    }
}
