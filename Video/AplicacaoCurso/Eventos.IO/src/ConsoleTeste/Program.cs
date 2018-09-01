using Eventos.IO.Domain.Models;
using System;

namespace ConsoleTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            var evento = new Evento("No", DateTime.Now, DateTime.Now, true, 50, false, "");
            var evento2 = evento;
            Console.WriteLine(evento.ToString());
            
            if (!evento.ValidationResult.IsValid)
            {
                foreach(var erro in evento.ValidationResult.Errors)
                {
                    Console.WriteLine(erro.ErrorMessage);
                }
            }

            Console.ReadKey();
        }
    }
}
