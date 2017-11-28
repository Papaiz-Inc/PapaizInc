using System;
using System.ComponentModel.DataAnnotations;

namespace PapaizInc.Models
{
    public class Produto
    {
        public int ID { get; set; }
        [Required]
        public String Descricao { get; set; }
    }
}
