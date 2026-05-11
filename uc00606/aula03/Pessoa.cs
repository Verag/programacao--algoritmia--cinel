using System.Reflection.Metadata;

namespace aula03;

public class Pessoa //super variável, tipo de variável que pode conter mais de um valor, ou seja, um conjunto de variáveis
{
    public string Nome { get; set; } // tipo não primitivo de variável (o correto é ser privado e depois usar get e set)
    public int Idade { get; set; } // tipo primitivo de variável(o correto é ser privado e depois usar get e set)
    

    public Pessoa (string nome, int idade) // construtor, método especial que tem o mesmo nome da classe e é usado para criar objetos
    {
        this.Nome = nome; // this é uma palavra reservada que se refere ao objeto atual, ou seja, o objeto que está sendo criado
        this.Idade = idade;
    }

    public void Apresentar() => Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos."); // expressão lambda, forma de escrever métodos de forma mais concisa, usando a seta =>
    public bool EmaiorDeIdade() => this.Idade >= 18; // expressão lambda, forma de escrever métodos de forma mais concisa, usando a seta =>
    public int CalcularAnoNascimento() => DateTime.Now.Year - this.Idade; // expressão lambda, forma de escrever métodos de forma mais concisa, usando a seta =>

            //Overridedo equals e gethashcode para comparar os objetos pelo nome e idade, pois o hashset não permite objetos duplicados, ou seja, objetos com o mesmo nome e idade
        public override bool Equals(object? obj)
        {
            //return base.Equals(obj);
            if (obj == null)
            {
                return false;
            }

            //verificar se o objeto é do mesmo tipo
            if(obj is not Pessoa OutraPessoa)
            {
                return false;
            }

            //return que compara os atributos nome e idade, ou seja, se o nome e a idade forem iguais, os objetos são considerados iguais
            return Nome == OutraPessoa.Nome && Idade == OutraPessoa.Idade;
        }

        public override int GetHashCode()
        {
            //return base.GetHashCode();
            return HashCode.Combine(Nome,Idade); //combina o nome e a idade para gerar um hashcode único para cada pessoa
        }

}