// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
// List<string> bandasRegistradas = new List<string>{ "Super Combo", "Pink Floyd", "The Beatles" }; //cria uma lista de strings para armazenar as bandas registradas

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>(); //criacao de um dicionario vazio
bandasRegistradas.Add("Linkin Park", new List<int>{10,8,4,0});
bandasRegistradas.Add("Super Combo", new List<int>());

void ExibirLogo()
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
    ExibirLogo(); //chama a funcao que exibe o logo do programa
    Console.WriteLine("\nDigite 1 para adicionar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite 0 para sair");

    Console.Write("\nDigite a opcao escolhida: ");
    string opcaoEscolhida = Console.ReadLine()!; //permite ao usuario digitar a opcao desejada
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida); //converte a opcao escolhida em numero inteiro
    
    switch (opcaoEscolhidaNumerica) //estrutura condicional que verifica a opcao escolhida pelo usuario
    {
        case 1: RegistrarBanda();
            break;
        case 2: MostrarBandasRegistradas();
            break;
        case 3: AvaliarUmaBanda();
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

void RegistrarBanda() //funcao que registra uma banda
{
    Console.Clear(); //limpa a tela
    // Console.WriteLine("******************");
    // Console.WriteLine("Registro de banda");
    // Console.WriteLine("******************\n");
    ExibirTituloDaOpcao("Registro de banda");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    //bandasRegistradas.Add(nomeDaBanda); //adiciona a banda na lista de bandas registradas
    bandasRegistradas.Add(nomeDaBanda, new List<int>()); //adiciona a banda na lista de bandas registradas e cria uma lista de notas vazia
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso");
    Thread.Sleep(1500); //pausa a execucao do programa por 2 segundos
    Console.Clear();
    ExibirOpcoesDoMenu(); //chama a funcao que exibe as opcoes do menu
}

void MostrarBandasRegistradas() //funcao que mostra as bandas registradas
{
    Console.Clear(); //limpa a tela
    // Console.WriteLine("*************************************");
    // Console.WriteLine("Exibindo todas as bandas registradas");
    // Console.WriteLine("*************************************\n");
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas");

    // for (int i = 0; i <bandasRegistradas.Count; i++) //estrutura de repeticao que percorre a lista de bandas registradas
    // {
    //     Console.WriteLine($"Banda: {bandasRegistradas[i]}"); //exibe a lista das bandas registradas
    // }
    
    //foreach (string banda in bandasRegistradas) //estrutura de repeticao que percorre a lista de bandas registradas
    foreach (string banda in bandasRegistradas.Keys) //estrutura de repeticao que percorre a lista de bandas registradas no dicionario

    {
        Console.WriteLine($"Banda: {banda}");
    }
    
    Console.WriteLine("\nDigite qualquer tecla para voltar ao menu");
    Console.ReadKey(); //espera o usuario digitar qualquer tecla para voltar ao menu
    Console.Clear();
    ExibirOpcoesDoMenu(); //chama a funcao que exibe as opcao do menu
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string astericos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(astericos);
    Console.WriteLine(titulo);
    Console.WriteLine(astericos + "\n");
}

void AvaliarUmaBanda()
    //digite qual banda deseja avaliar
    //verificar se a banda existe, se existir >> atribuir uma nota
    //senao exibir uma mensagem e retornar ao menu 
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");
    Console.Write("Informe qual banda deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi adicionada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(4500);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.Write("Digite uma tecla para voltar ao menu principal. ");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

ExibirOpcoesDoMenu();
