using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace DB_Hotel
{
    public class NotaFiscal
    {
        [Key]
        public int Codigo_NotaFiscal {get; set;}        
        [StringLength(35)]        
        public string? Numero_NotaFiscal {get; set;}
        [DataType(DataType.Date)] 
        public DateTime? Data_NotaFiscal {get; set;}                
        public decimal? ValorTotal_NotaFiscal {get; set;}
        public int? Codigo_TipoPagamento {get; set;}
        public TipoPagamento? TipoPagamento {get; set;}
    }
}