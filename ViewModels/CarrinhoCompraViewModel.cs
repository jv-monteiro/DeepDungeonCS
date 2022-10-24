using DeepDungeon.Models;
using Microsoft.AspNetCore.Mvc;

namespace DeepDungeon.ViewModels
{
    public class CarrinhoCompraViewModel
    {
        public CarrinhoCompra CarrinhoCompra { get; set; }
        public decimal CarrinhoCompraTotal { get; set; }
    }
}
