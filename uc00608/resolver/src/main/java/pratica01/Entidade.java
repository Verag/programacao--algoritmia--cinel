package pratica01;

public abstract class Entidade {

    protected String nome;
    protected String areaGeografica;
    protected String contacto;
    protected String nif;

    public Entidade(String nome, String areaGeografica,
                     String contacto, String nif) {

        this.nome = nome;
        this.areaGeografica = areaGeografica;
        this.contacto = contacto;
        this.nif = nif;
    }

    // método abstrato
    public abstract double calcularReceitasMensais();

    public void imprimirDados() {
        System.out.println("Nome: " + nome);
        System.out.println("Área: " + areaGeografica);
        System.out.println("Contacto: " + contacto);
        System.out.println("NIF: " + nif);
    }
}
