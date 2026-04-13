using System;

namespace ExerciciosAula02
{
    class AlunoIteracao
    {
        static void Main(string[] args) // ponto de partida do programa, onde começa a executar o código
        {
            AlunoIteracao aluno = new AlunoIteracao(); // cria instância da classe e guarda em aluno

            Console.WriteLine("=== EXERCÍCIOS DE ITERAÇÃO EM C# ===\n");

            // Exercício 1 - Tabuada
            Console.WriteLine("--- Exercício 1: Tabuada ---");
            int numeroTabuada = aluno.LerNumeroValido("Digite um número inteiro para ver a tabuada: ");
            aluno.MostrarTabuada(numeroTabuada);

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            // Exercício 2 - Soma com valor absoluto
            Console.WriteLine("--- Exercício 2: Soma de Números (valor absoluto) ---");
            aluno.CalcularSomaAteZero();

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            // Exercício 3 - Verificação de Senha com bloqueio
            Console.WriteLine("--- Exercício 3: Verificação de Senha ---");
            aluno.VerificarSenha();

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            // Exercício 4 - Array e Foreach
            Console.WriteLine("--- Exercício 4: Array de Nomes com Foreach ---");
            aluno.ExibirNomesMaiusculas();

            Console.WriteLine("\nFim dos exercícios.");
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }

        // ====================== MÉTODO DE LEITURA COM VALIDAÇÃO ======================
        public int LerNumeroValido(string mensagem = "Digite um número inteiro: ")
        {
            int numero;

            while (true)
            {
                Console.Write(mensagem);

                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    return numero;
                }
                else
                {
                    Console.WriteLine("Erro: Por favor, digite apenas um número inteiro válido.\n");
                }
            }
        }

        // ====================== EXERCÍCIO 1 ======================
        public void MostrarTabuada(int numero)
        {
            Console.WriteLine($"\nTabuada do {numero}:\n");
            Console.WriteLine("=====================");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero,3} × {i,2} = {numero * i,4}");
            }

            Console.WriteLine("=====================");
        }

        // ====================== EXERCÍCIO 2 ======================
        public void CalcularSomaAteZero()
        {
            int soma = 0;
            int numero;

            Console.WriteLine("Digite números inteiros para somar.");
            Console.WriteLine("O programa irá considerar o valor absoluto dos números negativos.");
            Console.WriteLine("Digite 0 para parar.\n");

            while (true)
            {
                numero = LerNumeroValido("Digite um número (0 para parar): ");

                if (numero == 0)
                {
                    break;
                }

                int valorAbsoluto = Math.Abs(numero);
                soma += valorAbsoluto;

                Console.WriteLine($"   → Adicionado |{numero}| = {valorAbsoluto} | Soma atual: {soma}");
            }

            Console.WriteLine("\n=====================");
            Console.WriteLine($"Soma final (valores absolutos) = {soma}");
            Console.WriteLine("=====================");
        }

        // ====================== EXERCÍCIO 3 ======================
        public void VerificarSenha()
        {
            const string senhaCorreta = "C#2024";
            string senhaDigitada = "";
            int tentativas = 0;
            const int maxTentativas = 3;

            Console.WriteLine("Sistema protegido por senha.");
            Console.WriteLine($"Tem {maxTentativas} tentativas.\n");

            do
            {
                Console.Write("Senha: ");
                senhaDigitada = LerSenhaOculta();
                tentativas++;

                if (senhaDigitada != senhaCorreta)
                {
                    if (tentativas < maxTentativas)
                    {
                        Console.WriteLine($"❌ Senha incorreta! Tentativas restantes: {maxTentativas - tentativas}\n");
                    }
                }

            } while (senhaDigitada != senhaCorreta && tentativas < maxTentativas);

            if (senhaDigitada == senhaCorreta)
            {
                Console.WriteLine("\n✅ Senha correta! Acesso concedido.");
                Console.WriteLine("Bem-vindo ao sistema!");
            }
            else
            {
                Console.WriteLine("\n❌ Tentativas esgotadas! Acesso bloqueado.");
                Console.WriteLine("Contacte o administrador do sistema.");
            }
        }

        // ====================== EXERCÍCIO 4 ======================
        public void ExibirNomesMaiusculas()
        {
            // 1. Array de strings com nomes
            string[] nomes = { "joão", "maria", "pedro", "ana", "carlos", "sofia", "ricardo", "beatriz" };

            Console.WriteLine("Lista de nomes em maiúsculas:\n");

            // 2. Usar foreach para percorrer cada nome
            foreach (string nome in nomes)
            {
                // 3. Exibir cada nome em maiúsculas
                Console.WriteLine(nome.ToUpper());
            }

            Console.WriteLine("\n=====================");
            Console.WriteLine($"Total de nomes: {nomes.Length}");
        }

        // ====================== MÉTODO AUXILIAR - SENHA OCULTA ======================
        private string LerSenhaOculta()
        {
            string senha = "";
            ConsoleKeyInfo tecla;

            do
            {
                tecla = Console.ReadKey(true);

                if (tecla.Key != ConsoleKey.Backspace && tecla.Key != ConsoleKey.Enter)
                {
                    senha += tecla.KeyChar;
                    Console.Write("*");
                }
                else if (tecla.Key == ConsoleKey.Backspace && senha.Length > 0)
                {
                    senha = senha.Substring(0, senha.Length - 1);
                    Console.Write("\b \b");
                }

            } while (tecla.Key != ConsoleKey.Enter);

            Console.WriteLine();
            return senha;
        }
    }
}
