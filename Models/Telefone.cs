using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace DB_Hotel
{
    public class Telefone
    {
        [Key]
        public int Codigo_Telefone {get; set;}        
        public int? Codigo_Cliente {get; set;}        
        [StringLength(20)]
        public string? Numero_Telefone {get; set;}
        public Cliente? Cliente {get; set;}
    }
}