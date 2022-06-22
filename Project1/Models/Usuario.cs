using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Models
{
    public class Usuario
    {
        [Key]
        public int id { get; set; }
        public string nome { get; set; }
        public List<Calculo>ListaDeCalculo {get;set;}
    }
}
