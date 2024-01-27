using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace DB_Hotel
{
    public class TipoQuarto
    {
        [Key]
        public int Codigo_TipoQuarto {get; set;}
        [StringLength(50)]
        public string? Desc_TipoQuarto {get; set;}        
        public decimal? Valor_TipoQuarto {get; set;} 
        public int? Codigo_Filial {get; set;}                
        public Filial? Filial {get; set;}
    }

}