using System.ComponentModel.DataAnnotations;

namespace linQSami_queries_blazor_server_assignment_4.Models
{
    public class Class
    {




        [Key]
        public int Cid { get; set; }
        public string Name { get; set; }
        public int RoomNumber { get; set; }
        public int Fid { get; set; }
        public Faculty Faculty { get; set; }
        public List<Enrolled> EnrolledStudents { get; set; }
    }
}
