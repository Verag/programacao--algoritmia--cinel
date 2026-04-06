namespace Aula02EstruturaDeDados;

class Program 
{
    static void Main(string[] args)
    {
        Console.WriteLine("Estrutura de dados\n");

        EstruturaDeIteracao estruturaDeIteracao = new EstruturaDeIteracao();
        estruturaDeIteracao.ExecutarFor();
        estruturaDeIteracao.ExecutarForEach();
        estruturaDeIteracao.ExecutarForBreakContinue();
        estruturaDeIteracao.ExecutarWhile();

    }
} //fim da classe Program
