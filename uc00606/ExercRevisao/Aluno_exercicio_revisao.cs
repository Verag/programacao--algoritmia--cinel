namespace FundamentosAlgoritmia;

public class AlunoExercicioRevisao
{
    public void ExecutarExercicioRevisao()
    {
        Console.WriteLine("\n EXERCÍCIOS GERAIS DE REVISÃO");
        Console.WriteLine("========================\n");

        Console.WriteLine("Exercício 1: verificar se 1 número é positivo ou negativo");
        Console.Write("Digite um número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero >= 0)
        {
            Console.WriteLine($"O número {numero} é positivo.");
        }
        else
        {
            Console.WriteLine($"O número {numero} é negativo ou zero.");
        }


        Console.WriteLine("========================\n");
        Console.WriteLine("\nExercício 2: identificar o maior de 2 números");
        Console.Write("Digite o primeiro número: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite o segundo número: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        if (numero1 > numero2)
        {
            Console.WriteLine($"O primeiro número {numero1} é maior que o segundo número {numero2}.");
        }
        else if (numero2 > numero1)
        {
            Console.WriteLine($"O segundo número {numero2} é maior que o primeiro número {numero1}.");
        }
        else
        {
            Console.WriteLine($"Os números {numero1} e {numero2} são iguais.");
        }

        Console.WriteLine("========================\n");
        Console.WriteLine("\nExercício 3: aplicar desconto de 10% quando o valor da compra é maior que 100 u.m.");
        Console.Write("Digite o valor da compra: ");
        decimal valorCompra = decimal.Parse(Console.ReadLine() ?? "0"); // lê o valor da compra, converte para decimal e se for null coloca zero
        

        if (valorCompra > 100)
        {
            decimal desconto = Math.Round(valorCompra * 0.10m, 2, MidpointRounding.AwayFromZero); //arredondar valor do desconto a 2 c.d. de forma precisa
            decimal valorFinal = valorCompra - desconto;

            Console.WriteLine($"O valor da compra é {valorCompra} u.m.");
            Console.WriteLine($"O desconto aplicado é de {desconto} u.m.");
            Console.WriteLine($"O valor final a ser pago é de {valorFinal} u.m.");
        }
        else
        {
            Console.WriteLine($"O valor da compra é {valorCompra} u.m., não há desconto aplicável.");
        }

        Console.WriteLine("========================\n");
        Console.WriteLine("\nExercício 4: classificar em criança, adolescente e adulto dado uma idade");
        Console.Write("Digite a idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        if (idade < 12)
        {
            Console.WriteLine($"A pessoa com {idade} anos é uma criança.");
        }
        else if (idade < 18)
        {
            Console.WriteLine($"A pessoa com {idade} anos é um adolescente.");
        }
        else
        {
            Console.WriteLine($"A pessoa com {idade} anos é um adulto.");
        }

        Console.WriteLine("========================\n");
        Console.WriteLine("\nExercício 5: criar variável com opção novo jogo, carregar jogo e sair, e usar switch para exibir a opção escolhida.");
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1 - Novo Jogo");
        Console.WriteLine("2 - Carregar Jogo");
        Console.WriteLine("3 - Sair");
        Console.Write("Digite o número da opção escolhida: ");
        int opcao = Convert.ToInt32(Console.ReadLine());
        switch (opcao)
        {
            case 1:
                Console.WriteLine("Você escolheu: Novo Jogo");
                break;
            case 2:
                Console.WriteLine("Você escolheu: Carregar Jogo");
                break;
            case 3:
                Console.WriteLine("Você escolheu: Sair");
                break;
            default:
                Console.WriteLine("Opção inválida. Por favor, escolha uma opção entre 1 e 3.");
                break;
        }

        Console.WriteLine("========================\n");
        Console.WriteLine("\nExercício 6: validar o acesso dependendo da idade e de ter convite ou não");
        Console.Write("Digite a idade: ");
        int idade_acesso = Convert.ToInt32(Console.ReadLine());

        Console.Write("Tem convite? (S/N): ");

        string temConvite;
        while (true)
        {       
        // Lemos o input, removemos espaços, passamos para maiúsculas
        // Se o utilizador não escrever nada (null), usamos "N" por defeito
        string input = Console.ReadLine()?.Trim().ToUpper() ?? "N";

        // Verificamos se o input começa com "S" ou "N"
        if (input.StartsWith("S") || input.StartsWith("N"))
        {
            temConvite = input;
            break;
        }
        Console.WriteLine("Valor inválido. Deve começar com S ou N. Tente novamente:");
        }

        Console.WriteLine($" Valor válido: {temConvite}");  // Fora do ciclo, mostramos o valor válido
        


        if (idade_acesso >= 18 || temConvite == "S")
        {
            Console.WriteLine("Acesso permitido.");
        }
        else
        {
            Console.WriteLine("Acesso negado. Deve ter 18 anos ou mais, ou possuir um convite.");
        }
    }
}


