/*
4) Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado: 
•	SP – R$67.836,43 
•	RJ – R$36.678,66 
•	MG – R$29.229,88 
•	ES – R$27.165,48 
•	Outros – R$19.849,53 
Escreva um programa na linguagem que desejar onde calcule o percentual de representação que cada 
estado teve dentro do valor total mensal da distribuidora.  
*/

using System.Globalization;

var faturamentoPorEstado = new Dictionary<string, double>
{
    { "SP", 67836.43 },
    { "RJ", 36678.66 },
    { "MG", 29229.88 },
    { "ES", 27165.48 },
    { "Outros", 19849.53 }
};

// Soma total do faturamento
double total = 0;
foreach (var valor in faturamentoPorEstado.Values)
{
    total += valor;
}
Console.WriteLine($"Faturamento Total: R${total.ToString("N2", CultureInfo.InvariantCulture)}\n");

// Cálculo e exibição dos percentuais
foreach (var estado in faturamentoPorEstado)
{
    double percentual = (estado.Value / total) * 100;
    Console.WriteLine($"{estado.Key}: {percentual.ToString("F2", CultureInfo.InvariantCulture)}%");
}