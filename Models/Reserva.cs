using System;
using System.Collections.Generic;
namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }
        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            try {
                Hospedes = hospedes;

                if (Suite.Capacidade < hospedes.Count) {
                    throw new Exception("O número de hóspedes é maior do que a capacidade da Suite!");
                }
            } catch (NullReferenceException error) {
                Console.WriteLine(error.Message);
            } catch (Exception error) {
                Console.WriteLine(error.Message);
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
            decimal valor = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10) {
                valor -= valor * 10 / 100;
            }

            return valor;
        }
    }
}
