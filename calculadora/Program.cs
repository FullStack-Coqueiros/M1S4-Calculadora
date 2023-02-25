// See https://aka.ms/new-console-template for more information

using calculadora;

bool manterCalculadoraAberta = true;
//Se manterCalculadoraAberta for igual a "true" ela não fechar o sistema
//se manterCalculadoraAberta for igual a "false" ela vai fechar o sistema

while (manterCalculadoraAberta)
{
    Menu.DisplayInicial();
    var numeroUm = Menu.DigitarPrimeiroValorEmTela(); //Valor número um 
    var numeroDois = Menu.DigitarSegundoValorEmTela(); //Valor número dois
    var opcao = Menu.SelecionarOpcaoParaCalcular(); //Opção selecionada da tela 

    //Condicao utilizando switch da Opção Selecionada
    switch (opcao)
    {
        case 1: //Soma
            Soma soma = new Soma(numeroUm, numeroDois);
            soma.Calcular();
            manterCalculadoraAberta = Menu.ReiniciarDisplayConsole();
            break;
        case 2: //Subtração
            Subtrair subtrair = new Subtrair(numeroUm, numeroDois);
            subtrair.Calcular();
            manterCalculadoraAberta = Menu.ReiniciarDisplayConsole();
            break;
        case 3: //Multiplicação
            Multiplicar multiplicar = new Multiplicar(numeroUm, numeroDois);
            multiplicar.Calcular();
            manterCalculadoraAberta = Menu.ReiniciarDisplayConsole();
            break;
        case 4: // divisão
            Dividir dividir = new Dividir(numeroUm, numeroDois);
            dividir.Calcular();
            manterCalculadoraAberta = Menu.ReiniciarDisplayConsole();
            break;
        case 5:
            Console.WriteLine("Tchau !!!");
            manterCalculadoraAberta = false;
            break;
        default:
            //Erro no sistema, espero por 5 milissegundos
            Console.WriteLine("Dados com erros, aguarde 5 milissegundos para a tela carregar display inicial");
            Thread.Sleep(5000);
            Menu.DisplayInicial();
            break;
    }
}

