using System.ComponentModel.DataAnnotations;

namespace CrudEstadoCidadeUsuario.Models
{
    public class Cidade
    {
        [Key]
        public int IdCidade { get; set; }
        [Required]
        public string Nome { get; set; }
        public int EstadoId { get; set; }
        public Estado? Estado { get; set; }


    }
}
