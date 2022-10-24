using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace DeepDungeon.Models
{
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }

        [Required]
        [StringLength(100)]
        public string ProdutoName { get; set; }

        [Required]
        [StringLength (200)]
        public string ProdutoDescription { get; set; }

        [Required]
        [Column(TypeName ="decimal(10, 2)")]
        [Range(1,999.99)]
        public decimal ProdutoPrice { get; set; }

        public string ProdutoImage { get; set; }

        public bool IsFav { get; set; }

        public bool EmEstoque { get; set; }




        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}