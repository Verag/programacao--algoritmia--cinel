namespace FundamentosAlgoritmia;

public class AlunoExercicioRevisaoRevisto
{
    public void Executar()
    {
        while (true)
        {
            Console.WriteLine("\n=== MENU ===");
            Console.WriteLine("1 - Positivo/Negativo");
            Console.WriteLine("2 - Maior de dois números");
            Console.WriteLine("3 - Desconto");
            Console.WriteLine("4 - Classificação por idade");
            Console.WriteLine("5 - Menu jogo");
            Console.WriteLine("6 - Acesso");
            Console.WriteLine("0 - Sair");

            int opcao = LerInteiro("Escolha: ");

            if (opcao == 0) break;

            switch (opcao)
            {
                case 1: Exercicio1(); break;
                case 2: Exercicio2(); break;
                case 3: Exercicio3(); break;
                case 4: Exercicio4(); break;
                case 5: Exercicio5(); break;
                case 6: Exercicio6(); break;
                default: Console.WriteLine("Opção inválida."); break;
            }
        }
    }

    // Função reutilizável para ler inteiros com validação
    // out: modificador (atribuir valor dentro do método) 
    private int LerInteiro(string mensagem, int? minimo = null, int? maximo = null)
    {
        if (minimo.HasValue && maximo.HasValue && minimo > maximo)
            throw new ArgumentException("O valor mínimo não pode ser maior que o valor máximo.");

        while (true)
        {
            Console.Write(mensagem);
            if (int.TryParse(Console.ReadLine(), out int valor))
            {
                if (minimo.HasValue && valor < minimo.Value)
                {
                    Console.WriteLine($"Valor deve ser no mínimo {minimo.Value}.");
                    continue;
                }
                if (maximo.HasValue && valor > maximo.Value)
                {
                    Console.WriteLine($"Valor deve ser no máximo {maximo.Value}.");
                    continue;
                }
                return valor; // Sai logo quando válido
            }

            Console.WriteLine("Valor inválido. Digite um número inteiro.");
        }
    }




    // Função reutilizável para ler decimais com validação
    private decimal LerDecimal(string mensagem, decimal? minimo = null, decimal? maximo = null)
    {
        if (minimo.HasValue && maximo.HasValue && minimo > maximo)
            throw new ArgumentException("O valor mínimo não pode ser maior que o valor máximo.");

        while (true)
        {
            Console.Write(mensagem);
            if (decimal.TryParse(Console.ReadLine(), out decimal valor))
            {
                if (minimo.HasValue && valor < minimo.Value)
                {
                    Console.WriteLine($"Valor deve ser no mínimo {minimo.Value}.");
                    continue;
                }
                if (maximo.HasValue && valor > maximo.Value)
                {
                    Console.WriteLine($"Valor deve ser no máximo {maximo.Value}.");
                    continue;
                }
                return valor; // Sai logo quando válido
            }

            Console.WriteLine("Valor inválido. Digite um número decimal.");
        }
    }

    // ---------------- EXERCÍCIOS ----------------
    private void Exercicio1() // se não colocar public o método é privado por padrão, void não retorna nada
    {
        Console.Clear();
        int numero = LerInteiro("Digite um número: ");

        if (numero > 0)
            Console.WriteLine("Positivo");
        else if (numero < 0)
            Console.WriteLine("Negativo");
        else
            Console.WriteLine("Zero");
    }
    
    private void Exercicio2()
    {
        Console.Clear();
        int a = LerInteiro("Primeiro número: ");
        int b = LerInteiro("Segundo número: ");

        if (a > b)
            Console.WriteLine($"{a} é maior");
        else if (b > a)
            Console.WriteLine($"{b} é maior");
        else
            Console.WriteLine("São iguais");
    }

    private void Exercicio3()
    {
        Console.Clear();
        decimal valor = LerDecimal("Valor da compra: ");

        decimal valorFinal = CalcularDesconto(valor, 100m, 10m); // m serve para indicar que o numero é decimal

        Console.WriteLine($"Valor final: {valorFinal}");
    }

    // generalização da função para qualquer ponto de corte e percentual de desconto e
    // inclusão de validações de entrada e arredondamento do valor final a 2 c.d.
    decimal CalcularDesconto(decimal valor, decimal pontoCorte, decimal percentualDesconto)
{
    // Validações de entrada
    if (valor < 0)
        throw new ArgumentException("O valor da compra não pode ser negativo.", nameof(valor));

    if (pontoCorte < 0)
        throw new ArgumentException("O ponto de corte não pode ser negativo.", nameof(pontoCorte));

    if (percentualDesconto < 0 || percentualDesconto > 100)
        throw new ArgumentException("O percentual de desconto deve estar entre 0 e 100.", nameof(percentualDesconto));

    // Aplicar desconto se o valor ultrapassar o ponto de corte
    if (valor > pontoCorte)
    {
        decimal desconto = valor * (percentualDesconto / 100m);
        decimal valorFinal = Math.Round(valor - desconto, 2, MidpointRounding.AwayFromZero);

        Console.WriteLine($"Valor original: {valor} u.m.");
        Console.WriteLine($"Desconto aplicado: {desconto} u.m. ({percentualDesconto}%)");

        return valorFinal;
    }

    // Sem desconto
    Console.WriteLine($"Valor original: {valor} u.m. Não há desconto aplicado.");
    return valor;
}

    private void Exercicio4()
    {
        Console.Clear();
        int idade = LerInteiro("Idade: ");

        if (idade < 12)
            Console.WriteLine("Criança");
        else if (idade < 18)
            Console.WriteLine("Adolescente");
        else
            Console.WriteLine("Adulto");
    }

    private void Exercicio5()
    {
        Console.Clear();
        int opcao = LerInteiro("1-Novo | 2-Carregar | 3-Sair: ");

        // versão moderna do switch (mais usada hoje, segundo chat GPT)
        string resultado = opcao switch
        {
            1 => "Novo Jogo",
            2 => "Carregar Jogo",
            3 => "Sair",
            _ => "Inválido"
        };

        Console.WriteLine(resultado);
    }

    private void Exercicio6()
    {
        Console.Clear();
        int idade = LerInteiro("Idade: ");
        bool temConvite = LerSimNao("Tem convite (S/N): ");

        if (idade >= 18 || temConvite)
            Console.WriteLine("Acesso permitido");
        else
            Console.WriteLine("Acesso negado");
    }

    bool LerSimNao(string mensagem)
    {
        Console.Write(mensagem);

        while (true)
        {
            string input = Console.ReadLine()?.Trim().ToUpper() ?? "";

            if (input.StartsWith("S")) return true;
            if (input.StartsWith("N")) return false;

            Console.Write("Digite S ou N: ");
        }
    }
}