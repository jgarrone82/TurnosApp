using System.ComponentModel.DataAnnotations;

namespace SistTurnos.Models
{
    public class Specialty
    {
        [Key]
        public int idSpecialty { get; set; }
        public string Descripction { get; set; }        
    }
}