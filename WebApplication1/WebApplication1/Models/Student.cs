using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Student
    {
        public string IndexNumber { get; set; }
        [Required(ErrorMessage ="To pole jest wymagane")]
        [MaxLength(10)]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
    }
}
    