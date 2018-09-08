using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace Eventos.IO.Application.ViewModels
{
    public class CategoriaViewModel
    {
        public CategoriaViewModel()
        {
            Id = new Guid();
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }

        public SelectList Categorias()
        {
            return new SelectList(ListarCategorias(), "Id", "Nome");
        }

        public List<CategoriaViewModel> ListarCategorias()
        {
            return new List<CategoriaViewModel>()
            {
                new CategoriaViewModel() {Nome = "Acre"},
                new CategoriaViewModel() {Nome = "Alagoas"},
                new CategoriaViewModel() {Nome = "Amapá"}
            };
        }
    }
}
