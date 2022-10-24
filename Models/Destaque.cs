using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace DeepDungeon.Models
{
    public class Destaque
    {
        public bool IsFav { get; set; }
       public List<Produto> Produtos { get; set; }
    }
}
