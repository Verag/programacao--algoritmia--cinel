#using System;

namespace Fundamentos01
{
    public class EstruturasControloBasicas
    {
        public void ExecutarIf()
        {
            Console.WriteLine("Estruturas de controlo básicas");
            Console.WriteLine();

            // Estrutura de controlo if-else
            int nota = 14;
            Console.WriteLine($"Nota do aluno: {nota}");
            if (nota >= 14)
            {
                Console.WriteLine("O aluno foi aprovado.");
            }
            else
            {
                Console.WriteLine("O aluno foi reprovado.");
            }
        }

        public void ExecutarSwitchCase()
        {
            // Estrutura de controlo switch case
            int diaSemana = 3;
            Console.WriteLine($"Número do dia da semana: {diaSemana}");

            switch (diaSemana)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Segunda-feira");
                    break;
                case 3:
                    Console.WriteLine("Terça-feira");
                    break;
                case 4:
                    Console.WriteLine("Quarta-feira");
                    break;
                case 5:
                    Console.WriteLine("Quinta-feira");
                    break;
                case 6:
                    Console.WriteLine("Sexta-feira");
                    break;
                case 7:
                    Console.WriteLine("Sábado");
                    break;
                default:
                    Console.WriteLine("Número inválido para dia da semana.");
                    break;
            }
        }

        public void ExecutarTernario()
        {
            int idade = 20;
            string resultado = (idade >= 18) ? "Maior de idade" : "Menor de idade";
            Console.WriteLine($"Idade: {idade} - Resultado: {resultado}");
        }

        public void ExecutarForWhile()
        {
            // Estrutura de controlo for
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Contagem: {i}");
            }

            // Estrutura de controlo while
            int contador = 0;
            while (contador < 5)
            {
                Console.WriteLine($"Contagem: {contador}");
                contador++;
            }
        }
    }