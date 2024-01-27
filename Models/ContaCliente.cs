using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace DB_Hotel
{
    public class ContaCliente
    {
        [Key]
        public int Codigo_ContaCliente {get; set;}        
        public int? Codigo_Cliente {get; set;}    
         public Cliente? Cliente {get; set;}
    }
}