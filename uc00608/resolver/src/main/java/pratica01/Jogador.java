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

    public Jogador(String nome, String areaGeografica,
                   String contacto, String nif,
                   String paisOrigem, String clube,
                   String posicao,
                   double altura, double peso,
                   int jogosParticipados,
                   int vitorias,
                   double salarioBase) {

        super(nome, areaGeografica, contacto, nif);

        this.paisOrigem = paisOrigem;
        this.clube = clube;
        this.posicao = posicao;

        this.altura = altura;
        this.peso = peso;

        this.jogosParticipados = jogosParticipados;
        this.vitorias = vitorias;

        this.salarioBase = salarioBase;
    }

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

    @Override
    public void imprimirDados() {

        super.imprimirDados();

        System.out.println("País: " + paisOrigem);
        System.out.println("Clube: " + clube);
        System.out.println("Posição: " + posicao);

        System.out.println("Receita Mensal: "
                + calcularReceitasMensais());
    }

    public void limparDireitosImagem() {
        direitosImagemAcumulados = 0;
    }
}
