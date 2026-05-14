package pratica01;

import javax.swing.*;

public class Main {

    public static void main(String[] args) {

        GestorEntidades gestor =
                new GestorEntidades();

        boolean continuar = true;

        while (continuar) {

            String[] menu = {
                    "Adicionar",
                    "Ver Dados",
                    "Apagar",
                    "Exportar CSV",
                    "Sair"
            };

            String opcao = (String)
                    JOptionPane.showInputDialog(
                            null,
                            "Escolha uma opção:",
                            "Gestão de Entidades",
                            JOptionPane.QUESTION_MESSAGE,
                            null,
                            menu,
                            menu[0]
                    );

            if (opcao == null) break;

            // =========================
            // ADICIONAR
            // =========================

            if (opcao.equals("Adicionar")) {

                String[] tipos = {
                        "Árbitro",
                        "Clube",
                        "Jogador"
                };

                String tipo = (String)
                        JOptionPane.showInputDialog(
                                null,
                                "Tipo de entidade:",
                                "Adicionar",
                                JOptionPane.QUESTION_MESSAGE,
                                null,
                                tipos,
                                tipos[0]
                        );

                if (tipo == null) continue;

                // =====================================================
                // ÁRBITRO
                // =====================================================

                if (tipo.equals("Árbitro")) {

                    while (true) {

                        try {

                            JTextField nome = new JTextField();
                            JTextField area = new JTextField();
                            JTextField contacto = new JTextField();
                            JTextField nif = new JTextField();
                            JTextField residencia = new JTextField();
                            JTextField classificacao = new JTextField();
                            JTextField profissao = new JTextField();
                            JTextField jogos = new JTextField();
                            JTextField salario = new JTextField();

                            Object[] form = {
                                    "Nome:", nome,
                                    "Área:", area,
                                    "Contacto:", contacto,
                                    "NIF:", nif,
                                    "Residência:", residencia,
                                    "Classificação:", classificacao,
                                    "Profissão:", profissao,
                                    "Jogos Apitados:", jogos,
                                    "Salário Base:", salario
                            };

                            int ok = JOptionPane.showConfirmDialog(
                                    null,
                                    form,
                                    "Criar Árbitro",
                                    JOptionPane.OK_CANCEL_OPTION
                            );

                            if (ok != JOptionPane.OK_OPTION) break;

                            Arbitro a = new Arbitro(
                                    nome.getText(),
                                    area.getText(),
                                    contacto.getText(),
                                    nif.getText(),
                                    residencia.getText(),
                                    classificacao.getText(),
                                    profissao.getText(),
                                    Integer.parseInt(jogos.getText()),
                                    Double.parseDouble(salario.getText())
                            );

                            gestor.adicionarEntidade(a);

                            JOptionPane.showMessageDialog(
                                    null,
                                    "Árbitro criado com sucesso!"
                            );

                            break;

                        } catch (NumberFormatException e) {

                            JOptionPane.showMessageDialog(
                                    null,
                                    "Erro: valores numéricos inválidos!"
                            );

                        } catch (IllegalArgumentException e) {

                            JOptionPane.showMessageDialog(
                                    null,
                                    e.getMessage()
                            );
                        }
                    }
                }

                // =====================================================
                // CLUBE
                // =====================================================

                else if (tipo.equals("Clube")) {

                    while (true) {

                        try {

                            JTextField nome = new JTextField();
                            JTextField area = new JTextField();
                            JTextField contacto = new JTextField();
                            JTextField nif = new JTextField();
                            JTextField sede = new JTextField();
                            JTextField presidente = new JTextField();
                            JTextField vocacao = new JTextField();
                            JTextField jogos = new JTextField();
                            JTextField assistencias = new JTextField();

                            Object[] form = {
                                    "Nome:", nome,
                                    "Área:", area,
                                    "Contacto:", contacto,
                                    "NIF:", nif,
                                    "Sede Social:", sede,
                                    "Presidente:", presidente,
                                    "Vocação:", vocacao,
                                    "Jogos Disputados:", jogos,
                                    "Assistências:", assistencias
                            };

                            int ok = JOptionPane.showConfirmDialog(
                                    null,
                                    form,
                                    "Criar Clube",
                                    JOptionPane.OK_CANCEL_OPTION
                            );

                            if (ok != JOptionPane.OK_OPTION) break;

                            Clube c = new Clube(
                                    nome.getText(),
                                    area.getText(),
                                    contacto.getText(),
                                    nif.getText(),
                                    sede.getText(),
                                    presidente.getText(),
                                    vocacao.getText(),
                                    Integer.parseInt(jogos.getText()),
                                    Integer.parseInt(assistencias.getText())
                            );

                            gestor.adicionarEntidade(c);

                            JOptionPane.showMessageDialog(
                                    null,
                                    "Clube criado com sucesso!"
                            );

                            break;

                        } catch (NumberFormatException e) {

                            JOptionPane.showMessageDialog(
                                    null,
                                    "Erro: números inválidos!"
                            );

                        } catch (IllegalArgumentException e) {

                            JOptionPane.showMessageDialog(
                                    null,
                                    e.getMessage()
                            );
                        }
                    }
                }

                // =====================================================
                // JOGADOR
                // =====================================================

                else if (tipo.equals("Jogador")) {

                    while (true) {

                        try {

                            JTextField nome = new JTextField();
                            JTextField area = new JTextField();
                            JTextField contacto = new JTextField();
                            JTextField nif = new JTextField();
                            JTextField pais = new JTextField();
                            JTextField clube = new JTextField();
                            JTextField posicao = new JTextField();
                            JTextField altura = new JTextField();
                            JTextField peso = new JTextField();
                            JTextField jogos = new JTextField();
                            JTextField vitorias = new JTextField();
                            JTextField salario = new JTextField();

                            Object[] form = {
                                    "Nome:", nome,
                                    "Área:", area,
                                    "Contacto:", contacto,
                                    "NIF:", nif,
                                    "País Origem:", pais,
                                    "Clube:", clube,
                                    "Posição:", posicao,
                                    "Altura (cm):", altura,
                                    "Peso (kg):", peso,
                                    "Jogos Participados:", jogos,
                                    "Vitórias:", vitorias,
                                    "Salário Base:", salario
                            };

                            int ok = JOptionPane.showConfirmDialog(
                                    null,
                                    form,
                                    "Criar Jogador",
                                    JOptionPane.OK_CANCEL_OPTION
                            );

                            if (ok != JOptionPane.OK_OPTION) break;

                            Jogador j = new Jogador(
                                    nome.getText(),
                                    area.getText(),
                                    contacto.getText(),
                                    nif.getText(),
                                    pais.getText(),
                                    clube.getText(),
                                    posicao.getText(),
                                    Double.parseDouble(altura.getText()),
                                    Double.parseDouble(peso.getText()),
                                    Integer.parseInt(jogos.getText()),
                                    Integer.parseInt(vitorias.getText()),
                                    Double.parseDouble(salario.getText())
                            );

                            gestor.adicionarEntidade(j);

                            JOptionPane.showMessageDialog(
                                    null,
                                    "Jogador criado com sucesso!"
                            );

                            break;

                        } catch (NumberFormatException e) {

                            JOptionPane.showMessageDialog(
                                    null,
                                    "Erro: valores numéricos inválidos!"
                            );

                        } catch (IllegalArgumentException e) {

                            JOptionPane.showMessageDialog(
                                    null,
                                    e.getMessage()
                            );
                        }
                    }
                }
            }

            // =========================
            // VER DADOS
            // =========================

            else if (opcao.equals("Ver Dados")) {

                StringBuilder sb = new StringBuilder();

                for (Entidade e : gestor.getEntidades()) {
                    sb.append(e.toCSV()).append("\n");
                }

                JOptionPane.showMessageDialog(
                        null,
                        sb.length() == 0 ? "Sem dados." : sb.toString()
                );
            }

            // =========================
            // APAGAR
            // =========================

            else if (opcao.equals("Apagar")) {

                String nome =
                        JOptionPane.showInputDialog(
                                "Nome a apagar:"
                        );

                Entidade e =
                        gestor.procurarPorNome(nome);

                if (e != null) {

                    gestor.removerEntidade(e);

                    JOptionPane.showMessageDialog(
                            null,
                            "Removido!"
                    );
                } else {

                    JOptionPane.showMessageDialog(
                            null,
                            "Não encontrado!"
                    );
                }
            }

            // =========================
            // EXPORTAR CSV
            // =========================

            else if (opcao.equals("Exportar CSV")) {

                gestor.exportarCSV("entidades.csv");

                JOptionPane.showMessageDialog(
                        null,
                        "Exportado com sucesso!"
                );
            }

            // =========================
            // SAIR
            // =========================

            else if (opcao.equals("Sair")) {

                continuar = false;
            }
        }
    }
}