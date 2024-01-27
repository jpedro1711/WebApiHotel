using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace DB_Hotel
{
    public class Email
    {
        [Key]
        public int Codigo_Email {get; set;}
        
        public int? Codigo_Cliente {get; set;}        
        [StringLength(100)]
        public string? Endereco_Email {get; set;}        
         public Cliente? Cliente {get; set;}
    }
}