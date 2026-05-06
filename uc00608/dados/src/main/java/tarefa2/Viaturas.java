package tarefa2;

import java.util.Objects;

public class Viaturas {

    private String marca;
    private String modelo;
    private String matricula;
    private String combustivel;
    private int kilometrosAtuais;
    private float preco;

    // Construtor 
    public Viaturas(String marca, String modelo, String matricula, String combustivel, int kilometrosAtuais, float preco) {
        setMarca(marca);
        setModelo(modelo);
        setMatricula(matricula);
        setCombustivel(combustivel);
        setKilometrosAtuais(kilometrosAtuais);
        setPreco(preco);
    }

    // Getters
    public String getMarca() { return marca; }
    public String getModelo() { return modelo; }
    public String getMatricula() { return matricula; }
    public String getCombustivel() { return combustivel; }
    public int getKilometrosAtuais() { return kilometrosAtuais; }
    public float getPreco() { return preco; }

    // Setters com validação
    public void setMarca(String marca) {
        if (marca == null || marca.isBlank()) {
            throw new IllegalArgumentException("Marca inválida");
        }
        this.marca = marca;
    }

    public void setModelo(String modelo) {
        if (modelo == null || modelo.isBlank()) {
            throw new IllegalArgumentException("Modelo inválido");
        }
        this.modelo = modelo;
    }

    public void setMatricula(String matricula) {
        if (matricula == null || matricula.isBlank()) {
            throw new IllegalArgumentException("Matrícula inválida");
        }
        this.matricula = matricula;
    }

    public void setCombustivel(String combustivel) {
        if (combustivel == null || combustivel.isBlank()) {
            throw new IllegalArgumentException("Combustível inválido");
        }
        this.combustivel = combustivel;
    }

    public void setKilometrosAtuais(int kilometrosAtuais) {
        if (kilometrosAtuais < 0) {
            throw new IllegalArgumentException("Kilómetros não podem ser negativos");
        }
        this.kilometrosAtuais = kilometrosAtuais;
    }

    public void setPreco(float preco) {
        if (preco < 0) {
            throw new IllegalArgumentException("Preço inválido");
        }
        this.preco = preco;
    }

    // equals e hashCode baseados na matrícula (identidade única)
    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (!(o instanceof Viaturas)) return false;
        Viaturas that = (Viaturas) o;
        return Objects.equals(matricula, that.matricula);
    }

    @Override
    public int hashCode() { //objetos iguais tem o mesmo hashcode
        return Objects.hash(matricula);
    }

    // toString para debug/logs
    @Override
    public String toString() {
        return "Viaturas{" +
                "marca='" + marca + '\'' +
                ", modelo='" + modelo + '\'' +
                ", matricula='" + matricula + '\'' +
                ", combustivel='" + combustivel + '\'' +
                ", km=" + kilometrosAtuais +
                ", preco=" + preco +
                '}';
    }
}