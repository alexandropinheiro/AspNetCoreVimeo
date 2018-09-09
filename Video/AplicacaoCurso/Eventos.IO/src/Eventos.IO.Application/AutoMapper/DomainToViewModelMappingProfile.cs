﻿using AutoMapper;
using Eventos.IO.Application.ViewModels;
using Eventos.IO.Domain.Eventos.Commands;

namespace Eventos.IO.Application.AutoMapper
{
    public partial class AutoMapperConfiguration
    {
        public class DomainToViewModelMappingProfile : Profile
        {
            public DomainToViewModelMappingProfile()
            {
                CreateMap<EventoViewModel, RegistrarEventoCommand>()
                    .ConstructUsing(c => new RegistrarEventoCommand(c.Nome, c.DescricaoCurta, c.DescricaoLonga, c.DataInicio, c.DataFim, c.Gratuito, c.Valor, c.Online, c.NomeEmpresa, c.OrganizadorId, c.CategoriaId,
                    new IncluirEnderecoEventoCommand(c.Endereco.Id, c.Endereco.Logradouro, c.Endereco.Numero, c.Endereco.Complemento, c.Endereco.Bairro, c.Endereco.Cep, c.Endereco.Cidade, c.Endereco.Estado, c.Id)));

                CreateMap<EventoViewModel, AtualizarEventoCommand>()
                    .ConstructUsing(c => new AtualizarEventoCommand(c.Id, c.Nome, c.DescricaoCurta, c.DescricaoLonga, c.DataInicio, c.DataFim, c.Gratuito, c.Valor, c.Online, c.NomeEmpresa, c.OrganizadorId, c.CategoriaId));

                CreateMap<EventoViewModel, ExcluirEventoCommand>()
                    .ConstructUsing(c => new ExcluirEventoCommand(c.Id));
            }
        }
    }
}
