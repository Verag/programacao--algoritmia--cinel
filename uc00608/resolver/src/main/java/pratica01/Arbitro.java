package pratica01;

public class Arbitro extends Entidade {

    private String residencia;
    private String classificacao;
    private String profissao;
    private int jogosApitados;

    private double salarioBase;

    private double ajudaCustoAcumulada;

    private static final double AJUDA_CUSTO = 240.57;

    public Arbitro(String nome, String areaGeografica,
                   String contacto, String nif,
                   String residencia, String classificacao,
                   String profissao, int jogosApitados,
                   double salarioBase) {

        super(nome, areaGeografica, contacto, nif);

        this.residencia = residencia;
        this.classificacao = classificacao;
        this.profissao = profissao;
        this.jogosApitados = jogosApitados;
        this.salarioBase = salarioBase;
    }

    @Override
    public double calcularReceitasMensais() {

        ajudaCustoAcumulada = jogosApitados * AJUDA_CUSTO;

        return salarioBase + ajudaCustoAcumulada;
    }

    @Override
    public void imprimirDados() {

        super.imprimirDados();

        System.out.println("Residência: " + residencia);
        System.out.println("Classificação: " + classificacao);
        System.out.println("Profissão: " + profissao);
        System.out.println("Jogos Apitados: " + jogosApitados);

        System.out.println("Receita Mensal: "
                + calcularReceitasMensais());
    }

    public void limparAjudaCusto() {
        ajudaCustoAcumulada = 0;
    }
}
