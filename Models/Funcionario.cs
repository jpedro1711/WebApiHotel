using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace DB_Hotel
{
    public class Funcionario
    {
        [Key]
        public int Codigo_Funcionario {get; set;}        
        [StringLength(50)]        
        public string? Nome_Funcionario {get; set;}        
        public int? Codigo_TipoFuncionario {get; set;}
        public int? Codigo_Filial {get; set;}
        public TipoFuncionario? TipoFuncionario {get; set;}
        public Filial? Filial {get; set;}
    }

}