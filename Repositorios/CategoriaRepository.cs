using DeepDungeon.Context;
using DeepDungeon.Models;
using DeepDungeon.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DeepDungeon.Repositorios
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;
        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
