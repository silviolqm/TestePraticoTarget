/*
5) Escreva um programa que inverta os caracteres de um string. 

IMPORTANTE: 
a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente 
definida no código; 
b) Evite usar funções prontas, como, por exemplo, reverse; 
*/

Console.Write("Digite uma string: ");
string stringEntrada = Console.ReadLine();

string stringReversa = string.Empty;

for (int i = stringEntrada.Length - 1; i >= 0; i--)
{
    stringReversa += stringEntrada[i];
}

Console.WriteLine($"O inverso da string é: {stringReversa}");