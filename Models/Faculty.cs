using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace linQSami_queries_blazor_server_assignment_4.Models
{
    public class Faculty
    {
        [Key]
        public int Fid { get; set; }
        public string Fname { get; set; }
        public int Deptid { get; set; }
        public string Standing { get; set; }
        public List<Class> Classes { get; set; }
    }
}
