/// <summary>
    /// 📋 SUMÁRIO DOS EXERCÍCIOS DE VARIÁVEIS E TIPOS DE DADOS
    /// =====================================================
    ///
    /// Exercício 1: Declaração de variáveis básicas
    /// - Aprender a declarar variáveis com tipos diferentes
    /// - Usar string (texto), int (números inteiros) e bool (verdadeiro/falso)
    /// - Utilizar o método GetType() para descobrir o tipo da variável
    ///
    /// Exercício 2: Reatribuição de valores
    /// - Entender que variáveis podem mudar de valor
    /// - Declarar uma variável e depois atribuir um novo valor
    ///
    /// Exercício 3: Flexibilidade do tipo object
    /// - Conhecer o tipo object que pode guardar qualquer tipo de dado
    /// - Ver como o tipo pode mudar durante a execução
    ///
    /// Demonstração adicional:
    /// - Conhecer outros tipos: double (decimais), char (um caractere), decimal (precisão monetária)
    /// </summary>
    /// 
    namespace Fundamentos01;
    public class ExerciciosVariaveisETiposDeDados
    {
        public void Executar()
        {
            Console.WriteLine("\n📋 1. EXERCÍCIOS DE VARIÁVEIS E TIPOS DE DADOS");
            Console.WriteLine("=============================================\n");
 
            // ===================================================
            // EXERCÍCIO 1: Declaração de variáveis básicas
            // ===================================================
            // Objetivo: Aprender a criar variáveis com os tipos mais comuns
            // string → guarda texto
            // int → guarda números inteiros
            // bool → guarda verdadeiro (true) ou falso (false)
            Console.WriteLine("📝 Exercício 1: Variáveis básicas");

            
            string nome = "Vera"; // Variável do tipo string
            Console.WriteLine(nome.GetType()); 
            Console.WriteLine(nome); // Imprime o valor da variável nome 

            int idade = 50; // Variável do tipo inteiro
            Console.WriteLine(idade.GetType());  
            Console.WriteLine(idade); // Imprime o valor da variável idade

            bool estudante = true; // Variável do tipo booleano
            Console.WriteLine(estudante.GetType());  
            Console.WriteLine(estudante); // Imprime o valor da variável estudante
 
       
 
            // ===================================================
            // EXERCÍCIO 2: Reatribuição de valores
            // ===================================================
            // Objetivo: Mostrar que variáveis podem receber novos valores
            // A mesma variável pode guardar um valor diferente mais tarde
            Console.WriteLine("📝 Exercício 2: Reatribuição de valores");

            nome = "Vera Lúcia"; // Reatribuindo um novo valor à variável nome
            Console.WriteLine(nome); // Imprime o novo valor da variável nome

            idade = 51; // Reatribuindo um novo valor à variável idade
            Console.WriteLine(idade); // Imprime o novo valor da variável idade

            estudante = false; // Reatribuindo um novo valor à variável estudante
            Console.WriteLine(estudante); // Imprime o novo valor da variável estudante


 
         
 
            // ===================================================
            // EXERCÍCIO 3: Tipo object (equivalente ao any)
            // ===================================================
            // Objetivo: Entender que o tipo object pode guardar qualquer coisa
            // É como uma caixa que pode conter diferentes tipos de objetos
            Console.WriteLine("📝 Exercício 3: Flexibilidade do tipo object");

            object x = 10;        // boxing de int
            x = "hello";          // agora é string
            x = 10;                // agora é int
 
 
            // ===================================================
            // DEMONSTRAÇÃO ADICIONAL DE TIPOS
            // ===================================================
            // Objetivo: Conhecer mais tipos disponíveis em C#
            // double → números decimais (com vírgula)
            // char → um único caractere (letra)
            // decimal → números decimais com alta precisão (usado para dinheiro)
            Console.WriteLine("📝 Demonstração adicional de tipos");

            double preco = 19.99; // Variável do tipo double
            Console.WriteLine(preco.GetType());
            Console.WriteLine(preco); // Imprime o valor da variável preco

            char letra = 'A'; // Variável do tipo char
            Console.WriteLine(letra.GetType());
            Console.WriteLine(letra); // Imprime o valor da variável letra

            decimal salario = 2500.75m; // Variável do tipo decimal (note o 'm' no final)
            Console.WriteLine(salario.GetType());
            Console.WriteLine(salario); // Imprime o valor da variável salario

        }
    }

