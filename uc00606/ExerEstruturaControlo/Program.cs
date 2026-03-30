

using System;

class Program
{
    static void Main()
    {
        /* Exercício 1: Classificação de números
        Digite um número: Número digitado: 7
        O número é POSITIVO */

        Console.WriteLine("Exercício 1: Classificação de números");
        Console.Write("Digite um número: ");
  
        int numero = int.Parse(Console.ReadLine()); // guarda o número inserido pelo utilizador 

        // Verifica se o número é positivo, negativo ou zero
        if (numero > 0)
        {
            Console.WriteLine("O número é POSITIVO");
        }
        else if (numero < 0)
        {
            Console.WriteLine("O número é NEGATIVO");
        }
        else
        {
            Console.WriteLine("O número é ZERO");
        }

        /* Exercício 2: Par ou Ímpar (Ternário)
        Digite um número: Número digitado: 12
        O número 12 é PAR */
        
        Console.WriteLine("Exercício 2: Par ou Ímpar (Ternário)");
        Console.Write("Digite um número: ");
        int numero2 = int.Parse(Console.ReadLine());

        // Operador ternário para verificar par ou ímpar
        string resultado = (numero2
         % 2 == 0) ? "PAR" : "ÍMPAR";

        Console.WriteLine($"O número {numero2} é {resultado}");

        /*  Exercício 3: Dias da semana (Switch)
        Digite um número de 1 a 7: Número digitado: 3
        Dia da semana: Quarta-feira */

        Console.WriteLine("Exercício 3: Dias da semana (Switch)");
        Console.Write("Digite um número de 1 a 7: ");

        int dia = int.Parse(Console.ReadLine());

        string diaSemana;

        switch (dia)
        {
            case 1:
                diaSemana = "Domingo";
                break;
            case 2:
                diaSemana = "Segunda-feira";
                break;
            case 3:
                diaSemana = "Quarta-feira";
                break;
            case 4:
                diaSemana = "Quinta-feira";
                break;
            case 5:
                diaSemana = "Sexta-feira";
                break;
            case 6:
                diaSemana = "Sábado";
                break;
            case 7:
                diaSemana = "Domingo";
                break;
            default:
                diaSemana = "Número inválido! Digite de 1 a 7.";
                break;
        }

        Console.WriteLine("Dia da semana: " + diaSemana);




        /* Exercício 4: Sistema de Autenticação
        Username: admin
        Password: ****
        ✅ ACESSO PERMITIDO */
                // Exercício 4: Sistema de Autenticação com switch pedindo username e senha
        Console.WriteLine("Exercício 4: Sistema de Autenticação (Switch)");
        
        Console.Write("Username: ");
        string username = Console.ReadLine();
        
        Console.Write("Password: ");
        string password = Console.ReadLine();

        // Combina username e password para usar no switch
        string combo = username + ":" + password;

        switch (combo)
        {
            case "admin:1234":
                Console.WriteLine("✅ ACESSO PERMITIDO");
                break;

            case var _ when username == "admin" && password != "1234":
                Console.WriteLine("❌ SENHA INCORRETA");
                break;

            case var _ when username != "admin" && password == "1234":
                Console.WriteLine("❌ USUÁRIO INCORRETO");
                break;

            default:
                Console.WriteLine("❌ USUÁRIO E SENHA INCORRETOS");
                break;
        }

    }
}


 

 
