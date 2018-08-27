using System;
using System.ComponentModel.DataAnnotations;

namespace StartupDemo.Models
{
    public class Evento
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="O nome é obrigatório")]
        [Display(Name ="Nome Completo")]
        [MaxLength(100, ErrorMessage = "O tamanho máximo é 100.")]
        [MinLength(2, ErrorMessage = "O tamanho máximo é 2.")]
        public string Nome { get; set; }
        [Range(10, 1000)]
        [Required(ErrorMessage = "Preencha o valor")]
        public decimal Valor { get; set; }
        public bool Gratuito { get; set; }
        [Required(ErrorMessage = "Descrição obrigatória")]
        [MaxLength(1000, ErrorMessage = "Tamanho máximo é 1000.")]
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
    }
}
