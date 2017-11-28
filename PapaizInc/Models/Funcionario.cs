using System;
using System.ComponentModel.DataAnnotations;

namespace PapaizInc.Models
{
    public class Funcionario
    {
        public int ID { get; set; }
        [Required]
        public String Nome { get; set; }
        [Required]
        public String Telefones { get; set; }
        [Required]
        public String Identidade { get; set; }
        [Required]
        public String CarteiraDeTrabalho { get; set; }
        [Required]
        public double Salario { get; set; }
        [Required]
        public Boolean Motorista { get; set; }
        [Required]
        public Boolean Tecnico { get; set; }

        public String Observacoes { get; set; }
    }
}
