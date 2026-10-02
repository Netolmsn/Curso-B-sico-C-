// void OperacoesBasicas()
// {
// float numeroUm = 3.04f;
// float numeroDois = 2.08f;


//     float soma = numeroUm + numeroDois;
//     float subtracao = numeroUm - numeroDois;
//     float multiplicacao = numeroUm * numeroDois;
//     float divisao = numeroUm / numeroDois;

//     Console.WriteLine("Soma: {0}", soma);
//     Console.WriteLine("Subtração: {0}", subtracao);
//     Console.WriteLine("Multiplicação: {0}", multiplicacao);
//     Console.WriteLine("Divisão: {0}", divisao);
// }
// OperacoesBasicas();

List<string> novasBandas = new List<string>{"Super Combo", "The Beatles"};

void RegistrarBandas()
{
    Console.WriteLine("Digite o nome da banda que deseja registrar: ");
    string nomeBandas = Console.ReadLine()!;
    novasBandas.Add(nomeBandas);
    Console.WriteLine($"A banda {nomeBandas} foi registrada com sucesso!");
}

void MostrarNovasBandas()
{
    Console.WriteLine("Lista de novas bandas: ");
    for (int i = 0; i < novasBandas.Count; i++)
    {
        Console.WriteLine($"Banda: {novasBandas[i]}");
    }
}
RegistrarBandas();
MostrarNovasBandas();