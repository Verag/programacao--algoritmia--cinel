namespace aula03;

public class LocalHashSet
{
    public void ExecutarhashSet()
    {
        HashSet<Pessoa> pessoas = new HashSet<Pessoa>();

        // Adicionando pessoas ao HashSet
        pessoas.Add(new Pessoa("Alice", 30));
        pessoas.Add(new Pessoa("Bob", 25));
        pessoas.Add(new Pessoa("Charlie", 35));  

        foreach (var pessoa in pessoas)
        {
            pessoa.Apresentar();
        }

        // Adicionar duplicado
        bool duplicado  = pessoas.Add(new Pessoa("Alice", 30)); // Este não será adicionado, pois

        if (!duplicado)
        {
            Console.WriteLine($ "retorno da variável adicionada: {duplicado}"); // O retorno será false, pois o objeto já existe no HashSet, ou seja, já existe uma pessoa com o mesmo nome e idade
            Console.WriteLine("Pessoa duplicada não adicionada: Alice, 30");
            
            foreach(var pessoa in pessoas)
            {
                Console.WriteLine($"Nosso conjunto tem duplicados? {duplicado} nossos dados{pessoa.Nome} com idade {pessoa.Idade}"); // O retorno será false, pois o objeto já existe no HashSet, ou seja, já existe uma pessoa com o mesmo nome e idade
            }
            
        }

        //Verificar se existe
        Pessoa procurarPessoa = new Pessoa("Bob", 25);
        bool existe = pessoas.Contains(procurarPessoa); // O retorno será true, pois o objeto existe no HashSet, ou seja, existe uma pessoa com o mesmo nome e idade
        Console.WriteLine($"A pessoa {procurarPessoa.Nome} existe no conjunto? {existe}");  

    }

    



}