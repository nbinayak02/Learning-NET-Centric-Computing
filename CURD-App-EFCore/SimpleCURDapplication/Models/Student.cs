using System.ComponentModel.DataAnnotations;

namespace SimpleCURDapplication.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = "";
        [Required]
        public int Semester { get; set; }
        [Required]
        public string Faculty { get; set; } = "";
    }
}
