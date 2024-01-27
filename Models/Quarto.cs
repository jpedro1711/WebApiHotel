using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace DB_Hotel
{
    public class Quarto
    {   
        [Key]
        public int Codigo_Filial {get; set;}
        [Key]
        public int Numero_Quarto {get; set;}                
        public int? Codigo_TipoQuarto {get; set;}        
        public int? CapacidadeMax_Quarto {get; set;} 
        public bool? CapacidadeOpc_Quarto {get; set;}                        
        public Filial? Filial {get; set;}
        public TipoQuarto? TipoQuarto {get; set;}
    }
}