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

    public Clube(String nome, String areaGeografica,
                 String contacto, String nif,
                 String sedeSocial, String presidente,
                 String vocacao,
                 int jogosDisputados,
                 int assistencias) {

        super(nome, areaGeografica, contacto, nif);

        this.sedeSocial = sedeSocial;
        this.presidente = presidente;
        this.vocacao = vocacao;
        this.jogosDisputados = jogosDisputados;
        this.assistencias = assistencias;
    }

    @Override
    public double calcularReceitasMensais() {

        double receitaBilheteira =
                assistencias * PRECO_BILHETE;

        publicidadeAcumulada =
                jogosDisputados * PUBLICIDADE_JOGO;

        return receitaBilheteira + publicidadeAcumulada;
    }

    @Override
    public void imprimirDados() {

        super.imprimirDados();

        System.out.println("Sede: " + sedeSocial);
        System.out.println("Presidente: " + presidente);
        System.out.println("Vocação: " + vocacao);

        System.out.println("Receita Mensal: "
                + calcularReceitasMensais());
    }

    public void limparPublicidade() {
        publicidadeAcumulada = 0;
    }
}
