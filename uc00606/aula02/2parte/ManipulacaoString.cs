namespace Aula02EstruturaDeDados;

public class ManipulacaoDeString
{
    public void ExecutarMetodosBasicos()
    {
        Console.WriteLine("Manipulação Básica de String\n");

        string texto  = " Fundamentos de programação em C# ";
        string nome = "Vera Gonçalves";
        string frase = "O rato roeu a roupa do rei de Roma";

        Console.WriteLine("String original\n");
        Console.WriteLine($"{texto}");

        Console.WriteLine("Executar Métodos  Básicos de strings");
        Console.WriteLine($"Texto em maiúsculo: {texto.ToUpper()}");
        Console.WriteLine($"Texto em minúsculo: {texto.ToLower()}");
        Console.WriteLine($"Texto sem espaços: {texto.Trim()}");
        Console.WriteLine($"Texto com substring: {texto.Substring(12, 11)}");
        Console.WriteLine($"Texto com length: {texto.Length}"); //propriedade de string(n necessita de parenteses)
    }

    public void ExecutarBuscaExtraccao()
    {
        Console.WriteLine("Manipulação Básica de String\n");
        string texto  = " Fundamentos de programação em C# ";

        Console.WriteLine("Busca e Extração\n");
        int posicao = texto.IndexOf("C#");
        Console.WriteLine($"Posição de 'C#': {posicao}"); // posição da 1ª ocorrência

        Console.WriteLine($"Substring(5, 10) Extrai 10 caracteres começando da posição 5: {texto.Substring(5, 10)}");
        Console.WriteLine($"StartsWith('Fund'): {texto.TrimStart().StartsWith("Fund")}");
        Console.WriteLine($"EndsWith('C#'): {texto.TrimEnd().EndsWith("C#")}");

    }

        public void ExecutarModificacao()
    {
        Console.WriteLine("Manipulação Básica de String\n");
        string texto  = " Fundamentos de programação em C# ";

        Console.WriteLine("Modificação\n");

        Console.WriteLine($"Replace: {texto.Replace("C#", "CSharp")}"); // substitui a 1ª ocorrência da string
        Console.WriteLine($"Remove: {texto.Remove(5, 10)}"); // remove a partir da posição 5, 10 caracteres
        Console.WriteLine($"Insert (15,'Avançado'): {texto.Insert(15, "Avançado ")}"); // insere a string "Avançado " a partir da posição 15
    }

            public void ExecutarDivisaoEJuncao()
    {
        Console.WriteLine("Manipulação Básica de String\n");
        string texto  = " Fundamentos de programação em C# ";

        Console.WriteLine("Divisão e Junção\n");

        string[] palavras = texto.Split(" "); // divide a string em um array de palavras usando o espaço como delimitador
        Console.WriteLine("Palavras divididas:");
        foreach (string item in palavras)
        {
            Console.WriteLine($" '{item}' ");
        }

        // Join
        string novoTexto = string.Join("|", palavras); // junta as palavras do array usando o hífen como separador
        Console.WriteLine($"Texto juntado: {novoTexto}");

        // concanetação de strings
        string nome = "Vera";
        string sobrenome = "Gonçalves";
        string nomeCompleto = nome + " " + sobrenome; // concatenação usando o operador +
        Console.WriteLine($"Nome completo: {nomeCompleto}");
        Console.WriteLine($"Nome completo: {nome} {sobrenome}"); // concatenação usando interpolação de string


    }


}