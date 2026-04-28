using System;
using System.Collections.Generic; // Necessário para usar List<T>
using System.Linq;
 
namespace ExerciciosAula03;
 
/// <summary>
/// 📋 EXERCÍCIOS DE LISTAS (LIST<T>)
/// =================================
///
/// Exercício 1: Adicionar pessoas à lista
/// Exercício 2: Remover pessoa pelo nome
/// Exercício 3: Filtrar pessoas com mais de 30 anos
/// Exercício 4: Contar pessoas com nome começando com "J"
/// </summary>
public class AlunoExercicio03
{
  /// <summary>
  /// Classe Pessoa para representar os dados
  /// </summary>
  public class Pessoa
  {
    //Atributos públicos para facilitar o acesso
    public string Nome;
    public int Idade;
 
    //Construtor para facilitar a criação de objetos
    // O construtor é um método especial que é chamado quando criamos um novo objeto da classe. Ele é usado para inicializar os atributos do objeto.
    public Pessoa(string nome, int idade)
    {
      Nome = nome;
      Idade = idade;
    }
 
    // "override "é forma de "Sobrescreve" qualquer  método, neste exemplo o ToString(). Usamos para exibir os dados de forma legível
    // isto faz parte do polimorfismo, onde cada classe pode ter sua própria implementação de um método
    // maiores detalhes na  UC00608 P.O.O .Assim, quando chamamos Console.WriteLine(pessoa), ele exibe o nome e idade formatados
    public override string ToString()
    {
      return $"{Nome} ({Idade} anos)";
    }
  }
 
  public void Executar()
  {
    Console.WriteLine("\n\n📋 3. EXERCÍCIOS DE LISTAS (LIST<T>)");
    Console.WriteLine("=====================================\n");
 
    // ===================================================
    // EXERCÍCIO 1: Adicionar pessoas à lista
    // ===================================================
    // 👉 O QUE FAZER:
    // 1. Criar uma List<Pessoa> com os dados iniciais
    // 2. Adicionar mais 3 pessoas à lista usando .Add()
    // 3. Exibir todas as pessoas da lista
    //
    // 💡 List<T> é uma coleção dinâmica que pode crescer
    // 💡 pessoas.Add(new Pessoa("Nome", idade));
 
    Console.WriteLine("📝 Exercício 1: Adicionar pessoas à lista");
 

    // criar lista
    List<Pessoa> pessoas = new List<Pessoa> // new instancia o objeto( cria uma nova lista na memória)
    {
      new Pessoa("Ana", 25),
      new Pessoa("Bruno", 30),
      new Pessoa("Carla", 35),
      new Pessoa("Daniel", 28),
      new Pessoa("Eduarda", 40)
    };

    // adicionar mais 3 pessoas
    pessoas.Add(new Pessoa("Fernando", 22));
    pessoas.Add(new Pessoa("Gabriela", 45));
    pessoas.Add(new Pessoa("Hugo", 33));
 
    // exibir lista completa 
    pessoas.ForEach(p => Console.WriteLine($"  - {p}")); // ForEach para exibir cada pessoa formatada

    Console.WriteLine();
 
    // ===================================================
    // EXERCÍCIO 2: Remover pessoa pelo nome
    // ===================================================
    // 👉 O QUE FAZER:
    // 1. Usar o método RemoveAll() com uma condição (lambda)
    // 2. Remover a pessoa chamada "Ana" independente do índice
    // 3. Exibir a lista atualizada
    //
    // 💡 pessoas.RemoveAll(p => p.Nome == "Ana");
    // 💡 Lambda: p => condição (p é cada elemento da lista)
 
    Console.WriteLine("\n📝 Exercício 2: Remover pessoa pelo nome");
     int removidos = pessoas.RemoveAll(p => p.Nome == "Ana");
 
    Console.WriteLine($"Pessoas removidas: {removidos}");
    pessoas.ForEach(p => Console.WriteLine($"  - {p}")); // Exibir
 
    Console.WriteLine();
 
    // ===================================================
    // EXERCÍCIO 3: Filtrar pessoas com mais de 30 anos
    // ===================================================
    // 👉 O QUE FAZER:
    // 1. Usar o método FindAll() para filtrar a lista
    // 2. Buscar todas as pessoas com idade > 30
    // 3. Exibir o resultado
    //
    // 💡 List<Pessoa> filtradas = pessoas.FindAll(p => p.Idade > 30);
    // 💡 Também pode usar LINQ: pessoas.Where(p => p.Idade > 30).ToList()
 
    Console.WriteLine("\n📝 Exercício 3: Buscar pessoas com mais de 30 anos");
    List<Pessoa> pessoasComMaisDe30 = pessoas.FindAll(p => p.Idade > 30);
 
    Console.WriteLine($"Pessoas com mais de 30 anos ({pessoasComMaisDe30.Count}):");
    pessoasComMaisDe30.ForEach(p => Console.WriteLine($"  - {p}")); // Exibir filtradas
    Console.WriteLine();
 
    // ===================================================
    // EXERCÍCIO 4: Contar pessoas com nome começando com "J"
    // ===================================================
    // 👉 O QUE FAZER:
    // 1. Criar um método chamado ContarPessoasComJ
    // 2. O método deve receber a lista e retornar a quantidade
    // 3. Usar StartsWith() para verificar se o nome começa com "J"
    // 4. Chamar o método e exibir o resultado
    //
    // 💡 string.StartsWith("J", StringComparison.OrdinalIgnoreCase)
    // 💡 Para ignorar maiúsculas/minúsculas
 
    Console.WriteLine("\n📝 Exercício 4: Contar pessoas com nome começando com 'J'");
 
    // Método para contar pessoas com nome começando com "J"

    int ContarPessoasComJ(List<Pessoa> lista)
    {
      return lista.Count(p => p.Nome.StartsWith("J", StringComparison.OrdinalIgnoreCase));
    }
    int contadorJ = ContarPessoasComJ(pessoas);
    Console.WriteLine($"Número de pessoas com nome começando com 'J': {contadorJ}");
  }
}
 
 
 