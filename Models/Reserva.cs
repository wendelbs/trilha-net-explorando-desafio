using System.Transactions;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.IO;
using System.Security.AccessControl;
using System;
using System.Linq;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Reserva(Suite suite) 
        {
            this.Suite = suite;
   
        }
            public Suite Suite { get; set; }
            public int DiasReservados { get; set; }
            public Reserva() { }
            public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }
        
         
        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
         
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*
                    if (Suite.Capacidade >= Hospedes.Count)
                    {
                        Hospedes = hospedes;
                    }
                    else
                    {
                       throw new Exception("o número de hóspedes excedeu a capacidade do apartamento");
                        // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                        // *IMPLEMENTE AQUI* */
                    
                        
                    }

        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*
           return Hospedes.Count;
             
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*
             decimal valorDiariaTotal = DiasReservados * Suite.ValorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (DiasReservados >= 10 )
            {
                
              decimal valorSemDesconto = (DiasReservados * Suite.ValorDiaria);
              valorDiariaTotal = valorSemDesconto - (valorSemDesconto * (10/100));
           
            }

            return valorDiariaTotal;
        
    }
    }
}
    
