using DeepDungeon.Models;
using DeepDungeon.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DeepDungeon.Components
{
    public class SacolaResumo : ViewComponent
    {
        private readonly CarrinhoCompra _carrinhoCompra;

        public SacolaResumo(CarrinhoCompra carrinhoCompra)
        {
            _carrinhoCompra = carrinhoCompra;
        }

        public IViewComponentResult Invoke()
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
    }
}
