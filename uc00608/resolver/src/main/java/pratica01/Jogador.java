package pratica01;

public class Jogador extends Entidade {

    private String paisOrigem;
    private String clube;
    private String posicao;

    private double altura;
    private double peso;

    private int jogosParticipados;
    private int vitorias;

    private double salarioBase;

    private double direitosImagemAcumulados;

    private static final double PREMIO_VITORIA = 650.00;

    public Jogador(String nome,
                   String areaGeografica,
                   String contacto,
                   String nif,
                   String paisOrigem,
                   String clube,
                   String posicao,
                   double altura,
                   double peso,
                   int jogosParticipados,
                   int vitorias,
                   double salarioBase) {

        super(nome, areaGeografica,
              contacto, nif);

        setPaisOrigem(paisOrigem);
        setClube(clube);
        setPosicao(posicao);

        setAltura(altura);
        setPeso(peso);

        setJogosParticipados(
                jogosParticipados
        );

        setVitorias(vitorias);

        setSalarioBase(salarioBase);
    }

    // =========================
    // CÁLCULO RECEITAS
    // =========================

    @Override
    public double calcularReceitasMensais() {

        double premioJogos =
                vitorias * PREMIO_VITORIA;

        direitosImagemAcumulados =
                salarioBase * 0.115;

        return salarioBase
                + premioJogos
                + direitosImagemAcumulados;
    }

    // =========================
    // IMPRESSÃO
    // =========================

    @Override
    public void imprimirDados() {

        super.imprimirDados();

        System.out.println(
                "País: " + paisOrigem
        );

        System.out.println(
                "Clube: " + clube
        );

        System.out.println(
                "Posição: " + posicao
        );

        System.out.println(
                "Altura: " + altura
        );

        System.out.println(
                "Peso: " + peso
        );

        System.out.println(
                "Jogos Participados: "
                + jogosParticipados
        );

        System.out.println(
                "Vitórias: " + vitorias
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
               paisOrigem + "," +
               clube + "," +
               posicao + "," +
               calcularReceitasMensais();
    }

    // =========================
    // GETTERS
    // =========================

    public String getPaisOrigem() {
        return paisOrigem;
    }

    public String getClube() {
        return clube;
    }

    public String getPosicao() {
        return posicao;
    }

    public double getAltura() {
        return altura;
    }

    public double getPeso() {
        return peso;
    }

    public int getJogosParticipados() {
        return jogosParticipados;
    }

    public int getVitorias() {
        return vitorias;
    }

    public double getSalarioBase() {
        return salarioBase;
    }

    // =========================
    // SETTERS COM VALIDAÇÃO
    // =========================

    public void setPaisOrigem(
            String paisOrigem) {

        if (paisOrigem == null
                || paisOrigem.trim().isEmpty()) {

            throw new IllegalArgumentException(
                    "País de origem inválido!"
            );
        }

        this.paisOrigem =
                paisOrigem.trim();
    }

    public void setClube(String clube) {

        if (clube == null
                || clube.trim().isEmpty()) {

            throw new IllegalArgumentException(
                    "Clube inválido!"
            );
        }

        this.clube = clube.trim();
    }

    public void setPosicao(
            String posicao) {

        if (posicao == null
                || posicao.trim().isEmpty()) {

            throw new IllegalArgumentException(
                    "Posição inválida!"
            );
        }

        this.posicao = posicao.trim();
    }

    public void setAltura(double altura) {

        if (altura <= 0
                || altura > 2.60) {

            throw new IllegalArgumentException(
                    "Altura inválida!"
            );
        }

        this.altura = altura;
    }

    public void setPeso(double peso) {

        if (peso <= 0
                || peso > 300) {

            throw new IllegalArgumentException(
                    "Peso inválido!"
            );
        }

        this.peso = peso;
    }

    public void setJogosParticipados(
            int jogosParticipados) {

        if (jogosParticipados < 0) {

            throw new IllegalArgumentException(
                    "Jogos inválidos!"
            );
        }

        this.jogosParticipados =
                jogosParticipados;
    }

    public void setVitorias(
            int vitorias) {

        if (vitorias < 0) {

            throw new IllegalArgumentException(
                    "Vitórias inválidas!"
            );
        }

        if (vitorias > jogosParticipados) {

            throw new IllegalArgumentException(
                    "Vitórias não podem ser superiores aos jogos!"
            );
        }

        this.vitorias = vitorias;
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

    public void limparDireitosImagem() {

        direitosImagemAcumulados = 0;
    }
}