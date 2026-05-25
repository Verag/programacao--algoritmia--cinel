using System;
using System.Collections.Generic;


namespace aula04;



  /// <summary>
  /// 📖 EXERCÍCIOS DE DICIONÁRIO (DICTIONARY<TKEY, TVALUE>)
  /// ======================================================
  ///
  /// Exercício 1: Dicionário de produtos (código → nome)
  /// Exercício 2: Sistema de contagem de votos
  /// Exercício 3: Agenda telefônica (nome → telefone)
  /// Exercício 4: Busca segura com TryGetValue()
  /// Exercício 5: Percorrer Keys e Values separadamente
  /// </summary>
  public class AlunoExercicioAula05
  {
    public void Executar()
    {
      Console.WriteLine("\n\n📖 5. EXERCÍCIOS DE DICIONÁRIO (DICTIONARY<TKEY, TVALUE>)");
      Console.WriteLine("========================================================\n");

      // ===================================================
      // EXERCÍCIO 1: Dicionário de produtos (código → nome)
      // ===================================================
      // 👉 O QUE FAZER:
      // 1. Criar um Dictionary<int, string> para armazenar produtos
      // 2. Adicionar 5 produtos com código e nome
      // 3. Exibir todos os produtos
      // 4. Tentar adicionar um produto com código repetido
      //
      // 💡 A chave não pode ser duplicada, o valor pode
      // 💡 Usar Add() ou atribuição direta dic[chave] = valor

      Console.WriteLine("📝 Exercício 1: Dicionário de produtos");

      // ESCREVA SEU CÓDIGO AQUI
      Dictionary<int, string> produtos = new Dictionary<int, string>();

      produtos.Add(101, "Notebook Dell");
      produtos.Add(102, "Mouse Logitech");
      produtos.Add(103, "Teclado Mecânico");
      produtos.Add(104, "Monitor LG");
      produtos.Add(105, "Headset HyperX");

      Console.WriteLine("Produtos cadastrados:");
      foreach (var par in produtos)
      {
          Console.WriteLine($"  Código: {par.Key} → Produto: {par.Value}");
      }

      Console.WriteLine("\nTentando adicionar produto com código 101 já existente...");
      try 
      {
          produtos.Add(101, "Smartphone Samsung");
      }
      catch (ArgumentException ex)
      {
          Console.WriteLine($"  Erro: {ex.Message}");
      }


      



      //Saida esperada:
      /**📝 Exercício 1: Dicionário de produtos

      Produtos cadastrados:
        Código: 101 → Produto: Notebook Dell
        Código: 102 → Produto: Mouse Logitech
        Código: 103 → Produto: Teclado Mecânico
        Código: 104 → Produto: Monitor LG
        Código: 105 → Produto: Headset HyperX

      Tentando adicionar produto com código 101 já existente...
        Erro: An item with the same key has already been added. Key: 101

      Total de produtos: 5*/
      Console.WriteLine();

      // ===================================================
      // EXERCÍCIO 2: Sistema de contagem de votos
      // ===================================================
      // 👉 O QUE FAZER:
      // 1. Criar um Dictionary<string, int> para armazenar votos
      // 2. Registrar votos para candidatos
      // 3. Se candidato não existir, adicionar com 1 voto
      // 4. Se existir, incrementar o valor
      // 5. Exibir resultado da votação
      //
      // 💡 Usar ContainsKey() para verificar se a chave existe

      Console.WriteLine("\n📝 Exercício 2: Sistema de contagem de votos");

      // ESCREVA SEU CÓDIGO AQUI



      //Saida esperada:
      /**📝 Exercício 2: Sistema de contagem de votos

      Registrando votos...
        Voto registrado para: Ana
        Voto registrado para: Bruno
        Voto registrado para: Ana
        Voto registrado para: Carla
        Voto registrado para: Bruno
        Voto registrado para: Ana
        Voto registrado para: Daniel
        Voto registrado para: Carla
        Voto registrado para: Ana

      Resultado da votação:
        Ana: 4 voto(s)
        Bruno: 2 voto(s)
        Carla: 2 voto(s)
        Daniel: 1 voto(s)

      🏆 Vencedora: Ana com 4 votos!*/
      Console.WriteLine();

      // ===================================================
      // EXERCÍCIO 3: Agenda telefônica (nome → telefone)
      // ===================================================
      // 👉 O QUE FAZER:
      // 1. Criar um Dictionary<string, string> para agenda
      // 2. Adicionar contatos (nome e telefone)
      // 3. Buscar telefone de um contato específico
      // 4. Atualizar telefone de um contato existente
      // 5. Remover um contato
      // 6. Exibir todos os contatos
      //
      // 💡 A chave é o nome, o valor é o telefone

      Console.WriteLine("\n📝 Exercício 3: Agenda telefônica");

      // ESCREVA SEU CÓDIGO AQUI



      //Saida esperada:
      /**📝 Exercício 3: Agenda telefônica

      Agenda telefônica:
        Ana Silva → (11) 91234-5678
        Bruno Souza → (21) 98765-4321
        Carla Mendes → (31) 99876-5432
        Daniel Oliveira → (41) 95555-8888

      Buscando telefone de Carla Mendes:
        Telefone: (31) 99876-5432

      Atualizando telefone de Ana Silva...
        Novo telefone: (11) 90000-1111

      Removendo Daniel Oliveira...

      Agenda após alterações:
        Ana Silva → (11) 90000-1111
        Bruno Souza → (21) 98765-4321
        Carla Mendes → (31) 99876-5432*/
      Console.WriteLine();

      // ===================================================
      // EXERCÍCIO 4: Busca segura com TryGetValue()
      // ===================================================
      // 👉 O QUE FAZER:
      // 1. Usar o dicionário de produtos do exercício 1
      // 2. Buscar produtos usando TryGetValue()
      // 3. Tentar buscar produto que existe e outro que não existe
      // 4. Mostrar como TryGetValue evita exceções
      //
      // 💡 TryGetValue() retorna bool e o valor via out parameter
      // 💡 Evita exceção quando a chave não existe

      Console.WriteLine("\n📝 Exercício 4: Busca segura com TryGetValue()");

      // ESCREVA SEU CÓDIGO AQUI



      //Saida esperada:
      /**📝 Exercício 4: Busca segura com TryGetValue()

      Buscando produtos usando TryGetValue():
        ✓ Produto 103 encontrado: Teclado Mecânico
        ✗ Produto 999 não encontrado

      Comparação com acesso direto (perigoso):
        produtos[999] lançaria KeyNotFoundException!*/
      Console.WriteLine();

      // ===================================================
      // EXERCÍCIO 5: Percorrer Keys e Values separadamente
      // ===================================================
      // 👉 O QUE FAZER:
      // 1. Usar a propriedade Keys para percorrer apenas as chaves
      // 2. Usar a propriedade Values para percorrer apenas os valores
      // 3. Percorrer os pares usando KeyValuePair
      // 4. Exibir informações separadas
      //
      // 💡 dicionario.Keys → coleção de chaves
      // 💡 dicionario.Values → coleção de valores

      Console.WriteLine("\n📝 Exercício 5: Percorrer Keys e Values separadamente");

      // ESCREVA SEU CÓDIGO AQUI



      //Saida esperada:
      /**📝 Exercício 5: Percorrer Keys e Values separadamente

      Todas as chaves (códigos de produtos):
        Código: 101
        Código: 102
        Código: 103
        Código: 104
        Código: 105

      Todos os valores (nomes dos produtos):
        Produto: Notebook Dell
        Produto: Mouse Logitech
        Produto: Teclado Mecânico
        Produto: Monitor LG
        Produto: Headset HyperX

      Percorrendo pares (chave + valor):
        101 → Notebook Dell
        102 → Mouse Logitech
        103 → Teclado Mecânico
        104 → Monitor LG
        105 → Headset HyperX*/
      Console.WriteLine();

      // ===================================================
      // RESUMO FINAL
      // ===================================================
      Console.WriteLine("\n📌 Resumo sobre Dictionary<TKey, TValue>:");
      Console.WriteLine("new Dictionary<TKey,TValue>()  → criar dicionário");
      Console.WriteLine("dic[chave] = valor             → adicionar/atualizar");
      Console.WriteLine("dic.Add(chave, valor)          → adicionar (lança erro se existir)");
      Console.WriteLine("dic.ContainsKey(chave)         → verificar se chave existe");
      Console.WriteLine("dic.TryGetValue(chave, out var) → buscar seguro");
      Console.WriteLine("dic.Remove(chave)              → remover item");
      Console.WriteLine("dic.Keys                       → todas as chaves");
      Console.WriteLine("dic.Values                     → todos os valores");
      Console.WriteLine("foreach(KeyValuePair<T,K> item) → percorrer pares");
    }
  }

