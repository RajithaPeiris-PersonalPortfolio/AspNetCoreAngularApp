using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
namespace AspNetCoreAngularApp.Server.Models
{
    public class Employee
    {
        [Key]
        public int EmpID { get; set; }

        [Required]
        public string? EmpName { get; set; }

        [Required]
        public string? EmpAge { get; set; }

        [Required]
        public string? Destination { get; set; }

        [Required]
        public string? MobileNumber { get; set; }
    }
}
