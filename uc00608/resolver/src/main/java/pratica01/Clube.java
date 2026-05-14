package pratica01;

public class Clube extends Entidade {

    private String sedeSocial;
    private String presidente;
    private String vocacao;

    private int jogosDisputados;
    private int assistencias;

    private double publicidadeAcumulada;

    private static final double PRECO_BILHETE = 12.50;
    private static final double PUBLICIDADE_JOGO = 120000.00;

    public Clube(String nome,
                 String areaGeografica,
                 String contacto,
                 String nif,
                 String sedeSocial,
                 String presidente,
                 String vocacao,
                 int jogosDisputados,
                 int assistencias) {

        super(nome,
              areaGeografica,
              contacto,
              nif);

        setSedeSocial(sedeSocial);
        setPresidente(presidente);
        setVocacao(vocacao);

        setJogosDisputados(
                jogosDisputados
        );

        setAssistencias(assistencias);
    }

    // =========================
    // CÁLCULO RECEITAS
    // =========================

    @Override
    public double calcularReceitasMensais() {

        double receitaBilheteira =
                assistencias * PRECO_BILHETE;

        publicidadeAcumulada =
                jogosDisputados
                * PUBLICIDADE_JOGO;

        return receitaBilheteira
                + publicidadeAcumulada;
    }

    // =========================
    // IMPRESSÃO
    // =========================

    @Override
    public void imprimirDados() {

        super.imprimirDados();

        System.out.println(
                "Sede Social: "
                + sedeSocial
        );

        System.out.println(
                "Presidente: "
                + presidente
        );

        System.out.println(
                "Vocação: "
                + vocacao
        );

        System.out.println(
                "Jogos Disputados: "
                + jogosDisputados
        );

        System.out.println(
                "Assistências: "
                + assistencias
        );

        System.out.println(
                "Receita Mensal: "
                + calcularReceitasMensais()
        );
    }

    // =========================
    // EXPORTAÇÃO CSV
    // =========================

    @Override
    public String toCSV() {

        return nome + "," +
               sedeSocial + "," +
               presidente + "," +
               vocacao + "," +
               calcularReceitasMensais();
    }

    // =========================
    // GETTERS
    // =========================

    public String getSedeSocial() {
        return sedeSocial;
    }

    public String getPresidente() {
        return presidente;
    }

    public String getVocacao() {
        return vocacao;
    }

    public int getJogosDisputados() {
        return jogosDisputados;
    }

    public int getAssistencias() {
        return assistencias;
    }

    // =========================
    // SETTERS COM VALIDAÇÃO
    // =========================

    public void setSedeSocial(
            String sedeSocial) {

        if (sedeSocial == null
                || sedeSocial.trim().isEmpty()) {

            throw new IllegalArgumentException(
                    "Sede social inválida!"
            );
        }

        this.sedeSocial =
                sedeSocial.trim();
    }

    public void setPresidente(
            String presidente) {

        if (presidente == null
                || presidente.trim().isEmpty()) {

            throw new IllegalArgumentException(
                    "Presidente inválido!"
            );
        }

        this.presidente =
                presidente.trim();
    }

    public void setVocacao(
            String vocacao) {

        if (vocacao == null
                || vocacao.trim().isEmpty()) {

            throw new IllegalArgumentException(
                    "Vocação inválida!"
            );
        }

        this.vocacao =
                vocacao.trim();
    }

    public void setJogosDisputados(
            int jogosDisputados) {

        if (jogosDisputados < 0) {

            throw new IllegalArgumentException(
                    "Jogos disputados inválidos!"
            );
        }

        this.jogosDisputados =
                jogosDisputados;
    }

    public void setAssistencias(
            int assistencias) {

        if (assistencias < 0) {

            throw new IllegalArgumentException(
                    "Assistências inválidas!"
            );
        }

        this.assistencias =
                assistencias;
    }

    // =========================
    // MÉTODOS AUXILIARES
    // =========================

    public void limparPublicidade() {

        publicidadeAcumulada = 0;
    }
}