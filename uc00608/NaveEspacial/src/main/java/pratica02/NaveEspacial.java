package pratica02;

public abstract class NaveEspacial {

    protected String nome;
    protected float combustivel; 

    public NaveEspacial(String nome, float combustivelInicial) {
        this.nome = nome;
        this.combustivel = Math.max(0.0f, Math.min(100.0f, combustivelInicial)); // 0 a 100%
    }

    public void MostrarStatus() {
        System.out.printf("Nave: %s | Combustível: %.2f%%\n", nome, combustivel);
    }

    public abstract void viajar(float distancia);
}
