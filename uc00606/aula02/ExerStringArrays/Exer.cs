
using System;

 

namespace ExerciciosAula02

{

  /// <summary>

  /// 🔤 EXERCÍCIOS DE MANIPULAÇÃO DE STRINGS

  /// =======================================

  ///

  /// Exercício 1: Contar vogais
  /// Exercício 2: Inverter string
  /// Exercício 3: Verificar palíndromo
  /// Exercício 4: Divisão e contagem de palavras

  /// </summary>

  public class AlunoManipulacaoStrings

  {
        // FUNÇÕES
      	// ler texto, validando o valor inserido
    static string LerTexto(string mensagem)
    {
        string texto;
        Console.Write(mensagem);
        while (string.IsNullOrWhiteSpace(texto = Console.ReadLine()))
        {
            Console.Write("Entrada inválida. Digite um texto válido: ");
        }
        return texto;
    }


    public void Executar()

    {



      Console.WriteLine("\n\n🔤 5. EXERCÍCIOS DE MANIPULAÇÃO DE STRINGS");
      Console.WriteLine("==========================================\n");

      // ===================================================

      // EXERCÍCIO 1: Contar vogais

      // ===================================================

      // 👉 O QUE FAZER:
      // 1. Solicitar uma frase ao usuário
      // 2. Percorrer cada caractere da frase
      // 3. Verificar se é vogal (a, e, i, o, u, A, E, I, O, U)
      // 4. Contar e exibir o número de vogais


      Console.WriteLine("📝 Exercício 1: Contagem de vogais");
      
      string frase = LerTexto("Escreva uma frase: ");
      string[] letras = frase.Split(' ');

      string vogais = "aeiouAEIOU"; // string contendo todas as vogais

      int contador = 0 ;// contador de vogais

      foreach (string letra in letras)
      {
        foreach (char c in letra)
        {
          if (vogais.Contains(c))
          {
            Console.WriteLine($"Vogal encontrada: {c}");
            contador ++ ; 
          }
        }
      }
      Console.WriteLine($"Número de vogais: {contador}");
      Console.WriteLine();

 

      // ===================================================

      // EXERCÍCIO 2: Inverter string

      // ===================================================

      // 👉 O QUE FAZER:
      // 1. Solicitar uma palavra ao usuário
      // 2. Percorrer a palavra de trás para frente
      // 3. Construir a string invertida
      // 4. Exibir o resultado

      //

      // 💡 for (int i = palavra.Length - 1; i >= 0; i--)

      /*Explicação: 👉 Aqui acontece a "mágica":

       original.Length → tamanho da string (em "CSharp" é 6)
       Length - 1 → começa no último índice (5)
       i-- → vai andando para trás (5 → 4 → 3 → ... → 0)
💡     Ou seja: percorre a string do fim para o início**/

 

      Console.WriteLine("\n Exercício 2: Inversão de string");

      string palavra = LerTexto("Insira uma palavra, sff: ");
      string invertida = ""; // string para armazenar a palavra invertida

      for (int i = palavra.Length - 1; i >= 0; i--)
      {
          invertida += palavra[i];
      }

      Console.WriteLine($"String original: '{palavra}'");
      Console.WriteLine($"String invertida: '{invertida}'");
      Console.WriteLine();

 

      // ===================================================

      // EXERCÍCIO 3: Verificar palíndromo

      // ===================================================

      // 👉 O QUE FAZER:
      // 1. Solicitar uma palavra ao usuário
      // 2. Verificar se é palíndromo (lê-se igual de trás para frente)
      // 3. Comparar caractere da esquerda com caractere da direita
      // 4. Percorrer apenas até a metade da palavra

      // 💡 palavra[i] != palavra[palavra.Length - 1 - i]

 

      Console.WriteLine("\n📝 Exercício 3: Verificação de palíndromo");

      string palPalindromo = LerTexto("Insira uma palavra, sff: ");

      string limpo = ""; // para guardar a variável limpa
      string reverso = ""; // para guardar a variável reversa

      foreach (char c in palPalindromo)
      {
          if (char.IsLetterOrDigit(c))
          {
              limpo += char.ToLower(c);
          }
      }

      for (int i = limpo.Length - 1; i >= 0; i--)
      {
          reverso += limpo[i];
      }

      if (limpo == reverso)
      {
          Console.WriteLine($"A palavra '{palPalindromo}' é um palíndromo.");
      }
      else
      {
          Console.WriteLine($"A palavra '{palPalindromo}' não é um palíndromo.");
      }
      Console.WriteLine();

 

      // ===================================================

      // EXERCÍCIO 4: Divisão e contagem de palavras

      // ===================================================

      // 👉 O QUE FAZER:
      // 1. Solicitar uma frase ao usuário
      // 2. Dividir a frase em palavras usando Split(' ')
      // 3. Exibir o número de palavras
      // 4. Exibir cada palavra individualmente

      // 💡 string[] palavras = frase.Split(' ');

 

      Console.WriteLine("\n📝 Exercício 4: Divisão de frase em palavras");

      string frase4 = LerTexto("Insira uma frase, sff: ");
      string [] palavras = frase4.Split(' '); // divide a frase em palavras usando o espaço como separador
      Console.WriteLine($"Frase: '{frase4}'");
      Console.WriteLine($"Número de palavras: {palavras.Length}");
      Console.WriteLine("Palavras individuais:");
      foreach (string palavraIndividual in palavras)
      {
          Console.WriteLine($"- '{palavraIndividual}'");
      }

      Console.WriteLine();

      // ===================================================

      // RESUMO FINAL

      // ===================================================
      Console.WriteLine("\n📌 Resumo sobre manipulação de strings:");
      Console.WriteLine("Contains() → verificar se contém caractere");
      Console.WriteLine("ToUpper()  → converter para maiúsculas");
      Console.WriteLine("Split()    → dividir string");
      Console.WriteLine("Length     → tamanho da string");

    }
  }
}

