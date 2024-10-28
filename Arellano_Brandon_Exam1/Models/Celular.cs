using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Arellano_Brandon_Exam1.Models
{
    public class Celular
    {
        [Key]
        [Required]
        [MinLength(1)]
        [MaxLength(200)]
        [NotNull]
        public string ID { get; set; }
        [Required]
        [MinLength(1)]
        [MaxLength(200)]
        [NotNull]
        public string model { get; set; }
        [Required]
        [MinLength(1)]
        [MaxLength(200)]
        [NotNull]
        public int year { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(200)]
        [NotNull]
        public float precio { get; set; }



    }
}
