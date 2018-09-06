using Eventos.IO.Domain.Core.Models;
using Eventos.IO.Domain.Organizadores;
using FluentValidation;
using System;
using System.Collections.Generic;

namespace Eventos.IO.Domain.Eventos
{
    public class Evento : Entity<Evento>
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

        private Evento()
        {

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
        public bool Excluido { get; private set; }        
        public ICollection<Tags> Tags { get; private set; }        
        public Dictionary<string, string> ErrosValidacao { get; set; }

        public Guid? CategoriaId { get; private set; }
        public Guid? EnderecoId { get; private set; }
        public Guid OrganizadorId { get; private set; }

        //EF Propriedades de navegação
        public virtual Categoria Categoria { get; private set; }        
        public virtual Organizador Organizador { get; private set; }
        public virtual Endereco Endereco { get; set; }

        public void AtribuirEndereco(Endereco endereco)
        {
            if (!endereco.EhValido()) return;
            Endereco = endereco;
        }

        public void AtribuirCategoria(Categoria categoria)
        {
            if (!categoria.EhValido()) return;
            Categoria = categoria;
        }

        public void ExcluirEvento()
        {
            //TODO: Deve validar alguma regra
            Excluido = true;
        }

        public override bool EhValido()
        {
            Validar();
            return ValidationResult.IsValid;
        }

        #region Validações
        private void Validar()
        {
            ValidarNome();
            ValidarValor();
            ValidarData();
            ValidarLocal();
            ValidarNomeEmpresa();
            ValidationResult = Validate(this);

            // Validações adicionais
            ValidarEndereco();
        }

        private void ValidarNome()
        {
            RuleFor(c => c.Nome)
                            .NotEmpty().WithMessage("O nome do evento não pode ser nulo")
                            .Length(2, 150).WithMessage("O nome do evento deve ter entre 2 e 150 caracteres");
        }

        private void ValidarValor()
        {
            if (!Gratuito)
            {
                RuleFor(c => c.Valor)
                    .ExclusiveBetween(1, 50000)
                    .WithMessage("O valor deve estar entre 1,00 e 50.000,00");
            }
            else
            {
                RuleFor(c => c.Valor)
                    .ExclusiveBetween(0, 0).When(e => e.Gratuito)
                    .WithMessage("Para evento gratuito o valor deve ser zero");
            }

        }

        private void ValidarData()
        {
            RuleFor(c => c.DataInicio)
                .GreaterThan(c => DataFim)
                .WithMessage("A data de início deve ser menor do que a data final");

            RuleFor(c => c.DataInicio)
                .LessThan(c => DataInicio)
                .WithMessage("A data de início deve ser menor do que a data atual");

        }

        private void ValidarLocal()
        {
            if (Online)
            {
                RuleFor(c => c.Endereco)
                .Null().When(c => c.Online)
                .WithMessage("O evento não deve possuir endereço se for Online.");
            }
            else {
                RuleFor(c => c.Endereco)
                .NotNull().When(c => c.Online == false)
                .WithMessage("O evento deve possuir um endereço.");
            }


            RuleFor(c => c.DataInicio)
                .LessThan(c => DataInicio)
                .WithMessage("A data de início deve ser menor do que a data atual");

        }

        private void ValidarNomeEmpresa()
        {
            RuleFor(c => c.NomeEmpresa)
                .NotEmpty().WithMessage("O nome do organizador precisa ser fornecido")
                .Length(2, 150).WithMessage("O nome do organizador precisa ter entre 2 e 150 caracteres");
        }

        private void ValidarEndereco()
        {
            if (Online) return;
            if (Endereco.EhValido()) return;

            foreach(var error in Endereco.ValidationResult.Errors)
            {
                ValidationResult.Errors.Add(error);
            }
        }
        #endregion

        public static class EventoFactory
        {
            public static Evento NovoEventoCompleto(Guid id,
                                                    string nome,
                                                    string descCurta,
                                                    string descLonga,
                                                    DateTime dataInicio,
                                                    DateTime dataFim,
                                                    bool gratuito,
                                                    decimal valor,
                                                    bool online,
                                                    string nomeEmpresa,
                                                    Guid? OrganizadorId,
                                                    Endereco endereco,
                                                    Guid categoriaId)
            {
                var evento = new Evento()
                {
                    Id = id,
                    Nome = nome,
                    DataInicio = dataInicio,
                    DataFim = dataFim,
                    Gratuito = gratuito,
                    Valor = valor,
                    Online = online,
                    NomeEmpresa = nomeEmpresa,
                    Endereco = endereco,
                    CategoriaId = categoriaId
                };

                if (OrganizadorId.HasValue)
                    evento.OrganizadorId = OrganizadorId.Value;

                if (online)
                    evento.Endereco = null;

                return evento;
            }
        }        
    }
}
