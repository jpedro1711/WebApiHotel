using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace DB_Hotel
{
    public class Cliente
    {
        [Key]
        public int Codigo_Cliente {get; set;}
        [StringLength(100)]
        public string? Nome_Cliente {get; set;}        
        [StringLength(100)]
        public string? Nacionalidade_Cliente {get; set;}
        [StringLength(30)]        
        public int? Codigo_Endereco {get; set;}
        public Endereco? Endereco {get; set;}
    }
}