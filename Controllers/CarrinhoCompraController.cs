using DeepDungeon.ViewModels;
using DeepDungeon.Models;
using Microsoft.AspNetCore.Mvc;
using DeepDungeon.Repositorios.Interfaces;

namespace DeepDungeon.Controllers
{
    public class CarrinhoCompraController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly CarrinhoCompra _carrinhoCompra;

        public CarrinhoCompraController(IProdutoRepository produtoRepository, CarrinhoCompra carrinhoCompra)
        {
            _produtoRepository = produtoRepository;
            _carrinhoCompra = carrinhoCompra;
        }

        public IActionResult Index()
        {
            var itens = _carrinhoCompra.GetCarrinhoItems();
            _carrinhoCompra.CarrinhoItems = itens;

            var carrinhoCompraVM = new CarrinhoCompraViewModel
            {
                CarrinhoCompra = _carrinhoCompra,
                CarrinhoCompraTotal = _carrinhoCompra.GetCarrinhoTotal(),
            };

            return View(carrinhoCompraVM);
        }

        public IActionResult AddToCart(int produtoId)
        {
            var produtoSelecionado = _produtoRepository.Produtos.FirstOrDefault(p => p.ProdutoId == produtoId);
            if (produtoSelecionado != null)
            {
                _carrinhoCompra.AddToCart(produtoSelecionado);
            }
            return RedirectToAction("Index");
        }

        public IActionResult RemoveFromCart(int produtoId)
        {
            var produtoSelecionado = _produtoRepository.Produtos.FirstOrDefault(p => p.ProdutoId == produtoId);
            if (produtoSelecionado != null)
            {
                _carrinhoCompra.RemoveFromCart(produtoSelecionado);
            }
            return RedirectToAction("Index");
        }
    }
}