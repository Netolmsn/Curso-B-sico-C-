//Desafio 01

int notaMedia = 6;

if (notaMedia >= 5)
{
    Console.WriteLine("Aprovado");
}
else if (notaMedia < 5)
{
    Console.WriteLine("Reprovado\n");
}

//Desafio 02

string nomeAluno = "Lucas";

Console.WriteLine($"Olá, {nomeAluno}");

//Desafio 03

Console.Write("Digite um numero: ");

string numeroEscolhido = Console.ReadLine()!;
int numeroEscolhidoNumerico = int.Parse(numeroEscolhido);

if (numeroEscolhidoNumerico == 0)
{
    Console.WriteLine("O numero escolhido foi zero");
}
else if (numeroEscolhidoNumerico > 0)
{
    Console.WriteLine("O numero escolhido foi positivo");
}
else 
{
    Console.WriteLine("O numero escolhido foi negativo");
}

//Desafio 04

Console.WriteLine("Digite a posiçao desejada");
int posicao = int.Parse(Console.ReadLine()!);

Console.WriteLine(linguagens[posicao]);



