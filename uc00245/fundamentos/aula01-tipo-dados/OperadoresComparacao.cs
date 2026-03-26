
namespace Fundamentos01;

public class OperadoresComparacao
{
    public void Executar()
    {
        Console.WriteLine("OPERADORES DE COMPARAÇÃO");
        Console.WriteLine("Operadores de comparação são usados para comparar valores e retornar um resultado booleano (true ou false).");
        Console.WriteLine();

        int a = 5;
        int b = 5;

        Console.WriteLine($"variável a: {a}, variável b: {b}");
        Console.WriteLine($"Igual a (a == b): {a == b}");
        Console.WriteLine($"Diferente de (a != b): {a != b}");
        Console.WriteLine($"Maior que (a > b): {a > b}");
        Console.WriteLine($"Menor que (a < b): {a < b}");
        Console.WriteLine($"Maior ou igual a (a >= b): {a >= b}");
        Console.WriteLine($"Menor ou igual a (a <= b): {a <= b}");
    }
} //fim class