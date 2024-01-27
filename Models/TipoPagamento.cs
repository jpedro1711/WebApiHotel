using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace DB_Hotel
{
    public class TipoPagamento
    {   
        [Key]
        public int Codigo_TipoPagamento {get; set;}
        [StringLength(50)]        
        public string? Desc_TipoPagamento {get; set;}        
    }
}