using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ApiStands.Models
{
    [Table("Stands")]
    public class Stand
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Tipo_Habilidade { get; set; }
        public string Forma { get; set; }
        public string Portador { get; set; }
        public int Parte { get; set; }
        public string Habilidade { get; set; }
        public string Foto { get; set; }

        [Required]
        public string Status { get; set; }
    }
}
