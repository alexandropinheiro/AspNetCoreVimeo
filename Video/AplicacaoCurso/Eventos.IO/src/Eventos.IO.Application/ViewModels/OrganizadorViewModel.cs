using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Eventos.IO.Application.ViewModels
{
    public class OrganizadorViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O nome é requerido.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O CPF é requerido.")]
        [StringLength(11, ErrorMessage = "Tamnho máximo de CPF são 11 caracteres.")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "O e-mail é requerido")]
        [EmailAddress(ErrorMessage = "E-mail em formato inválido.")]
        public string Email { get; set; }
    }
}
