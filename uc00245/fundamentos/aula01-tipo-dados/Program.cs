namespace Fundamentos01
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Início da Aula 01 \n");
            Aula01 aula01 = new Aula01();
            aula01.ExecutarAula();

            VariaveisETiposDeDados variaveis = new VariaveisETiposDeDados();
            variaveis.Executar();

            OperadoresAritmeticos aritmeticos = new OperadoresAritmeticos();
            aritmeticos.Executar();

            OperadoresComparacao comparacao = new OperadoresComparacao();
            comparacao.Executar();

            OperadoresLogicos logicos = new OperadoresLogicos();
            logicos.Executar();

            ExerciciosVariaveisETiposDeDados exercicios = new ExerciciosVariaveisETiposDeDados
            ();
            exercicios.Executar();


        }


        
    } // fim da classe Program


} // fim do namespace
