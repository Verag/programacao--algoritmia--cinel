using System;
using System.Collections.Generic;

namespace aula03
{
    public class Program
    {
        static void Main(string[] args)
        {
            new AlunoExercicio04().Executar();
        }
    }
    public class AlunoExercicio04
    {
        public class Pessoa
        {
            public string Nome { get; set; }
            public int Idade { get; set; }

            public Pessoa(string nome, int idade)
            {
                Nome = nome;
                Idade = idade;
            }

            public override string ToString()
            {
                return $"{Nome} ({Idade} anos)";
            }

            public override bool Equals(object obj)
            {
                if (obj is Pessoa outra)
                    return Nome == outra.Nome && Idade == outra.Idade;
                return false;
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(Nome, Idade);
            }
        }

        public void Executar()
        {
            Console.WriteLine("\n🎯 EXERCÍCIOS DE HASHSET<T>");
            Console.WriteLine("====================================\n");

            // ===================================================
            // EXERCÍCIO 1
            // ===================================================
            Console.WriteLine("📝 Exercício 1: HashSet com números inteiros");

            HashSet<int> numeros = new HashSet<int>();

            int[] valores = { 10, 20, 30, 20, 40, 10, 50 };

            Console.WriteLine("Resultado das adições:");

            foreach (var valor in valores)
            {
                bool adicionado = numeros.Add(valor);

                if (valor == 20 && numeros.Count == 2)
                    Console.WriteLine($"  {valor} adicionado? {adicionado}");
                else if (valor == 20)
                    Console.WriteLine($"  {valor} (2ª vez) adicionado? {adicionado}");
                else if (valor == 10 && numeros.Count >= 4)
                    Console.WriteLine($"  {valor} (2ª vez) adicionado? {adicionado}");
                else
                    Console.WriteLine($"  {valor} adicionado? {adicionado}");
            }

            Console.WriteLine($"\nElementos no HashSet: {string.Join(", ", numeros)}");
            Console.WriteLine($"Quantidade de elementos: {numeros.Count}");

            Console.WriteLine();

            // ===================================================
            // EXERCÍCIO 2
            // ===================================================
            Console.WriteLine("📝 Exercício 2: Diferença entre ExceptWith() e SymmetricExceptWith()");

            HashSet<int> conjuntoA = new HashSet<int> { 1, 2, 3, 4, 5 };
            HashSet<int> conjuntoB = new HashSet<int> { 4, 5, 6, 7, 8 };

            Console.WriteLine($"Conjunto A original: {string.Join(", ", conjuntoA)}");
            Console.WriteLine($"Conjunto B original: {string.Join(", ", conjuntoB)}");

            var aExcept = new HashSet<int>(conjuntoA);
            aExcept.ExceptWith(conjuntoB);

            Console.WriteLine($"\nExceptWith() - A - B: {string.Join(", ", aExcept)}");

            var simetrica = new HashSet<int>(conjuntoA);
            simetrica.SymmetricExceptWith(conjuntoB);

            Console.WriteLine($"SymmetricExceptWith(): {string.Join(", ", simetrica)}");

            Console.WriteLine();

            // ===================================================
            // EXERCÍCIO 3
            // ===================================================
            Console.WriteLine("📝 Exercício 3: Operações com conjuntos de pessoas");

            HashSet<Pessoa> equipeA = new HashSet<Pessoa>
            {
                new Pessoa("Ana", 25),
                new Pessoa("Bruno", 30),
                new Pessoa("Carla", 35),
                new Pessoa("Daniel", 28)
            };

            HashSet<Pessoa> equipeB = new HashSet<Pessoa>
            {
                new Pessoa("Carla", 35),
                new Pessoa("Daniel", 28),
                new Pessoa("Eduarda", 40),
                new Pessoa("Fernando", 22)
            };

            Console.WriteLine("\nEquipe A:");
            foreach (var p in equipeA)
                Console.WriteLine($"  - {p}");

            Console.WriteLine("\nEquipe B:");
            foreach (var p in equipeB)
                Console.WriteLine($"  - {p}");

            var uniao = new HashSet<Pessoa>(equipeA);
            uniao.UnionWith(equipeB);

            Console.WriteLine("\nUnião (A ∪ B):");
            foreach (var p in uniao)
                Console.WriteLine($"  - {p}");

            var intersecao = new HashSet<Pessoa>(equipeA);
            intersecao.IntersectWith(equipeB);

            Console.WriteLine("\nInterseção (A ∩ B):");
            foreach (var p in intersecao)
                Console.WriteLine($"  - {p}");

            var diferenca = new HashSet<Pessoa>(equipeA);
            diferenca.ExceptWith(equipeB);

            Console.WriteLine("\nDiferença (A - B):");
            foreach (var p in diferenca)
                Console.WriteLine($"  - {p}");

            Console.WriteLine();

            // ===================================================
            // EXERCÍCIO 4
            // ===================================================
            Console.WriteLine("📝 Exercício 4: Subconjuntos");

            HashSet<int> conjuntoPrincipal = new HashSet<int>
            {
                1,2,3,4,5,6,7,8,9,10
            };

            HashSet<int> conjuntoSub1 = new HashSet<int> { 2, 4, 6, 8 };
            HashSet<int> conjuntoSub2 = new HashSet<int> { 2, 4, 6, 8, 11 };

            Console.WriteLine($"Conjunto Principal: {string.Join(", ", conjuntoPrincipal)}");
            Console.WriteLine($"Sub1: {string.Join(", ", conjuntoSub1)}");
            Console.WriteLine($"Sub2: {string.Join(", ", conjuntoSub2)}");

            Console.WriteLine($"\nSub1 é subconjunto? {conjuntoSub1.IsSubsetOf(conjuntoPrincipal)}");
            Console.WriteLine($"Sub2 é subconjunto? {conjuntoSub2.IsSubsetOf(conjuntoPrincipal)}");
            Console.WriteLine($"Principal é superconjunto de Sub1? {conjuntoPrincipal.IsSupersetOf(conjuntoSub1)}");

            Console.WriteLine("\n📌 FIM DOS EXERCÍCIOS");
        }
    }
}