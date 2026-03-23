
namespace Fuxograma02
{
    class Program // é uma super hiper mega variável
    {
        /**Variáveis*/
        //variáveis chamadas de atributos
        static void Main(string[] args)
        //variáveis dentro do (...) são propriedades
        {
            Console.WriteLine("=== FLUXOGRAMA DE TRABALHO  ===\n"); //inicio
            Console.WriteLine("1. INICIO");

            // sequência das acções
            Console.WriteLine("2. COMECEI A TRABALHAR");
            Console.WriteLine("3. RECEBI 10 DOCUMENTOS PARA ASSINAR E TRABALHAR");
            int documentos = 10; 
            int contador = 0;

            // repetidor (for, while, do while)
            Console.WriteLine("4. AINDA TEM DOCUMENTOS PARA AUDITAR E ASSINAR?");

            while (contador < documentos)
            {
                Console.WriteLine("SIM -> AUDITANDO E ASSINANDO");
                Console.WriteLine($"DOCUMENTOS {contador + 1} CONCLUÍDO"); //concatenação
                contador++; //contador = contador + 1(forma abrevivada de incrementar)
            } // fim do while
                

                //acabaram os documentos
                Console.WriteLine("JÁ NÃO TEM DOCUMENTOS");
                Console.WriteLine("AINDA TEM ATIVIDADE");

                //variável do tipo booleana
                bool temAtividade = true; //true ou false

                if(temAtividade) // se tem atividade for true,
                {
                    Console.WriteLine("SIM TEM ATIVIDADE");
                }
                else
                {
                    Console.WriteLine("NÃO TEM ATIVIDADE");
                }

                // BLOCO DO FIM
                Console.WriteLine("6. FIM");

                Console.WriteLine("\n ****** FIM DO PROGRAMA *****");


            
            //fim
            Console.WriteLine("8. FIM");

            Console.WriteLine("==FIM DA SEQUÊNCIA===\n"); //inicio


            


    

        } //fim do método main
        