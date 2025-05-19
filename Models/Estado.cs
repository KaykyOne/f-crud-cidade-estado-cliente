using System.ComponentModel.DataAnnotations;

namespace CrudEstadoCidadeUsuario.Models
{
    public class Estado
    {
        [Key]
        public int IdEstado { get; set; }
        public string Nome { get; set;}
        [Required]
        [StringLength(2)]
        public string Sigla { get; set; }
    }
}
