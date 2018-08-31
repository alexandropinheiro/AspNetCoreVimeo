using Eventos.IO.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Eventos.IO.Domain.Models
{
    public class Evento : Entity
    {
        public Evento(string nome, 
                      DateTime dataInicio, 
                      DateTime dataFim, 
                      bool gratuito, 
                      decimal valor,
                      bool online,
                      string nomeEmpresa)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            DataInicio = dataInicio;
            DataFim = dataFim;
            Gratuito = gratuito;
            Valor = valor;
            Online = online;
            NomeEmpresa = nomeEmpresa;

            ErrosValidacao = new Dictionary<string, string>(); 

            if (Nome.Length < 3)
                ErrosValidacao.Add("Nome", "O nome do evento deve ter mais de três caracteres.");

            if (Gratuito && Valor != 0)
                ErrosValidacao.Add("Valor", "Não pode ter valor se gratuito.");
        }

        public string Nome { get; private set; }
        public string DescricaoCurta { get; private set; }
        public string DescricaoLonga { get; private set; }
        public DateTime DataInicio { get; private set; }
        public DateTime DataFim { get; private set; }
        public bool Gratuito { get; private set; }
        public decimal Valor { get; private set; }
        public bool Online { get; private set; }
        public string NomeEmpresa { get; private set; }
        public Categoria Categoria { get; private set; }
        public ICollection<Tags> Tags { get; private set; }
        public Endereco Endereco { get; private set; }
        public Organizador Organizador { get; private set; }
        public Dictionary<string, string> ErrosValidacao { get; set; }
        
        public override bool EhValido()
        {
            Validar();
            return false;
        }

        #region Validações
        private void Validar()
        {

        }
        #endregion
        // Instalar o FluentValidation no Package Managment Console
        //Install-Package FluentValidation -pre
        // Tanto no Domain quanto no Domain.Core
    }
}
