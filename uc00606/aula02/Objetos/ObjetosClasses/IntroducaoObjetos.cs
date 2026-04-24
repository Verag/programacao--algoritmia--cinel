namespace ObjectosClasses;

public class IntroducaoObjetos
{
    public void Executar()
    {
        Console.WriteLine("Introdução a Instâncias ou Objetos \n");

        Pessoa pessoa = new Pessoa("Vera", 39); // instanciando um objeto da classe Pessoa, ou seja, criando um objeto do tipo Pessoa
        pessoa.Apresentar(); // chamando o método Apresentar do objeto pessoa
       

        //Usar métodos com retorno
        Console.WriteLine("Métodos com retorno \n");
        Console.WriteLine($"{pessoa.Nome} é maior de idade? {pessoa.EmaiorDeIdade()}");
        Console.WriteLine($"Ano de nascimento aproximado: {pessoa.CalcularAnoNascimento()}");

        //Nossa lista
        Console.WriteLine("Nossa lista de objetos \n"); // usamos quando estamos a lidar com classes, ou seja, objetos, e queremos armazenar vários objetos em uma coleção, como uma lista, um array, etc.

        List<Pessoa> pessoas = new List<Pessoa>(); // criando uma lista de objetos do tipo Pessoa
        pessoas.Add(new Pessoa("João", 25)); // adicionando um objeto do tipo Pessoa à lista pessoas
        pessoas.Add(pessoa); // adicionando o objeto pessoa à lista pessoas
        pessoas.Add(new Pessoa("Maria", 30)); // adicionando um objeto do tipo Pessoa à lista pessoas

        pessoas.ForEach(p => p.Apresentar()); // usando o método ForEach para chamar o método Apresentar de cada objeto da lista pessoas

        
        // Imprimindo informações de todos os objetos na lista
        Console.WriteLine("Informações das pessoas na lista:");
        foreach (Pessoa p in pessoas)
        {
            p.Apresentar();
        }

    }


}
