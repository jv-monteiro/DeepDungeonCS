using System.ComponentModel.DataAnnotations;

namespace DeepDungeon.Models
{
    public class CarrinhoItem
    {
        [StringLength(200)]
        public string CarrinhoId { get; set; }
        public int CarrinhoItemId { get; set; }
        public Produto Produto { get; set; }

        public int Quantidade { get; set; }
    }
}
