using System.ComponentModel.DataAnnotations;

namespace linQSami_queries_blazor_server_assignment_4.Models
{
    public class Student
    {
        [Key]
        public int Sid { get; set; }
        public string Sname { get; set; }
        public string Major { get; set; }
        public string Standing { get; set; }
        public List<Enrolled> EnrolledClasses { get; set; }
    }
}
