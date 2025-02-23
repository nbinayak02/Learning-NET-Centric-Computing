using System.ComponentModel.DataAnnotations;

namespace AdoCurd.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string? Gender { get; set; }
    }
}
