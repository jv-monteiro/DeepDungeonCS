using DeepDungeon.Models;

namespace DeepDungeon.Repositorios.Interfaces
{
    public interface IProdutoRepository
    {
        public IEnumerable<Produto> Produtos { get; }
        public IEnumerable<Produto> ProdutosFavoritos { get; }

        Produto GetProdutoById(int produtoId);

    }
}
