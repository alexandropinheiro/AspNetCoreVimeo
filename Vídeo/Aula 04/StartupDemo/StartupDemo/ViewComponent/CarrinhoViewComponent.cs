using Microsoft.AspNetCore.Mvc;
using StartupDemo.Models;

namespace StartupDemo.ViewComponent
{
    public class CarrinhoViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            //LOGICA
            var carrinho = new Carrinho()
            {
                TotalItens = 10,
                ValorTotal = 550
            };
        }
    }    
}
