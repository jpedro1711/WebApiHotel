using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace DB_Hotel
{
    public class Servico
    {   
        [Key]
        public int Codigo_Servico {get; set;}        
        [StringLength(100)]
        public int? Desc_Servico {get; set;}            
        public decimal? Valor_Servico {get; set;}
        public int? Codigo_Filial {get; set;}
        public Filial? Filial {get; set;}
    }
}