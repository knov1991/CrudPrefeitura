using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudPrefeitura.Models
{
    [Table("livros")]
    public class Product
    {
        [Key]
        public int ID { get; set; }
        public string Nome { get; set; }

        public float Preço { get; set; }

        public string Tipo { get; set; }

        public string Autor { get; set; }
    }
}
