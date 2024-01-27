using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace DB_Hotel
{
    public class TipoFuncionario
    {
        [Key]
        public int Codigo_TipoFuncionario {get; set;}
        [StringLength(50)]        
        public string? Desc_TipoFuncionario {get; set;}        
    }
}