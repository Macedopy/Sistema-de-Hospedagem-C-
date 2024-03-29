using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
      public List<Pessoa> Hospedes { get; set; }
      public Suite Suite { get; set; }
      public int DiasnaReserva { get; set; }

      public Reserva(int diasnaReserva)
      {
            DiasnaReserva = diasnaReserva;
      }
      public void CadastrarHospedes(List<Pessoa> hospedes)
      {
            if(hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("Não será possível realizar o cadastro, pois o número de hóspedes está ultrapassando a capacidade permitida.");
            }
      }

      public void CadastrarSuite(Suite suite)
      {
            Suite = suite;
      }
      public int ObterQuantidadeHospedes()
      {
            return Hospedes.Count;
      }  

    public decimal CalcularValorDiaria()
    {
            decimal valor = 0;
            valor = diasnaReserva * Suite.ValorDiaria;
            if(diasnaReserva >= 10)
            {
                valor = valor - (valor * 10) / 100;
            }
            return valor;
        }
    }   
}
