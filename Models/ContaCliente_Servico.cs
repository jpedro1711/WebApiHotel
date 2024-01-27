using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace DB_Hotel
{
    public class ContaCliente_Servico
    {
        [Key]
        public int Codigo_ContaCliente {get; set;}
        [Key]
        public int Codigo_Servico {get; set;}                
        [Key]
        public DateTime DataHora_Servico {get; set;}                    
        public int? Codigo_Funcionario {get; set;}
        public ContaCliente? ContaCliente {get; set;}
        public Servico? Servico {get; set;}
        public Funcionario? Funcionario {get; set;}
    }
}