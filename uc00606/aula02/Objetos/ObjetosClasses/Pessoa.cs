using System.Reflection.Metadata;

namespace ObjectosClasses;

public class Pessoa //super variável, tipo de variável que pode conter mais de um valor, ou seja, um conjunto de variáveis
{
    public string Nome; // tipo não primitivo de variável (o correto é ser privado e depois usar get e set)
    public int Idade; // tipo primitivo de variável(o correto é ser privado e depois usar get e set)

    public Pessoa (string nome, int idade) // construtor, método especial que tem o mesmo nome da classe e é usado para criar objetos
    {
        this.Nome = nome; // this é uma palavra reservada que se refere ao objeto atual, ou seja, o objeto que está sendo criado
        this.Idade = idade;
    }

    public void Apresentar() => Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos."); // expressão lambda, forma de escrever métodos de forma mais concisa, usando a seta =>
    public bool EmaiorDeIdade() => this.Idade >= 18; // expressão lambda, forma de escrever métodos de forma mais concisa, usando a seta =>
    public int CalcularAnoNascimento() => DateTime.Now.Year - this.Idade; // expressão lambda, forma de escrever métodos de forma mais concisa, usando a seta =>

}