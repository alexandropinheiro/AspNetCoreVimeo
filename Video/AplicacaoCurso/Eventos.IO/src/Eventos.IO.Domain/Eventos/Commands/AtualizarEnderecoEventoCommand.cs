﻿using Eventos.IO.Domain.Core.Commands;
using System;

namespace Eventos.IO.Domain.Eventos.Commands
{
    public class AtualizarEnderecoEventoCommand : Command
    {
        public AtualizarEnderecoEventoCommand(Guid id,
                                            string logradouro,
                                            string numero,
                                            string complemento,
                                            string bairro,
                                            string cep,
                                            string cidade,
                                            string estado,
                                            Guid? eventoId)
        {
            Id = id;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cep = cep;
            Cidade = cidade;
            Estado = estado;
            EventoId = eventoId;
        }

        public Guid Id { get; private set; }
        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public string Cep { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public Guid? EventoId { get; set; }
    }
}
