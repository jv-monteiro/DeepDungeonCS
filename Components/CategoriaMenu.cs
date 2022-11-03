using DeepDungeon.Models;
using DeepDungeon.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DeepDungeon.Components
{
    public class CategoriaMenu : ViewComponent
    {
        private readonly ICategoriaRepository _categoria;

        public CategoriaMenu (ICategoriaRepository categoria)
        {
            _categoria = categoria;
        }

        public IViewComponentResult Invoke()
        {
            var categorias = _categoria.Categorias.OrderBy(p => p.CategoriaName);
            return View(categorias);
        }
    }
}
