namespace Aula02EstruturaDeDados;

class EstruturaDeIteracao
{
    public void ExecutarFor()
    {
        Console.WriteLine("Estrutura de repetição FOR\n"); // laço for

        for (int i = 0; i <= 5; i++)
        {
            Console.WriteLine($"Iteração: {i}");
        }
    }


    public void ExecutarForEach()
    {
        Console.WriteLine("Estrutura de repetição FOREACH\n"); // laço foreach

        // Exemplo de uso do foreach para iterar sobre um array de strings ,( exemplo de colecção)
        // parenteses retos para criar um array, chaves para criar um bloco de código, 
        // cada elemento do array é separado por vírgula.


        string[] nomes = { "João", "Maria", "Pedro", "Ana" ,"1", "true"};

        foreach (string nome in nomes)
        {
            Console.WriteLine($"Nome: {nome}");
        }
    }

    //break e continue são usados para controlar o fluxo de execução dentro de loops.
    //break é usado para sair completamente de um loop, enquanto continue é usado para pular
    //a iteração atual e continuar com a próxima iteração do loop.

    public void ExecutarForBreakContinue() // void não tem return
    {
        Console.WriteLine("Estrutura de repetição FOR com BREAK e CONTINUE\n");

        for (int i = 0; i <= 10; i++)
        {
            if (i == 3) continue; // Pula a iteração atual e continua com a próxima 
            // como mé tudo numa linha não precisa de bloco de código, 
            // mas se fosse mais de uma linha, ai sim precisaria de chaves 
            // para criar um bloco de código.


            if (i == 8)
            {
                Console.WriteLine("Sair do loop quando i é igual a 8");
                break; // Sai completamente do loop
            }

            Console.WriteLine($"Iteração: {i}");
        }
    }


    // Loop while ou laço while é uma estrutura de repetição que executa um bloco de código
    //  enquanto uma condição for verdadeira.

    public void ExecutarWhile()
    {
        Console.WriteLine("Estrutura de repetição WHILE\n");

        int contador = 1; // inicialização do contador

        while (contador <= 5)
        {
            Console.WriteLine($"Loop while: {contador}");
            contador++;// incrementar a variável
        }
    }

    //loop do while ou laço do while 
    // é semelhante ao loop while, mas a condição é verificada após a execução do bloco de código,
    // garantindo que o bloco seja executado pelo menos uma vez.

    public void ExecutarDoWhile()
    {
        Console.WriteLine("Estrutura de repetição DO WHILE\n");

        int numero; // inicialização do contador

        do
        {
            Console.WriteLine($"Digite um numero:");
            numero = 5;
            Console.WriteLine($"Você digitou: {numero}");
        } while (numero <= 5);
    }


}