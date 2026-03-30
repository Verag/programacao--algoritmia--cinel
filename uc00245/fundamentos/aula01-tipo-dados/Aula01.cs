using System;

namespace Fundamentos01
{
    public class Aula01
    {
        public void ExecutarAula()
        {
            ExibirCabecalho();

            // Instâncias das outras classes (que devem estar noutros ficheiros)
            VariaveisETiposDeDados variaveis = new VariaveisETiposDeDados();
            variaveis.Executar();
            Console.WriteLine();

            OperadoresAritmeticos operadoresAritmeticos = new OperadoresAritmeticos();
            operadoresAritmeticos.Executar();
            Console.WriteLine();

            OperadoresComparacao operadoresComparacao = new OperadoresComparacao();
            operadoresComparacao.Executar();
            Console.WriteLine();

            OperadoresLogicos operadoresLogicos = new OperadoresLogicos();
            operadoresLogicos.Executar();
            Console.WriteLine();

            ExerciciosVariaveisETiposDeDados exercicios_var = new ExerciciosVariaveisETiposDeDados();
            exercicios_var.Executar();

            AlunoOperadoresLogicos exercicios_logicos = new AlunoOperadoresLogicos();
            exercicios_logicos.Executar();

            // === Estruturas de Controlo ===
            EstruturasControloBasicas estruturas = new EstruturasControloBasicas();
            estruturas.ExecutarIf();
            estruturas.ExecutarSwitchCase();
            estruturas.ExecutarTernario();
            estruturas.ExecutarForWhile();

            Console.WriteLine();
            ResumoAula();
        }

        private void ExibirCabecalho()
        {
            Console.WriteLine("======================================");
            Console.WriteLine(" AULA 01 - FUNDAMENTOS DE ALGORITMIA");
            Console.WriteLine("======================================");
            Console.WriteLine();
        }

        private void ResumoAula()
        {
            Console.WriteLine();
            Console.WriteLine("======================================");
            Console.WriteLine(" FIM DA AULA - RESUMO");
            Console.WriteLine("======================================");
            Console.WriteLine("✓ O que é algoritmia");
            Console.WriteLine("✓ Variáveis e tipos de dados");
            Console.WriteLine("✓ Operadores aritméticos, comparação e lógicos");
            Console.WriteLine("✓ Estruturas de controle básicas (if, switch, ternário, for, while)");
        }
    }
}