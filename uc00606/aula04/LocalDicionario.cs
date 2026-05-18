using System;
using System.Collections.Generic;

namespace aula04
{
    public class LocalDicionario
    {
        public void ExecutarDicionario()
        {
            Dictionary<Pessoa, string> agenda = new Dictionary<Pessoa, string>();

            // Adicionar pessoas à agenda
            agenda.Add(new Pessoa("Alice", 30), "123456789");
            agenda.Add(new Pessoa("Bob", 25), "987654321");
            agenda.Add(new Pessoa("Charlie", 35), "555555555");

            // Exibir a agenda
            foreach (var par in agenda)
            {
                Console.WriteLine($"{par.Key} - {par.Value}");
            }

            // Buscar um número de telefone
            Pessoa pessoaBusca = new Pessoa("Bob", 25);
            if (agenda.TryGetValue(pessoaBusca, out string telefone))
            {                Console.WriteLine($"\nNúmero de telefone de {pessoaBusca}: {telefone}");       }
            else
            {
                Console.WriteLine($"\n{pessoaBusca} não encontrado na agenda."); 
            }

            // Adicionar uma nova pessoa duplicada para testar a chave
            try
            {
                agenda.Add(new Pessoa("Alice", 30), "111111111");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("\nErro: Já existe uma pessoa com o mesmo nome e idade na agenda.");  

            } 

            // Remover uma pessoa da agenda
            Pessoa pessoaRemover = new Pessoa("Charlie", 35);
            if (agenda.Remove(pessoaRemover))
            {                
                Console.WriteLine($"\n{pessoaRemover} removido da agenda.");
            }
            else            
            {
                Console.WriteLine($"\n{pessoaRemover} não encontrado para remoção.");
            }

            // Exibir a agenda atualizada com KeyValuePair
            Console.WriteLine("\nAgenda atualizada:");
            foreach (KeyValuePair<Pessoa, string> par in agenda)
            {
                Console.WriteLine($"{par.Key} - {par.Value}"); 
            }


        }
    }
}
