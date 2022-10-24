using DeepDungeon.Context;
using DeepDungeon.Models;
using DeepDungeon.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DeepDungeon.Repositorios
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDbContext _context;
        public ProdutoRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Produto> Produtos => _context.Produtos.Include(c => c.Categoria);

        public IEnumerable<Produto> ProdutosFavoritos => _context.Produtos.Where(f => f.IsFav).Include(c => c.Categoria);

        public Produto GetProdutoById(int produtoId)
        {
            return _context.Produtos.FirstOrDefault(i => i.ProdutoId == produtoId);
        }
    }
}
