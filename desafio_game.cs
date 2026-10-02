Random aleatorio = new Random(); //gera um numero aleatorio entre 1 e 100
int numeroSecreto = aleatorio.Next(1, 101); //define o numero secreto

// int numeroSecreto = 92; //numero secreto definido

do
{
Console.Write("Digite um numero de 1 a 100: "); //solicita ao usuario digitar um numero de 1 a 100 como palpite
int numeroEscolhido = int.Parse(Console.ReadLine()!); //permite ao usuario digitar o palpite convertendo o valor em um INT

    if (numeroEscolhido == numeroSecreto) //verifica se o palpite é o numero secreto
    {
        Console.WriteLine("Parabens, voce acertou o numero secreto");  
    break; //incrementa o numero secreto em 1 a cada tentativa do usuario
    }
    else if (numeroEscolhido > numeroSecreto) //verifica se o paplite é maior que numero secreto
    {
        Console.WriteLine("O numero escolhido é maior que o numero secreto");
    }
    else //verifica se o palpite é menor que o numero secreto
    {
        Console.WriteLine("O numero escolhido é menor que o numero secreto");
    }
}
while(true); //loop infinito que permite ao usuario digitar o palpite ate acertar o numero secreto