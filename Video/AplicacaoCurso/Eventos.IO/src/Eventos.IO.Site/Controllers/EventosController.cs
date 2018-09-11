using System;
using Eventos.IO.Application.Interfaces;
using Eventos.IO.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Eventos.IO.Site.Controllers
{
    public class EventosController : Controller
    {
        private readonly IEventoAppService _eventoAppService;

        public EventosController(IEventoAppService eventoAppService)
        {
            _eventoAppService = eventoAppService;
        }

        // GET: Eventos
        public IActionResult Index()
        {
            return View(_eventoAppService.ObterTodos());
        }

        // GET: Eventos/Edit/5
        public IActionResult Details(Guid? id)
        {
            if (id == null) { return NotFound(); }

            var eventoViewModel = _eventoAppService.ObterPorId(id.Value);

            if (eventoViewModel == null) { return NotFound(); }

            return View(eventoViewModel);
        }
        
        // GET: Eventos/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(EventoViewModel eventoViewModel)
        {
            if (!ModelState.IsValid) return View(eventoViewModel);

            _eventoAppService.Registrar(eventoViewModel);
            return View(eventoViewModel);
        }

        // GET: Eventos/Edit/5
        public IActionResult Edit(Guid? id)
        {
            if (id == null) { return NotFound(); }

            var eventoViewModel = _eventoAppService.ObterPorId(id.Value);

            if (eventoViewModel == null) { return NotFound(); }

            return View(eventoViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(EventoViewModel eventoViewModel)
        {
            if (!ModelState.IsValid) return View(eventoViewModel);

            _eventoAppService.Atualizar(eventoViewModel);
            //TODO: Validar s ea operação ocorreu com sucesso.
            return View(eventoViewModel);
        }

        // GET: Eventos/Edit/5
        public IActionResult Delete(Guid? id)
        {
            if (id == null) { return NotFound(); }

            var eventoViewModel = _eventoAppService.ObterPorId(id.Value);

            if (eventoViewModel == null) { return NotFound(); }

            return View(eventoViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
            _eventoAppService.Excluir(id);
            return RedirectToAction("Index");
        }
    }
}