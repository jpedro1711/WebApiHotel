using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace DB_Hotel
{
    public class Consumo
    {
        [Key]
        public int Codigo_Consumo {get; set;}        
        [StringLength(100)]
        public int? Desc_Consumo {get; set;}            
        public decimal? Valor_Consumo {get; set;} 
        public int? Codigo_Filial {get; set;}        
        public Filial? Filial {get; set;}
    }


}