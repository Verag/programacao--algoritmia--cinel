package pratica01;

public abstract class Entidade {

    protected String nome;
    protected String areaGeografica;
    protected String contacto;

    // nif imutável
    protected final String nif;

    public Entidade(String nome,
                     String areaGeografica,
                     String contacto,
                     String nif) {

        setNome(nome);
        setAreaGeografica(areaGeografica);
        setContacto(contacto);

        // validação completa do nif
        if (validarNif(nif)) {

            this.nif = nif;

        } else {

            throw new IllegalArgumentException(
                    "NIF inválido!"
            );
        }
    }

    //métodos abstratos para implementação nas subclasses

    public abstract double calcularReceitasMensais();

    public abstract String toCSV();

    //imprimir os dados

    public void imprimirDados() {

        System.out.println("Nome: " + nome);
        System.out.println("Área: " + areaGeografica);
        System.out.println("Contacto: " + contacto);
        System.out.println("NIF: " + nif);
    }

    
    // getters
    

    public String getNome() {
        return nome;
    }

    public String getAreaGeografica() {
        return areaGeografica;
    }

    public String getContacto() {
        return contacto;
    }

    public String getNif() {
        return nif;
    }

   
    // setters com validação
    

    public void setNome(String nome) {

        if (nome == null
                || nome.trim().isEmpty()) {

            throw new IllegalArgumentException(
                    "Nome inválido!"
            );
        }

        this.nome = nome.trim();
    }

    public void setAreaGeografica(
            String areaGeografica) {

        if (areaGeografica == null
                || areaGeografica.trim().isEmpty()) {

            throw new IllegalArgumentException(
                    "Área geográfica inválida!"
            );
        }

        this.areaGeografica =
                areaGeografica.trim();
    }

    public void setContacto(String contacto) {

        if (contacto == null
                || contacto.trim().isEmpty()) {

            throw new IllegalArgumentException(
                    "Contacto inválido!"
            );
        }

        this.contacto = contacto.trim();
    }

    // NIF é imutável, não tem setter
    
    private boolean validarNif(String nif) { // validação do nif

        if (nif == null) {
            return false;
        }

        String nifLimpo = nif.trim();

        if (!nifLimpo.matches("\\d{9}")) {
            return false;
        }

        char primeiroDigito =
                nifLimpo.charAt(0);

        if ("1256789".indexOf(
                primeiroDigito) == -1) {

            return false;
        }

        int soma = 0;
        for (int i = 0; i < 8; i++) {

            int digito =
                    Character.getNumericValue(
                            nifLimpo.charAt(i)
                    );

            soma += digito * (9 - i);
        }

        int resto = soma % 11;
        int digitoControlo;

        if (resto < 2) {

            digitoControlo = 0;

        } else {

            digitoControlo = 11 - resto;
        }

        int ultimoDigito =
                Character.getNumericValue(
                        nifLimpo.charAt(8)
                );

        return digitoControlo ==
                ultimoDigito;
    }
}
