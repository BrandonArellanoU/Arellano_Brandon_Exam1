using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Arellano_Brandon_Exam1.Models
{
    public class ArellanoB
    {
        [Required]
        [MinLength(1)]
        [MaxLength(150)]
        public int edad { get; set; }
        
        public float altura { get; set; }
        [MinLength(1)]
        [Key]
        [NotNull]
        public string nombre { get; set; }
        public bool esHombre { get; set; }

        public DateTime fechaNacimiento { get; set; }

        [ForeignKey(nameof(Celular))]
        public Celular? celular { get; set; }



    }
}
