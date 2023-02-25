using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    /// <summary>
    /// Classe estatica para criação do menu
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// Criar o diplay inicial
        /// </summary>
        public static void DisplayInicial()
        {
            Console.Clear(); //Método que vai limpar os dados em tela
            Console.WriteLine("\n"); //Quebra de linha com o \n e WriteLine
            Console.WriteLine("CALCULADORA NO CONSOLE:"); //Titulo do console
            Console.WriteLine("*******************************************************"); //Corte da linha
            Console.WriteLine("\n"); //Quebra de linha com o \n e WriteLine
        }

        /// <summary>
        /// Função que vai retornar o valor digitado da tela
        /// </summary>
        /// <returns>Inteiro</returns>
        public static int DigitarPrimeiroValorEmTela()
        {

            try //Bloco do código certo
            {
                Console.WriteLine("Entre com o primeiro valor :");
                var numero = Convert.ToInt32(Console.ReadLine()); // ReadLine é um método que vai retornar o valor digitado em tela do console 
                return numero; //Retorna o número digitado em tela
            }
            catch (Exception ex) //Bloco do codigo para o erro
            {
                Console.WriteLine("Erro na conversão, valor default será impresso 1");
            }

            return 1; //Retorna valor default igual a um 
        }

        /// <summary>
        /// Função que vai retornar o valor digitado da tela
        /// </summary>
        /// <returns>Inteiro</returns>
        public static int DigitarSegundoValorEmTela()
        {
            try //Bloco do código certo
            {
                Console.WriteLine("Entre com o segundo valor :");
                var numero = Convert.ToInt32(Console.ReadLine()); // ReadLine é um método que vai retornar o valor digitado em tela do console 
                return numero; //Retorna o número digitado em tela
            }
            catch (Exception ex) //Bloco do codigo para o erro
            {
                Console.WriteLine("Erro na conversão, o método vai ser executado novamente");
            }
            
            //Recursividade
            return DigitarSegundoValorEmTela();
        }

        /// <summary>
        /// Opção para selecionar o tipo de operador
        /// </summary>
        /// <returns></returns>
        public static int SelecionarOpcaoParaCalcular()
        {
            try
            {
                Console.WriteLine("Selecione a opção de calculo :");

                Console.WriteLine("1 - Soma.");
                Console.WriteLine("2 - Subitração.");
                Console.WriteLine("3 - Multiplicação.");
                Console.WriteLine("4 - Divisão.");
                Console.WriteLine("5 - Sair da calculadora.");
                Console.WriteLine("\n");

                Console.WriteLine("Opção :");
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Opção com erro, selecione a correta");
            }

            return SelecionarOpcaoParaCalcular();
        }

        /// <summary>
        /// Método que vai decidir se o sistema vai continuar na calculadora ou encerrar
        /// </summary>
        /// <returns>true or false</returns>
        public static bool ReiniciarDisplayConsole()
        {
            Console.WriteLine("\n");
            Console.WriteLine("*********************************************");
            Console.WriteLine("Deseja reiniciar a calculadora: ");
            Console.WriteLine("1 - Sim.");
            Console.WriteLine("2 - Não.");
            Console.WriteLine("\n");

            Console.WriteLine("Opção :");

            if (Convert.ToInt32(Console.ReadLine()) == 1)
            {
                Menu.DisplayInicial();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
