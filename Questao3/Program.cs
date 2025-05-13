/*
3) Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, faça um programa, 
na linguagem que desejar, que calcule e retorne: 
• O menor valor de faturamento ocorrido em um dia do mês; 
• O maior valor de faturamento ocorrido em um dia do mês; 
• Número de dias no mês em que o valor de faturamento diário foi superior à média mensal. 

IMPORTANTE: 
a) Usar o json ou xml disponível como fonte dos dados do faturamento mensal; 
b) Podem existir dias sem faturamento, como nos finais de semana e feriados. Estes dias devem ser 
ignorados no cálculo da média; 
*/

using System.Text.Json;
using System.Text.Json.Serialization;

var json = File.ReadAllText("dados.json");
var faturamentos = JsonSerializer.Deserialize<List<RegistroDiario>>(json);
if (faturamentos == null)
{
    Console.WriteLine("Nenhum registro encontrado.");
    return;
}

var menorFaturamento = faturamentos.Where(f => f.Valor > 0).Min(f => f.Valor);
var maiorFaturamento = faturamentos.Max(f => f.Valor);
var mediaMensal = faturamentos.Where(f => f.Valor > 0).Average(f => f.Valor);
var diasAcimaDaMedia = faturamentos.Count(f => f.Valor > mediaMensal);
Console.WriteLine($"Menor faturamento: {menorFaturamento}");
Console.WriteLine($"Maior faturamento: {maiorFaturamento}");
Console.WriteLine($"Média mensal: {mediaMensal}");
Console.WriteLine($"Dias acima da média: {diasAcimaDaMedia}");

public class RegistroDiario
{
    [JsonPropertyName("dia")]
    public int Dia { get; set; }
    [JsonPropertyName("valor")]
    public double Valor { get; set; }
}