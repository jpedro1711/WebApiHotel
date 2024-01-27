using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace DB_Hotel
{
    public class Endereco
    {
        [Key]
        public int Codigo_Endereco {get; set;}
        [StringLength(100)]
        public string? Rua_Endereco {get; set;}        
        [StringLength(10)]
        public string? Numero_Endereco {get; set;}
        [StringLength(30)]
        public string? Complemento_Endereco {get; set;}
        [StringLength(100)]
        public string? Bairro_Endereco {get; set;}
        [StringLength(100)]
        public string? Cidade_Endereco {get; set;}
        [StringLength(50)]
        public string? Estado_Endereco {get; set;}
        [StringLength(100)]
        public string? Pais_Endereco {get; set;}
    }
}