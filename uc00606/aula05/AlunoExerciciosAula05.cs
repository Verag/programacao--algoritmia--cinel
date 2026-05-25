using System;
using System.Collections.Generic;

namespace ExerciciosAula05DicionarioOuMap
{
    public class AlunoExercicioAula05
    {
        public void Executar()
        {
            Console.WriteLine("\n\n📖 5. EXERCÍCIOS DE DICIONÁRIO (DICTIONARY<TKey, TValue>)");
            Console.WriteLine("========================================================");

            // ===================================================
            // EXERCÍCIO 1: Dicionário de produtos
            // ===================================================
            Console.WriteLine("\n📝 Exercício 1: Dicionário de produtos");
            Dictionary<int, string> produtos = new Dictionary<int, string>();

            produtos.Add(101, "Notebook Dell");
            produtos.Add(102, "Mouse Logitech");
            produtos.Add(103, "Teclado Mecânico");
            produtos.Add(104, "Monitor LG");
            produtos.Add(105, "Headset HyperX");

            Console.WriteLine("Produtos registados:");
            foreach (var item in produtos)
            {
                Console.WriteLine($"Código: {item.Key} → Produto: {item.Value}");
            }

            Console.WriteLine("\nTentando adicionar produto com código 101 já existente...");
            try
            {
                produtos.Add(101, "Outro Produto");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }

            Console.WriteLine($"Total de produtos: {produtos.Count}");

            // ===================================================
            // EXERCÍCIO 2: Sistema de contagem de votos
            // ===================================================
            Console.WriteLine("\n📝 Exercício 2: Sistema de contagem de votos");
            Dictionary<string, int> votos = new Dictionary<string, int>();
            string[] votantes = { "Ana", "Bruno", "Ana", "Carla", "Bruno", "Ana", "Daniel", "Carla", "Ana" };

            Console.WriteLine("Registrando votos...");
            foreach (string candidato in votantes)
            {
                if (votos.ContainsKey(candidato))
                {
                    votos[candidato]++;
                }
                else
                {
                    votos[candidato] = 1;
                }
                Console.WriteLine($"Voto registrado para: {candidato}");
            }

            Console.WriteLine("\nResultado da votação:");
            int maxVotos = 0;
            string vencedor = "";
            foreach (var item in votos)
            {
                Console.WriteLine($"{item.Key}: {item.Value} voto(s)");
                if (item.Value > maxVotos)
                {
                    maxVotos = item.Value;
                    vencedor = item.Key;
                }
            }
            Console.WriteLine($"🏆 Vencedora: {vencedor} com {maxVotos} votos!");

            // ===================================================
            // EXERCÍCIO 3: Agenda telefónica
            // ===================================================
            Console.WriteLine("\n📝 Exercício 3: Agenda telefónica");
            Dictionary<string, string> agenda = new Dictionary<string, string>
            {
                { "Ana Silva", "(11) 91234-5678" },
                { "Bruno Souza", "(21) 98765-4321" },
                { "Carla Mendes", "(31) 99876-5432" },
                { "Daniel Oliveira", "(41) 95555-8888" }
            };

            Console.WriteLine("Agenda telefónica:");
            foreach (var contato in agenda)
            {
                Console.WriteLine($" {contato.Key} → {contato.Value}");
            }

            Console.WriteLine("\nProcurando telefone de Carla Mendes:");
            if (agenda.TryGetValue("Carla Mendes", out string? telefone))
            {
                Console.WriteLine($" Telefone: {telefone}");
            }

            Console.WriteLine("\nAtualizando telefone de Ana Silva...");
            agenda["Ana Silva"] = "(11) 90000-1111";
            Console.WriteLine(" Novo telefone: (11) 90000-1111");

            Console.WriteLine("\nRemovendo Daniel Oliveira...");
            agenda.Remove("Daniel Oliveira");

            Console.WriteLine("\nAgenda após alterações:");
            foreach (var contato in agenda)
            {
                Console.WriteLine($" {contato.Key} → {contato.Value}");
            }

            // ===================================================
            // EXERCÍCIO 4: Busca segura com TryGetValue()
            // ===================================================
            Console.WriteLine("\n📝 Exercício 4: Busca segura com TryGetValue()");

            Console.WriteLine("Buscando produtos usando TryGetValue():");
            if (produtos.TryGetValue(103, out string? nome1))
                Console.WriteLine($" ✓ Produto 103 encontrado: {nome1}");
            else
                Console.WriteLine(" ✗ Produto 103 não encontrado");

            if (produtos.TryGetValue(999, out string? nome2))
                Console.WriteLine($" ✓ Produto 999 encontrado: {nome2}");
            else
                Console.WriteLine(" ✗ Produto 999 não encontrado");

            Console.WriteLine("\nComparação com acesso direto (perigoso):");
            Console.WriteLine(" produtos[999] lançaria KeyNotFoundException!");

            // ===================================================
            // EXERCÍCIO 5: Percorrer Keys e Values
            // ===================================================
            Console.WriteLine("\n📝 Exercício 5: Percorrer Keys e Values separadamente");

            Console.WriteLine("Todas as chaves (códigos de produtos):");
            foreach (int codigo in produtos.Keys)
            {
                Console.WriteLine($" Código: {codigo}");
            }

            Console.WriteLine("\nTodos os valores (nomes dos produtos):");
            foreach (string nome in produtos.Values)
            {
                Console.WriteLine($" Produto: {nome}");
            }

            Console.WriteLine("\nPercorrendo pares (chave + valor):");
            foreach (var item in produtos)
            {
                Console.WriteLine($" {item.Key} → {item.Value}");
            }

            // Resumo
            Console.WriteLine("\n📌 Resumo sobre Dictionary<TKey, TValue>:");
            Console.WriteLine("new Dictionary<TKey,TValue>() → criar dicionário");
            Console.WriteLine("dic[chave] = valor → adicionar/atualizar");
            Console.WriteLine("dic.Add(chave, valor) → adicionar (lança erro se existir)");
            Console.WriteLine("dic.ContainsKey(chave) → verificar se chave existe");
            Console.WriteLine("dic.TryGetValue(chave, out var) → buscar seguro");
            Console.WriteLine("dic.Remove(chave) → remover item");
            Console.WriteLine("dic.Keys → todas as chaves");
            Console.WriteLine("dic.Values → todos os valores");
        }
    }

    // ====================== CLASSE COM O MAIN ======================
    class Program
    {
        static void Main(string[] args)
        {
            AlunoExercicioAula05 aluno = new AlunoExercicioAula05();
            aluno.Executar();

            Console.WriteLine("\n\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
