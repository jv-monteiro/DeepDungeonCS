using DeepDungeon.Models;
using Microsoft.AspNetCore.Mvc;

namespace DeepDungeon.Repositorios.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }

    }
}
