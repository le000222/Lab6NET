using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;

namespace Lab6NET.Models
{
    public class Student
    {
        [SwaggerSchema(ReadOnly = true)]
        public Guid Id { get; set; }
        
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Program { get; set; }    
    }
}
