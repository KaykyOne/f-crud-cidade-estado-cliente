using System;
using System.ComponentModel.DataAnnotations;

namespace CrudEstadoCidadeUsuario.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        [StringLength(1)] 
        public string Sexo { get; set; }

        [Required]
        public int Idade { get; set; }

        [Required]
        public string DataNascimento { get; set; }
        public int CidadeId { get; set; }

        public Cidade? Cidade { get; set; }
    }
}
