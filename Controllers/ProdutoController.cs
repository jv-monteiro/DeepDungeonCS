using DeepDungeon.Models;
using DeepDungeon.Repositorios.Interfaces;
using DeepDungeon.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DeepDungeon.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;
        public ProdutoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IActionResult List(string categoria)
        {
            ViewData["Hora"] = DateTime.Now;
            
            //Filtro por categorias
            IEnumerable<Produto> produtos;
            string categoriaAtual = string.Empty;

            if (string.IsNullOrEmpty(categoria))
            {
                produtos = _produtoRepository.Produtos.OrderBy(p => p.ProdutoId);
                categoriaAtual = "Todos os produtos";
            }
            else
            {
                produtos = _produtoRepository.Produtos.Where(p => p.Categoria.CategoriaName.Equals(categoria)).OrderBy(c => c.ProdutoName);
                categoriaAtual = categoria;
            }

            var produtoListViewModel = new ProdutoListViewModel()
            {
                Produtos = produtos,
                CategoriaAtual = categoriaAtual
            };

            var produtosCount = produtoListViewModel.Produtos.Count();
            ViewBag.TotalProdutos = produtosCount;

            return View(produtoListViewModel);
        }



    }
}
