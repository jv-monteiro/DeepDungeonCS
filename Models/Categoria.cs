using System.ComponentModel.DataAnnotations;

namespace DeepDungeon.Models
{
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }

        [Required]
        [StringLength(100)]
        public string CategoriaName { get; set; }

        public List<Produto> Produtos { get; set; }
    }
}