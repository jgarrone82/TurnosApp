using System.ComponentModel.DataAnnotations;

namespace TurnosApp.Models
{
    public class Specialty
    {
        [Key]
        public int idSpecialty { get; set; }
        public string Description { get; set; }        
    }
}