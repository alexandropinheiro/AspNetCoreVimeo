using Eventos.IO.Domain.Core.Events;
using Eventos.IO.Domain.Eventos.Commands;
using System;

namespace ConsoleTeste
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var bus = new FakeBus();

            //Registro com sucesso
            var cmd = new RegistrarEventoCommand("Devx", DateTime.Now.AddDays(1), DateTime.Now.AddDays(2), true, 0, true, "Alexandro Pinheiro");
            Inicio(cmd);
            bus.SendCommand(cmd);
            Fim(cmd);

            //Registro com erros
            cmd = new RegistrarEventoCommand("", DateTime.Now.AddDays(2), DateTime.Now.AddDays(1), false, 0, false, "");
            Inicio(cmd);
            bus.SendCommand(cmd);
            Fim(cmd);

            //Atualizar Evento
            var cmd2 = new AtualizarEventoCommand(Guid.NewGuid(), "Devx", "", "", DateTime.Now.AddDays(1), DateTime.Now.AddDays(2), true, 0, true, "Alexandro Pinheiro");
            Inicio(cmd2);
            bus.SendCommand(cmd2);
            Fim(cmd2);

            //Excluir Evento
            var cmd3 = new ExcluirEventoCommand(Guid.NewGuid());
            Inicio(cmd3);
            bus.SendCommand(cmd3);
            Fim(cmd3);

            Console.ReadKey();
        }

        private static void Inicio(Message message)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"Início do comando {message.MessageType}");
        }

        private static void Fim(Message message)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"Fim do comando {message.MessageType}");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("***************************");
            Console.WriteLine("");
        }
    }
}
