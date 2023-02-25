using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    public class Multiplicar : CalculadoraPai
    {
        public Multiplicar(int numeroUm, int numeroDois) : base(numeroUm, numeroDois)
        {
        }

        public void Calcular()
        {
            Console.WriteLine("A multiplcação entre  {0} * {1} é: {2}", this.ValorA, this.ValorB, this.ValorA * this.ValorB);
        }
    }
}
