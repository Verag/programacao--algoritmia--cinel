package tarefa2;

import javax.swing.JOptionPane;

public class TestarViaturas {

    public static void main(String[] args) {

        Dados dados = new Dados();

        while (true) {

            String opcao = JOptionPane.showInputDialog(
                    "MENU\n" +
                    "1 - Adicionar viatura\n" +
                    "2 - Remover viatura\n" +
                    "3 - Mostrar todas\n" +
                    "4 - Mostrar por marca\n" +
                    "5 - Mostrar total de preços\n" +
                    "0 - Sair"
            );

            if (opcao == null || opcao.equals("0")) {
                JOptionPane.showMessageDialog(null, "Programa terminado.");
                break;
            }

            switch (opcao) {

                case "1":
                    adicionarViatura(dados);
                    break;

                case "2":
                    removerViatura(dados);
                    break;

                case "3":
                    mostrarLista(dados);
                    break;

                case "4":
                    mostrarPorMarca(dados);
                    break;

                case "5":
                    mostrarTotal(dados);
                    break;

                default:
                    JOptionPane.showMessageDialog(null, "Opção inválida!");
            }
        }
    }


    //funções auxiliares para ler dados do utilizador com validação
    private static int lerInt(String mensagem) {
        while (true) {
            try {
                return Integer.parseInt(JOptionPane.showInputDialog(mensagem));
            } catch (Exception e) {
                JOptionPane.showMessageDialog(null, "Valor inválido! Introduz um número inteiro.");
            }
        }
    }

    private static float lerFloat(String mensagem) {
        while (true) {
            try {
                return Float.parseFloat(JOptionPane.showInputDialog(mensagem));
            } catch (Exception e) {
                JOptionPane.showMessageDialog(null, "Valor inválido! Introduz um número.");
            }
        }
    }

    private static String lerTexto(String mensagem) {
        String input;
        do {
            input = JOptionPane.showInputDialog(mensagem);
        } while (input == null || input.isBlank());

        return input;
    }

    // ----------------- OPERAÇÕES -----------------

    private static void adicionarViatura(Dados dados) {

        String marca = lerTexto("Marca:");
        String modelo = lerTexto("Modelo:");
        String matricula = lerTexto("Matrícula:");
        String combustivel = lerTexto("Combustível:");
        int km = lerInt("Kilómetros:");
        float preco = lerFloat("Preço:");

        Viaturas v = new Viaturas(marca, modelo, matricula, combustivel, km, preco);

        if (dados.adicionarViatura(v)) { // método retorna true se a adição foi bem-sucedida, false se a matrícula já existe
            JOptionPane.showMessageDialog(null, "Viatura adicionada com sucesso!");
        } else {
            JOptionPane.showMessageDialog(null, "Erro: matrícula já existe!");
        }
    }

    private static void removerViatura(Dados dados) {

        String matricula = lerTexto("Matrícula a remover:");

        if (dados.removerViatura(matricula)) {
            JOptionPane.showMessageDialog(null, "Removida com sucesso!");
        } else {
            JOptionPane.showMessageDialog(null, "Viatura não encontrada!");
        }
    }

    /**
     * @param dados
     */
    private static void mostrarLista(Dados dados) {

        var lista = dados.listarTodas();

        if (lista.isEmpty()) {
            JOptionPane.showMessageDialog(null, "Não existem viaturas.");
            return;
        }

        StringBuilder sb = new StringBuilder(); //string editável (ver alternativas, tabela, maybe??)

        for (Viaturas v : lista) {
            sb.append(v).append("\n");
        }

        JOptionPane.showMessageDialog(null, sb.toString());
    }

    private static void mostrarPorMarca(Dados dados) {

        String marca = lerTexto("Marca:");

        var lista = dados.listarPorMarca(marca);

        if (lista.isEmpty()) {
            JOptionPane.showMessageDialog(null, "Nenhuma viatura encontrada.");
            return;
        }

        StringBuilder sb = new StringBuilder();

        for (Viaturas v : lista) {
            sb.append(v).append("\n");
        }

        JOptionPane.showMessageDialog(null, sb.toString());
    }

    private static void mostrarTotal(Dados dados) {

        float total = dados.calcularTotalPrecos();

        JOptionPane.showMessageDialog(null, "Total de preços: " + total + "€");
    }
}