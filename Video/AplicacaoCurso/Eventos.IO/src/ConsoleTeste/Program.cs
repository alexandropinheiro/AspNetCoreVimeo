using Eventos.IO.Domain.Models;
using System;

namespace ConsoleTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            var evento = new Evento("No", DateTime.Now, DateTime.Now, true, 50, false, "Alexandro Pinheiro");
            var evento2 = evento;
            Console.WriteLine(evento.ToString());
            
            if (!evento.EhValido())
            {
                foreach(var erro in evento.ErrosValidacao)
                {
                    Console.WriteLine(erro.Value);
                }
            }

            Console.ReadKey();
        }
    }
}
