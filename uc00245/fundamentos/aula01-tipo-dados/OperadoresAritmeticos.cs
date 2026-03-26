
namespace Fundamentos01;
public class OperadoresAritmeticos
{
    public void Executar() // método ("vai à porta mas não traz nada de volta")
    {
        Console.WriteLine("OPERADORES ARITMÉTICOS");
        Console.WriteLine("Operadores aritméticos são usados para realizar operações matemáticas.");
        Console.WriteLine();

        int a = 10; // igual é operador de atribuição, ou seja, atribui o valor 10 à variável a
        int b = 5; // igual é operador de atribuição, ou seja, atribui o valor 5 à variável b

        Console.WriteLine($"variável a: {a}, variável b: {b}");
        Console.WriteLine($"Soma (a + b): {a + b}");
        Console.WriteLine($"Subtração (a - b): {a - b}");
        Console.WriteLine($"Multiplicação (a * b): {a * b}");
        Console.WriteLine($"Divisão (a / b): {a / b}");
        Console.WriteLine($"Módulo ou Resto (a % b): {a % b}"); // resto da divisão (útil para saber se nṹmero é par ou ímpar)
    }
} //fim class