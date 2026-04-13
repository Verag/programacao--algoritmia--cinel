using System;
using System.Linq; // biblioteca com métodos avançados para trabalhar com listas e arrays

class Program
{
    static void Main()
    {
        int opcao;

        do
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1 - Calcular Fatorial");
            Console.WriteLine("2 - Sequência de Fibonacci");
            Console.WriteLine("3 - Verificar Palíndromo");
            Console.WriteLine("0 - Sair");

            opcao = LerInteiro("Escolha uma opção: ", 0);

            switch (opcao)
            {
                case 1:
                    ExecutarFatorial();
                    break;

                case 2:
                    ExecutarFibonacci();
                    break;

                case 3:
                    ExecutarPalindromo();
                    break;

                case 0:
                    Console.WriteLine("Programa encerrado.");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

        } while (opcao != 0);
    }

    // ================= FUNÇÕES DE LEITURA =================
    
    // ler número inteiro, validando o valor inserido
    static int LerInteiro(string mensagem, int min)
    {
        int valor;

        Console.Write(mensagem);

        while (!int.TryParse(Console.ReadLine(), out valor) || valor < min)
        {
            Console.Write($"O valor inserido é inválido. Digite um número inteiro >= {min}: ");
        }

        return valor;
    }

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

    // ================= FATORIAL =================
    static void ExecutarFatorial()
    {
        int numero = LerInteiro("Digite um número inteiro positivo: ", 0);

        long resultado = Fatorial(numero);

        Console.WriteLine($"Fatorial de {numero} é {resultado}");
    }

    static long Fatorial(int n) // declaração da função
    {
        if (n == 0 || n == 1) // casos especiais
            return 1;

        return n * Fatorial(n - 1);
    }

    // ================= FIBONACCI =================
    static void ExecutarFibonacci()
    {
        int n = LerInteiro("Digite a quantidade de termos da sequência de Fibonacci: ", 1);

        Console.WriteLine("\nSequência de Fibonacci:\n");

        long a = 0, b = 1;

        for (int i = 1; i <= n; i++)
        {
            if (i == 1)
            {
                Console.Write($"[{i}:{a}] ");
            }
            else if (i == 2)
            {
                Console.Write($"[{i}:{b}] ");
            }
            else
            {
                long c = a + b;
                Console.Write($"[{i}:{c}] ");

                a = b;
                b = c;
            }
        }

        Console.WriteLine();
    }

    // ================= PALÍNDROMO =================
    static void ExecutarPalindromo()
    {
        string input = LerTexto("Digite uma palavra ou frase: ");

        if (EhPalindromo(input))
        {
            Console.WriteLine("É um palíndromo!");
        }
        else
        {
            Console.WriteLine("Não é um palíndromo.");
        }
    }

    static bool EhPalindromo(string texto)
    {
        string limpo = new string(
            texto.Where(char.IsLetterOrDigit) // where vem da biblioteca linq (está a remover tudo o que não seja letras ou números)
                 .Select(char.ToLower) // converte tudo para minusculas
                 .ToArray() // passa para array
        );

        string reverso = new string(limpo.Reverse().ToArray());

        return limpo == reverso;
    }
}