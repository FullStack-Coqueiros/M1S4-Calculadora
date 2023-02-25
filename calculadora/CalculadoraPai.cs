using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calculadora
{
    /// <summary>
    /// Classe não anemica
    /// Classe principal para herança
    /// </summary>
    public class CalculadoraPai
    {
        private protected int ValorA { get; }
        private protected int ValorB { get; }

        public CalculadoraPai(int numeroUm, int numeroDois)
        {
            ValorA = numeroUm;
            ValorB = numeroDois;
        }
    }
}