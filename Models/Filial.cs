using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace DB_Hotel
{
    public class Filial
    {
        [Key]
        public int Codigo_Filial {get; set;}
        [StringLength(50)]
        public string? Nome_Filial {get; set;}        
        public int qtdEstrelas_Filial {get; set;} 
        public string? Pais_Endereco {get; set;}
        public int Codigo_Endereco {get; set;}
        public Endereco? Endereco {get; set;}
    }
}