using System.ComponentModel.DataAnnotations;

namespace A_Rent_demo.Models
{
    public class MB
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        public string Mensaje { get; set; }
    }
}