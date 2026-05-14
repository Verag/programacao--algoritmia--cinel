package pratica01;

import java.util.ArrayList;

import java.io.FileWriter;
import java.io.PrintWriter;
import java.io.IOException;

public class GestorEntidades {

    // =========================
    // ARRAY DINÂMICO
    // =========================

    private ArrayList<Entidade> entidades;

    // =========================
    // CONSTRUTOR
    // =========================

    public GestorEntidades() {

        entidades = new ArrayList<>();
    }

    // =========================
    // ADICIONAR ENTIDADE
    // =========================

    public void adicionarEntidade(
            Entidade entidade) {

        if (entidade == null) {

            throw new IllegalArgumentException(
                    "Entidade inválida!"
            );
        }

        entidades.add(entidade);
    }

    // =========================
    // REMOVER ENTIDADE
    // =========================

    public void removerEntidade(
            Entidade entidade) {

        if (!entidades.remove(entidade)) {

            System.out.println(
                    "Entidade não encontrada!"
            );
        }
    }

    // =========================
    // LISTAR ENTIDADES
    // =========================

    public void listarEntidades() {

        if (entidades.isEmpty()) {

            System.out.println(
                    "Não existem entidades registadas."
            );

            return;
        }

        for (Entidade e : entidades) {

            e.imprimirDados();

            System.out.println(
                    "----------------------------"
            );
        }
    }

    // =========================
    // PESQUISAR POR NOME
    // =========================

    public Entidade procurarPorNome(
            String nome) {

        if (nome == null
                || nome.trim().isEmpty()) {

            return null;
        }

        for (Entidade e : entidades) {

            if (e.getNome()
                    .equalsIgnoreCase(
                            nome.trim())) {

                return e;
            }
        }

        return null;
    }

    // =========================
    // TOTAL ENTIDADES
    // =========================

    public int totalEntidades() {

        return entidades.size();
    }

    // =========================
    // EXPORTAR CSV
    // =========================

    public void exportarCSV(
            String nomeFicheiro) {

        try {

            PrintWriter writer =
                    new PrintWriter(
                            new FileWriter(
                                    nomeFicheiro
                            )
                    );

            // cabeçalho

            writer.println(
                    "Nome,Dados,ReceitaMensal"
            );

            // dados

            for (Entidade e : entidades) {

                writer.println(
                        e.toCSV()
                );
            }

            writer.close();

            System.out.println(
                    "CSV exportado com sucesso!"
            );

        } catch (IOException e) {

            System.out.println(
                    "Erro ao exportar CSV: "
                    + e.getMessage()
            );
        }
    }

    // =========================
    // IMPORTAR CSV
    // (base para evolução futura)
    // =========================

    public void importarCSV(
            String nomeFicheiro) {

        System.out.println(
                "Método preparado para futura implementação."
        );
    }

    // =========================
    // LIMPAR ARRAY DINÂMICO
    // =========================

    public void limparEntidades() {

        entidades.clear();

        System.out.println(
                "Todas as entidades foram removidas."
        );
    }

    // =========================
    // GET ARRAYLIST
    // =========================

    public ArrayList<Entidade>
    getEntidades() {

        return entidades;
    }
}