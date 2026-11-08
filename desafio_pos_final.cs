Dictionary<string, List<int>> aluno = new Dictionary<string, List<int>>();
aluno.Add("Jose", new List<int>());

void MenuDeOpcoes()
{
    Console.WriteLine("Opcao 1: Adicionar um aluno");
    Console.WriteLine("Opcao 2: Ver lista de alunos");
    Console.WriteLine("Opcao 3: Avaliar um aluno");
    Console.WriteLine("Opcao 3: Avaliar um aluno");

    Console.WriteLine("Digite a opcao escolhida: ");
    string opcaoEscolhida = Console.ReadLine();
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch(opcaoEscolhidaNumerica)
    {
        case 1: AdicionarAluno();
            break;
        case 2: ApresentarListaDeAlunos();
            break;
        case 3: AvaliarAluno();
            break;
        case 0: 
            Console.WriteLine("Encerra o sistema");
            break;
        default: 
            Console.WriteLine("Opcao Invalida");
            break;
    }
}

void AdicionarAluno()
{
    Console.Write("Digite o nome do aluno que deseja adicionar: ");
    string nomeDoAluno = Console.ReadLine()!;
    aluno.Add(nomeDoAluno, new List<int>());
    Console.WriteLine($"O aluno {nomeDoAluno} foi adicionado com sucesso");
    Console.ReadKey();
}

void ApresentarListaDeAlunos()
{
    
}

void AvaliarAluno()
{
    Console.Write("Digite o nome do Aluno que deseja avaliar: ");
    string nomeDoAluno = Console.ReadLine()!;
    if{
        aluno
        
    }
    else
    {
        
    }

}

AdicionarAluno();