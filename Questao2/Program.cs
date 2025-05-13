/*
2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma 
dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na 
linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne 
uma mensagem avisando se o número informado pertence ou não a sequência. 

IMPORTANTE: Esse número pode ser informado através de qualquer entrada de sua preferência ou pode 
ser previamente definido no código; 
*/

Console.Write("Digite um número: ");
int numero = int.Parse(Console.ReadLine());

bool pertence = VerificaFibonacci(numero);
if (pertence)
{
    Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
}
else
{
    Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci.");
}

bool VerificaFibonacci(int numeroFinal)
{
    if (numeroFinal == 0 || numeroFinal == 1) return true;

    int numeroAnterior = 0;
    int numeroAtual = 1;

    while (numeroAtual < numeroFinal)
    {
        int temp = numeroAtual;
        numeroAtual = numeroAnterior + numeroAtual;
        numeroAnterior = temp;
    }

    return numeroAtual == numeroFinal;
}