using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace DB_Hotel
{
    public class Reserva
    {   
        [Key]
        public int Codigo_Filial {get; set;}
        public int Codigo_Reserva {get; set;} 
        [StringLength(5)]               
        public string? Numero_Quarto {get; set;}   
        public int? Codigo_Cliente {get; set;}
        public int? Codigo_NotaFiscal {get; set;}
        [DataType(DataType.Date)] 
        public DateTime? DataInicio_Reserva {get; set;}
        [DataType(DataType.Date)]   
        public DateTime? DataFim_Reserva {get; set;}                   
        public bool? Cancelada_Reserva {get; set;}                   
        public bool? CobrancaDiaria_Reserva {get; set;}
        public decimal? ValorTotal_Reserva {get; set;}
        public Filial? Filial {get; set;}
        public Quarto? Quarto {get; set;}
        public Cliente? Cliente {get; set;}
        public NotaFiscal? NotaFiscal {get; set;}
    }
}