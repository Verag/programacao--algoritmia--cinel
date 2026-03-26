using System;

namespace Fundamentos01;

public class VariaveisETiposDeDados
{

   

    public void Executar()
    {
        Console.WriteLine("📦 VARIÁVEIS E TIPOS DE DADOS");
        Console.WriteLine("Variáveis são espaços na memória para guardar informações.");
        Console.WriteLine();

        int idade = 25;
        double altura = 1.75;
        float media = 19.50f;
        char letra = 'A';// pouco uso 
        string nome = "Tony"; // é imutável
        string nomeComposto = nome + "filho"; // concatenação: juntar 2 referencias de memória em uma só
        bool estudante = true;

        Console.WriteLine($"Idade: {idade}(numeros inteiros)");
        Console.WriteLine($"Altura: {altura}(numeros decimais)");
        Console.WriteLine($"Média: {media}(numeros decimais)");
        Console.WriteLine($"Letra: {letra}(caracteres)");
        Console.WriteLine($"Nome: {nome}(textos)");
        Console.WriteLine($"Nome Composto: {nomeComposto}(textos)");
        Console.WriteLine($"Estudante: {estudante}(valores lógicos)");
    }
} //fim class