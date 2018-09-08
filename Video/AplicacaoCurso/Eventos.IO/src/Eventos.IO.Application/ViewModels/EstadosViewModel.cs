using System.Collections.Generic;

namespace Eventos.IO.Application.ViewModels
{
    public class EstadosViewModel
    {
        public string Uf { get; set; }
        public string Nome { get; set; }

        public static List<EstadosViewModel> ListarEstados()
        {
            return new List<EstadosViewModel>()
            {
                new EstadosViewModel() {Uf = "AC", Nome = "Acre"},
                new EstadosViewModel() {Uf = "AL", Nome = "Alagoas"},
                new EstadosViewModel() {Uf = "AP", Nome = "Amapá"},
                new EstadosViewModel() {Uf = "AM", Nome = "Amazonas"},
                new EstadosViewModel() {Uf = "BA", Nome = "Bahia"},
                new EstadosViewModel() {Uf = "CE", Nome = "Ceará"},
                new EstadosViewModel() {Uf = "DF", Nome = "Distrito Federal"},
                new EstadosViewModel() {Uf = "ES", Nome = "Espírito Santo"},
                new EstadosViewModel() {Uf = "GO", Nome = "Goiás"},
                new EstadosViewModel() {Uf = "MA", Nome = "Maranhão"},
                new EstadosViewModel() {Uf = "MT", Nome = "Mato Grosso"},
                new EstadosViewModel() {Uf = "MS", Nome = "Mato Grosso do Sul"},
                new EstadosViewModel() {Uf = "MG", Nome = "Minas Gerais"},
                new EstadosViewModel() {Uf = "PA", Nome = "Pará"},
                new EstadosViewModel() {Uf = "PB", Nome = "Paraíba"},
                new EstadosViewModel() {Uf = "PR", Nome = "Paraná"},
                new EstadosViewModel() {Uf = "PE", Nome = "Pernambuco"},
                new EstadosViewModel() {Uf = "PI", Nome = "Piauí"},
                new EstadosViewModel() {Uf = "RJ", Nome = "Rio de Janeiro"},
                new EstadosViewModel() {Uf = "RN", Nome = "Rio Grande do Norte"},
                new EstadosViewModel() {Uf = "RS", Nome = "Rio Grande do Sul"},
                new EstadosViewModel() {Uf = "RO", Nome = "Rondônia"},
                new EstadosViewModel() {Uf = "RR", Nome = "Roraima"},
                new EstadosViewModel() {Uf = "SC", Nome = "Santa Catarina"},
                new EstadosViewModel() {Uf = "SP", Nome = "São Paulo"},
                new EstadosViewModel() {Uf = "SE", Nome = "Sergipe"},
                new EstadosViewModel() {Uf = "TO", Nome = "Tocantins"}
            };
        }
    }
}
