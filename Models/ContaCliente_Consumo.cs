using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace DB_Hotel
{
    public class ContaCliente_Consumo
    {
        [Key]
        public int Codigo_ContaCliente {get; set;}
        [Key]
        public int Codigo_Consumo {get; set;}      
        [Key]          
        public DateTime DataHora_Consumo {get; set;} 
        public bool? Entrega_Consumo{get; set;}                     
        public int? Codigo_Funcionario {get; set;}
        public ContaCliente? ContaCliente {get; set;}
        public Consumo? Consumo {get; set;}
        public Funcionario? Funcionario {get; set;}
    }
}