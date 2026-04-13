namespace Aula02EstruturaDeDados;

class ArrayUnidimensional
{
    public void ExecutarArrayUnidimensional()
    {
        Console.WriteLine("Array Unidimensional\n");

        // declaração do array
        int[] numeros = new int[5]; // Cria um array de inteiros com 5 elementos
        string[] nomes = {"ana", "tony", "maria", "humberto", "joão", "true"};

        for(int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = (i + 1)* 100;
        }

        // Acesso e exibição

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine($"Número na posição {i}: {numeros[i]}");
        }

        Console.WriteLine("Array de Strings\\n");

        foreach (string nome in nomes)
        {
            Console.WriteLine($"Valores no array Nomes: {nome}");
        }

        // propriedades do array
        //está entre a variável e o método (é uma característica)
        // método precisa de parenteses e a propriedade não precisa de parenteses
        
        Console.WriteLine("Propriedades do array");
        Console.WriteLine($"Minha proriedade de tamanho: {nomes.Length}");
        Console.WriteLine($"Minha proriedade de Dimnesões: {numeros.Rank}");

        //Métodos de array(Sort)
        Console.WriteLine("Métodos de array");
        Array.Sort(nomes);
        Console.WriteLine("Array de Strings ordenado");
        foreach (string nome in nomes)        {
            Console.WriteLine($"Array ordenado: {nome}");  
        } 

        //Métodos de array(IndexOf)
        int index = Array.IndexOf(nomes, "humberto");
        Console.WriteLine($"O índice do nome humberto é: {index}");


    }
}