using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrabalhandoFormulario.Models
{
    public class Filme
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo título é obrigatório")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O título precisar ter entre 3 ou 60 caracteres")]
        public string Titulo { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        [Required(ErrorMessage = "O campo data de lançamento é obrigatório")]
        [Display(Name = "Data de Lançamento")]
        public DateTime DataLancamento { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00c0-\u00FF""'\w-]*$", ErrorMessage = "Genero em formato inválido")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Máximo de 30 caracteres"), Required(ErrorMessage = "O campo genero é requerido")]
        public string Genero { get; set; }

        [Range(1, 1000, ErrorMessage = "Valor de 1 a 1000")]
        [Required(ErrorMessage = "Preencha o campo valor")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Preencha o campo avaliação")]
        [Display(Name = "Avaliação")]
        [RegularExpression(@"^[0-5]*$", ErrorMessage = "Somente números")]
        public int Avalicao { get; set; }
    }
}
