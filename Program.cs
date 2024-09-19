
//Declaração da Tupla
// using System.Runtime.CompilerServices;

// (int, string, string, decimal) tupla = (1, "Leonardo", "Fulano", 1.78M);
// ValueTuple<int, string, string, decimal> outroExemploTupla = tupla;
// var outroExemploTupla2 = Tuple.Create(1, "Leonardo", "Fulano", 1.78M);

// Console.WriteLine($"Id: {tupla.Item1} , Nome: {tupla.Item2}, Sobrenome: {tupla.Item3}, Altura: {tupla.Item4}");

using Tupla.Models;

LeituraArquivo arquivo = new LeituraArquivo();

var (Sucesso, Linhas, QuantidadeLinhas) = arquivo.LerArquivo("Arquivo/joao.txt");

if (Sucesso)
{
    Console.WriteLine("Quantidade Linhas do Arquivo: " + QuantidadeLinhas);
    Console.WriteLine("---------------------------------------------------");
    foreach(string linha in Linhas)
    {
        Console.WriteLine(linha);
    }  
} else 
    {
        Console.WriteLine("Não foi possível ler o arquivo.");
    }