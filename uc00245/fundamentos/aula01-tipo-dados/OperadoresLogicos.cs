
namespace Fundamentos;

public class OperadoresLogicos
{
    public void Executar()
    {
        Console.WriteLine("OPERADORES LÓGICOS");
        Console.WriteLine("Operadores lógicos são usados para combinar expressões booleanas e retornar um resultado booleano (true ou false).");
        Console.WriteLine();

        bool x = true;
        bool y = false;

        Console.WriteLine($"variável x: {x}, variável y: {y}");
        Console.WriteLine($"E lógico (x && y): {x && y}");
        Console.WriteLine($"OU lógico (x || y): {x || y}");
        Console.WriteLine($"NÃO lógico (!x): {!x}");
    }
}