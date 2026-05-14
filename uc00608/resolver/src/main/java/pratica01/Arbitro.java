package pratica01;

public class Arbitro extends Entidade {

    private String residencia;
    private String classificacao;
    private String profissao;

    private int jogosApitados;

    private double salarioBase;

    private double ajudaCustoAcumulada;

    private static final double AJUDA_CUSTO = 240.57;

    public Arbitro(String nome,
                   String areaGeografica,
                   String contacto,
                   String nif,
                   String residencia,
                   String classificacao,
                   String profissao,
                   int jogosApitados,
                   double salarioBase) {

        super(nome,
              areaGeografica,
              contacto,
              nif);

        setResidencia(residencia);
        setClassificacao(classificacao);
        setProfissao(profissao);

        setJogosApitados(
                jogosApitados
        );

        setSalarioBase(salarioBase);
    }

    // =========================
    // CÁLCULO RECEITAS
    // =========================

    @Override
    public double calcularReceitasMensais() {

        ajudaCustoAcumulada =
                jogosApitados
                * AJUDA_CUSTO;

        return salarioBase
                + ajudaCustoAcumulada;
    }

    // =========================
    // IMPRESSÃO
    // =========================

    @Override
    public void imprimirDados() {

        super.imprimirDados();

        System.out.println(
                "Residência: "
                + residencia
        );

        System.out.println(
                "Classificação: "
                + classificacao
        );

        System.out.println(
                "Profissão: "
                + profissao
        );

        System.out.println(
                "Jogos Apitados: "
                + jogosApitados
        );

        System.out.println(
                "Salário Base: "
                + salarioBase
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
               residencia + "," +
               classificacao + "," +
               profissao + "," +
               calcularReceitasMensais();
    }

    // =========================
    // GETTERS
    // =========================

    public String getResidencia() {
        return residencia;
    }

    public String getClassificacao() {
        return classificacao;
    }

    public String getProfissao() {
        return profissao;
    }

    public int getJogosApitados() {
        return jogosApitados;
    }

    public double getSalarioBase() {
        return salarioBase;
    }

    // =========================
    // SETTERS COM VALIDAÇÃO
    // =========================

    public void setResidencia(
            String residencia) {

        if (residencia == null
                || residencia.trim().isEmpty()) {

            throw new IllegalArgumentException(
                    "Residência inválida!"
            );
        }

        this.residencia =
                residencia.trim();
    }

    public void setClassificacao(
            String classificacao) {

        if (classificacao == null
                || classificacao.trim().isEmpty()) {

            throw new IllegalArgumentException(
                    "Classificação inválida!"
            );
        }

        this.classificacao =
                classificacao.trim();
    }

    public void setProfissao(
            String profissao) {

        if (profissao == null
                || profissao.trim().isEmpty()) {

            throw new IllegalArgumentException(
                    "Profissão inválida!"
            );
        }

        this.profissao =
                profissao.trim();
    }

    public void setJogosApitados(
            int jogosApitados) {

        if (jogosApitados < 0) {

            throw new IllegalArgumentException(
                    "Jogos apitados inválidos!"
            );
        }

        this.jogosApitados =
                jogosApitados;
    }

    public void setSalarioBase(
            double salarioBase) {

        if (salarioBase < 0) {

            throw new IllegalArgumentException(
                    "Salário inválido!"
            );
        }

        this.salarioBase =
                salarioBase;
    }

    // =========================
    // MÉTODOS AUXILIARES
    // =========================

    public void limparAjudaCusto() {

        ajudaCustoAcumulada = 0;
    }
}