using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioProjetoHospedagem.Models
{
    public class Suite
    {

        public Suite(string suitetipo, int capacidade, decimal valordiaria)
        {
            SuiteTipo = suitetipo;
            Lugares = lugares;
            ValorDiaria = valordiaria;
        }


        public string SuiteTipo { get; set; }
        public int Lugares { get; set; }

        public decimal  ValorDiaria { get; set; }
    }
}
