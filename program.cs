// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";

void ExibirMensagemDeBoasVindas()
{
    Console.WriteLine(@"
    
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
    
    ");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu() //funcao que exibe as opcoes do menu
{
    Console.WriteLine("\nDigite 1 para adicionar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite 0 para sair");

    Console.Write("\nDigite a opcao escolhida:");
    string opcaoEscolhida = Console.ReadLine()!; //permite ao usuario digitar a opcao desejada
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida); //converte a opcao escolhida em numero inteiro
    
    switch (opcaoEscolhidaNumerica) //estrutura condicional que verifica a opcao escolhida pelo usuario
    {
        case 1:
            Console.WriteLine("Opcao escolhida numero " + opcaoEscolhida);
            break;
        case 2:
            Console.WriteLine("Opcao escolhida numero " + opcaoEscolhida);
            break;
        case 3:
            Console.WriteLine("Opcao escolhida numero " + opcaoEscolhida);
            break;
        case 4:
            Console.WriteLine("Opcao escolhida numero " + opcaoEscolhida);
            break;
        case 0:
            Console.WriteLine("Bye Bye Guys ");
            break;
        default: //usado para tratar opcoes invalidas
            Console.WriteLine("Opcao invalida");
            break;
    }

}

ExibirMensagemDeBoasVindas();
ExibirOpcoesDoMenu();
