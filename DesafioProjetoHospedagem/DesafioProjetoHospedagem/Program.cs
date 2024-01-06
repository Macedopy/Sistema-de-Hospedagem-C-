using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospede = new List<Pessoa>();


Pessoa p1 = new Pessoa(nomes:"Hóspede 1");

Pessoa p2 = new Pessoa(nomes:"Hóspede 2");

Pessoa p3 = new Pessoa(nomes:"Hóspede 3");

hospede.Add(p1);
hospede.Add(p2);
hospede.Add(p3);

// Cria a suite

Suite suite = new Suite(tiposuite: "Premium", capacidade: 3, valordiaria: 30);

// Cria uma nova reserva, passando a suite e os hóspedes

Reserva reserva = new Reserva(diasReservados: 12);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospede);

//Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes na reserva: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária da reserva: {reserva.CalcularValorDiaria()}");
