using System;

namespace ExerciciosAula03
{
    public class AlunoFuncoesMetodos
    {
        public void Executar()
        {
            Console.WriteLine("\n🎯 EXERCÍCIOS DE FUNÇÕES E MÉTODOS\n");

            // =========================
            // EXERCÍCIO 1: FATORIAL
            // =========================
            Console.WriteLine("📝 Exercício 1: Fatorial");

            int numero = LerInteiro("Digite um número inteiro positivo: ", 0);
            long resultado = Fatorial(numero);
            Console.WriteLine($"Fatorial de {numero} = {resultado}");

            // =========================
            // EXERCÍCIO 2: PRIMO
            // =========================
            Console.WriteLine("\n📝 Exercício 2: Número Primo");

            int numPrimo = LerInteiro("Digite um número: ", 0);
            bool ehPrimo = VerificarPrimo(numPrimo);

            Console.WriteLine($"{numPrimo} é primo? {ehPrimo}");

            // =========================
            // EXERCÍCIO 3: SAUDAÇÃO
            // =========================
            Console.WriteLine("\n📝 Exercício 3: Saudação");

            SaudacaoPersonalizada();
            SaudacaoPersonalizada("Ana");
            SaudacaoPersonalizada("Bruno", true);

            // =========================
            // EXERCÍCIO 4: ARRAY
            // =========================
            Console.WriteLine("\n📝 Exercício 4: Ordenação de Array");

            int[] array = { 34, 7, 23, 32, 5, 62 };

            Console.WriteLine($"Original: [{string.Join(", ", array)}]");

            Array.Sort(array);

            Console.WriteLine($"Ordenado: [{string.Join(", ", array)}]");
        }

        // =========================
        // MÉTODOS
        // =========================

        static int LerInteiro(string mensagem, int min)
        {
            int valor;
            Console.Write(mensagem);

            while (!int.TryParse(Console.ReadLine(), out valor) || valor < min)
            {
                Console.Write($"Valor inválido. Digite >= {min}: ");
            }

            return valor;
        }

        static long Fatorial(int n)
        {
            if (n == 0) return 1;

            long f = 1;
            for (int i = 1; i <= n; i++)
            {
                f *= i;
            }
            return f;
        }

        static bool VerificarPrimo(int n)
        {
            if (n <= 1) return false;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        static void SaudacaoPersonalizada(string nome = "Visitante", bool formal = false)
        {
            if (formal)
                Console.WriteLine($"Prezado(a) {nome}, seja bem-vindo(a)!");
            else
                Console.WriteLine($"Olá {nome}! Bem-vindo(a)!");
        }
    }
}