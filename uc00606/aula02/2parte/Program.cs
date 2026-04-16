namespace Aula02EstruturaDeDados;

class Program 
{
    static void Main(string[] args)
    {
        Console.WriteLine("Estrutura de dados\n");

/*         EstruturaDeIteracao estruturaDeIteracao = new EstruturaDeIteracao();
        estruturaDeIteracao.ExecutarFor();
        estruturaDeIteracao.ExecutarForEach();
        estruturaDeIteracao.ExecutarForBreakContinue();
        estruturaDeIteracao.ExecutarWhile(); */
/*         ArrayUnidimensional arrayUnidimensional = new ArrayUnidimensional();
        arrayUnidimensional.ExecutarArrayUnidimensional(); */

        ManipulacaoDeString manipulacaoDeString = new ManipulacaoDeString();
        manipulacaoDeString.ExecutarMetodosBasicos();
        manipulacaoDeString.ExecutarBuscaExtraccao();
        manipulacaoDeString.ExecutarModificacao();
        manipulacaoDeString.ExecutarDivisaoEJuncao();

    }
} //fim da classe Program
