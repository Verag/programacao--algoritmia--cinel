// using System;
 
// namespace Fundamentos01
// {
//   /// <summary>
//   /// 🧮 SUMÁRIO DOS EXERCÍCIOS DE OPERADORES ARITMÉTICOS
//   /// =================================================
//   ///
//   /// Exercício 1: Soma e subtração
//   /// - Aprender a usar os operadores + (soma) e - (subtração)
//   /// - Guardar o resultado em variáveis
//   /// - Exibir os resultados no console
//   ///
//   /// Exercício 2: Cálculo de área do retângulo
//   /// - Aplicar a multiplicação (*) em um problema real
//   /// - Calcular área = largura × altura
//   /// - Trabalhar com números decimais (double)
//   ///
//   /// Exercício 3: Operador módulo (resto da divisão)
//   /// - Entender o operador % que retorna o resto da divisão
//   /// - Exemplo prático: 20 ÷ 6 = 3, resto 2
//   /// - Útil para verificar se um número é par ou ímpar
//   ///
//   /// Demonstração adicional:
//   /// - Multiplicação e divisão com conversão de tipos (cast)
//   /// - Operador de incremento (++) que aumenta o valor em 1
//   /// - Formatação de números decimais com :F2 (2 casas decimais)
//   /// </summary>
//   ///
 
 
 
//   public class AlunoOperadoresAritmeticos
//   {
//     public void Executar()
//     {
//       // OBS: Use a Interpolação dentro do Console.WriteLine(?) para testar e passar os valores das Variaveis {...}
//       Console.WriteLine("\n🧮 3. EXERCÍCIOS DE OPERADORES ARITMÉTICOS");
//       Console.WriteLine("=========================================\n");
 
//       // ===================================================
//       // EXERCÍCIO 1: Soma e subtração
//       // ===================================================
//       // 👉 O QUE FAZER:
//       // 1. Criar duas variáveis numéricas
//       // 1A. Crie outras duas variáveis chamada soma e subtração que receberão as 2 varias anteriores Ex: int soma = numero1 + numero2;
//       // 2. Fazer uma soma usando +
//       // 3. Fazer uma subtração usando -
//       // 4. Mostrar os resultados no console
//       //
//       // 💡 Regra:
//       // + → soma valores
//       // - → subtrai valores
 
//       Console.WriteLine("📝 Exercício 1: Soma e subtração");
//         int num1 = 8;
//         int num2 = 5;
//         int soma = num1 + num2;
//         int subtracao = num1 - num2;

//         Console.WriteLine($"{num1} + {num2} = {soma}");
//         Console.WriteLine($"{num1} - {num2} = {subtracao}");


 
//       /**SAIDA na Tela  ou Resultado esperado
//      � Exercício 1: Soma e subtração
//      8 + 5 = 13
//      8 - 5 = 3
//      */
 
//       // ===================================================
//       // EXERCÍCIO 2: Cálculo de área
//       // ===================================================
//       // 👉 O QUE FAZER:
//       // 1. Criar duas variáveis double (largura e altura) Ex: double largura = 5.0;
//       // 2. Multiplicar os valores
//       // 3. Mostrar o resultado
//       //
//       // 💡 Regra:
//       // Área do retângulo = largura × altura
//       // Usamos double para valores com casas decimais
 
//       Console.WriteLine("📝 Exercício 2: Cálculo de área do retângulo");

//       double largura = 5.0;
//       double altura = 3.0;
//       double area = largura * altura;

//       Console.WriteLine($"Área do retângulo: {largura} × {altura} = {area}");
 
//       /**SAIDA na Tela  ou Resultado esperado
//       � Exercício 2: Cálculo de área do retângulo
//       Área do retângulo: 5 × 3 = 15
//       */
//       Console.WriteLine("📝 Exercício 2B: Repita o exercicio 2");
//       //Mas agora ao invés de ter variáveis com dados fixo, pesquise qual é o metodo de ENTRADA do C# e abasteça(Atribua o valor com este metodo)
//       //Com isto poderá calcular retângulos diferentes.
//       //  passe a usar Variáveis com valores Dinamicos ao ínves de Staticos, usando este metodo de ENTRADA.

       
//         Console.Write("Digite a largura do retângulo: ");
//         string larguraInput = Console.ReadLine();
//         double largura1 = Convert.ToDouble(larguraInput); // converte string para double

//         Console.Write("Digite a altura do retângulo: ");
//         string alturaInput = Console.ReadLine();
//         double altura1 = Convert.ToDouble(alturaInput); // converte string para double

//         // Calcula área
//         double area = largura1 * altura1;

//         // Mostra resultado
//         Console.WriteLine($"A área do retângulo é: {area}");
 
 
 
//       // ===================================================
//       // EXERCÍCIO 3: Operador módulo (%)
//       // ===================================================
//       // 👉 O QUE FAZER:
//       // 1. Criar 3 variaveis números inteiros, sendo que uma delas recebe o resultado do RESTO Ex:  int resto = dividendo % divisor;
//       // 2. Usar o operador % para obter o resto
//       // 3. Mostrar o resultado
//       //
//       // 💡 Regra:
//       // % retorna o RESTO da divisão
//       // passe a usar Variáveis com valores Dinamicos ao ínves de Staticos.
 
//       Console.WriteLine("📝 Exercício 3: Operador módulo (%)");
//         int dividendo = 20;
//         int divisor = 6;
//         int resto = dividendo % divisor;
//         Console.WriteLine($"Resto da divisão de {dividendo} por {divisor} = {resto}");

 
//       /*SAIDA na Tela  ou Resultado esperado supondo que usou os valores 6 e 20
//      � Exercício 3: Operador módulo (resto da divisão)
//      Resto da divisão de 20 por 6 = 2
//       **/
 
 
 
 
//       // ===================================================
//       // EXERCÍCIO 4: Multiplicação e divisão
//       // ===================================================
//       // 👉 O QUE FAZER:
//       // 1. Criar Vaariáveis int e double . Ex int multiplicacao, double divisao, num1 e num2
//       // PESQUISE o que é CASTING e faça o casting para obter um resultado decimal na divisão. Ex: double divisao = (double)num1 / num2;  ou  double divisao = Convert.ToDouble(num1) / num2;
 
//       // 2. Fazer uma multiplicação (*)
//       // 3. Fazer uma divisão (/)
//       // 4. Mostrar os resultados
//       //
//       // 💡 Regra:
//       // * → multiplicação
//       // / → divisão
//       //Passe a usar Variáveis com valores Dinamicos ao ínves de Staticos, usando este metodo de ENTRADA.
//       Console.WriteLine("📝 Exercício 4: Multiplicação e divisão");

//               Console.WriteLine("=== Exercício 4: Multiplicação e Divisão ===\n");

//         while (true) // Loop para permitir múltiplos cálculos
//         {
//             // Solicita o primeiro número ao usuário
//             Console.Write("Digite o primeiro número (num1) ou 'sair' para encerrar: ");
//             string input1 = Console.ReadLine();
//             if (input1.ToLower() == "sair") break; // encerra o programa se o usuário digitar 'sair'

//             // Converte o input do usuário para inteiro
//             int num1;
//             if (!int.TryParse(input1, out num1)) // valida se é um número válido
//             {
//                 Console.WriteLine("Valor inválido! Por favor, digite um número inteiro.\n");
//                 continue;
//             }

//             // Solicita o segundo número ao usuário
//             Console.Write("Digite o segundo número (num2): ");
//             string input2 = Console.ReadLine();
//             int num2;
//             if (!int.TryParse(input2, out num2))
//             {
//                 Console.WriteLine("Valor inválido! Por favor, digite um número inteiro.\n");
//                 continue;
//             }

//             // Multiplicação (int * int)
//             int multiplicacao = num1 * num2;

//             // Divisão (casting para double para resultado decimal)
//             double divisao;
//             if (num2 != 0) // verifica divisão por zero
//             {
//                 divisao = (double)num1 / num2;
//             }
//             else
//             {
//                 Console.WriteLine("Divisão por zero não é permitida!\n");
//                 continue; // pula para o próximo loop
//             }

//             // Mostra os resultados usando interpolação de strings
//             Console.WriteLine($"\nResultado da multiplicação: {multiplicacao}");
//             Console.WriteLine($"Resultado da divisão: {divisao}\n");
//         }

//         Console.WriteLine("Programa encerrado. Obrigado!");



 
 
//       /**SAIDA na Tela  ou Resultado esperado
//       � Exercício 4: Multiplicação e divisão
//       Multiplicação: 8 × 5 = 40
//       Divisão: 8 ÷ 5 = 1.60*/
 
 
 
 
 
 
 
 
 
//       // ===================================================
//       // EXERCÍCIO 5: Incremento
//       // ===================================================
//       // 👉 O QUE FAZER:
//       // 1. Criar uma variável que receba o numero 1
//       // 2. Use o operador ++
//       // 3. Mostrar o valor antes e depois
//       //
//       // 💡 Regra:
//       // ++ aumenta o valor em 1
//       //Passe a usar Variáveis com valores Dinamicos ao ínves de Staticos, usando este metodo de ENTRADA.
 
//       Console.WriteLine("📝 Exercício 5: Incremento");
 
 
//     /**SAIDA na Tela  ou Resultado esperado
//      � Demonstração adicional de operadores
//      8 × 5 = 40
//      8 ÷ 5 = 1.60
//      Incremento de 8 virou : 9
//     */
 
//       // ===================================================
//       // RESUMO FINAL
//       // ===================================================
//       // 👉 Objetivo:
//       // Relembrar os principais operadores
 
//       Console.WriteLine("📌 Resumo dos operadores:");
//       Console.WriteLine("+  → soma");
//       Console.WriteLine("-  → subtração");
//       Console.WriteLine("*  → multiplicação");
//       Console.WriteLine("/  → divisão");
//       Console.WriteLine("%  → resto da divisão");
//       Console.WriteLine("++ → incremento");
 
//       Console.WriteLine();
//     }
 
 
//   }
// }
 
 