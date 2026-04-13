using System;

namespace ExerciciosAula02;

{

  /// <summary>

  /// 🔄 EXERCÍCIOS DE ESTRUTURAS DE ITERAÇÃO

  /// =======================================

  ///

  /// Exercício 1: Tabuada com for

  /// Exercício 2: Soma de números com while

  /// Exercício 3: Validação de senha com do-while

  /// Exercício 4: foreach com transformação

  /// </summary>

  public class AlunoIteracao

  {

    public void Executar()

    {

      Console.WriteLine("\n\n🔄 2. EXERCÍCIOS DE ESTRUTURAS DE ITERAÇÃO");

      Console.WriteLine("=========================================\n");

 

      // ===================================================

      // EXERCÍCIO 1: Tabuada com for

      // ===================================================

      // 👉 O QUE FAZER:

      // 1. Solicitar um número ao usuário

      // 2. Usar um loop for de 1 a 10

      // 3. Exibir a tabuada do número

      //

      // 💡 Estrutura: for (int i = 1; i <= 10; i++)

 

    //   Console.WriteLine("📝 Exercício 1: Tabuada");

    //   Console.Write("Digite um número para a tabuada: ");


        public int LerNumeroValido() //método para ler e validar um número
        {
            int numero;

            while (true)
            {
                Console.Write("Digite um número inteiro para ver a tabuada: ");

                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    return numero;   // Número válido → retorna
                }
                else
                {
                    Console.WriteLine("❌ Erro: Por favor, digite apenas um número inteiro válido.\n");
                }
            }
        }

        Console.WriteLine("=== TABUADA ===\n");

        // Chama o método da classe para ler o número com validação
        int numero = exercicio.LerNumeroValido();

        Console.WriteLine($"\nTabuada do {numero}:\n");
        Console.WriteLine("=====================");

        // Loop for para mostrar a tabuada
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero,3} × {i,2} = {numero * i,4}");
        }

        Console.WriteLine("\n=====================");
        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();

 



      //Saida

      /**� Exercício 1: Tabuada

    Digite um número para a tabuada: Número: 8

    Tabuada do 8:

    8 x 1 = 8

    8 x 2 = 16

    8 x 3 = 24

    8 x 4 = 32

    8 x 5 = 40

    8 x 6 = 48

    8 x 7 = 56

    8 x 8 = 64

    8 x 9 = 72

    8 x 10 = 80*/

 

    //   Console.WriteLine();

 

      // ===================================================

      // EXERCÍCIO 2: Soma de números com while

      // ===================================================

      // 👉 O QUE FAZER:

      // 1. Criar variável soma = 0

      // 2. Enquanto o número digitado for diferente de 0:

      //    - Somar o número à soma

      //    - Solicitar próximo número

      // 3. Exibir soma final

      //

      // 💡 while (condição) { // código }

 

    //   Console.WriteLine("\n📝 Exercício 2: Soma de números (até digitar 0)");

    //   Console.WriteLine("Digite números para somar (0 para parar):");

 

      // ESCREVA SEU CÓDIGO AQUI

 

      //SAIDA

      /*    � Exercício 2: Soma de números (até digitar 0)

    Digite números para somar (0 para parar):

    Número digitado: 5

    Soma atual: 5

    Número digitado: 3

    Soma atual: 8

    Número digitado: 3

    Soma atual: 11

    Número digitado: 3

    Soma atual: 14

    Número digitado: 3

    Soma atual: 17

    Número digitado: 3

    Soma atual: 20

    Soma final: 20

    */

    //   Console.WriteLine();

 

      // ===================================================

      // EXERCÍCIO 3: Validação de senha com do-while

      // ===================================================

      // 👉 O QUE FAZER:

      // 1. Definir senha correta (ex: "C#2024")

      // 2. Usar do-while para pedir senha

      // 3. Continuar enquanto a senha estiver errada

      // 4. Exibir mensagem de acesso quando correta

      //

      // 💡 do { // código } while (condição);

 

      Console.WriteLine("\n📝 Exercício 3: Validação de Senha");

 

      // ESCREVA SEU CÓDIGO AQUI

      //Saida

      /*  � Exercício 3: Validação de Senha

      Digite a senha: ******

      ✅ Senha correta! Acesso permitido.

        Console.WriteLine();

     */

 

 

 

 

      // ===================================================

      // EXERCÍCIO 4: foreach com transformação

      // ===================================================

      // 👉 O QUE FAZER:

      // 1. Criar um array de strings com nomes

      // 2. Usar foreach para percorrer cada nome

      // 3. Exibir cada nome em maiúsculas (ToUpper())

      //

      // 💡 foreach (var item in colecao) { // código }

 

      Console.WriteLine("\n📝 Exercício 4: Nomes em Maiúsculas");

 

      // ESCREVA SEU CÓDIGO AQUI

      //SAIDA

      /* � Exercício 4: Nomes em Maiúsculas

  Lista de nomes em maiúsculas:

    - ANA

    - BRUNO

    - CARLA

    - DANIEL

    - ELENA

    */

   

      Console.WriteLine();

 

      // ===================================================

      // RESUMO FINAL

      // ===================================================

      Console.WriteLine("\n📌 Resumo das estruturas de iteração:");

      Console.WriteLine("for       → quando sabemos o número de repetições");

      Console.WriteLine("while     → quando repetição depende de condição");

      Console.WriteLine("do-while  → quando precisa executar pelo menos uma vez");

      Console.WriteLine("foreach   → para percorrer coleções");

    }

  }

}

 

