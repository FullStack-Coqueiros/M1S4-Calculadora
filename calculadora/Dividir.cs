using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    public class Dividir : CalculadoraPai
    {
        public Dividir(int numeroUm, int numeroDois) : base(numeroUm, numeroDois)
        {
        }

        public void Calcular()
        {
            if (this.ValorB == 0)
            {
                Console.WriteLine("O Segundo número não pode ser igual a zero, pois vai dar erro no calculo");
            }
            else
            {
                Console.WriteLine("A divisão para {0} / {1} é : {2}", this.ValorA, this.ValorB, this.ValorA / this.ValorB);
            }
        }
    }
}
