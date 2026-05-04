
package com.example;

import javax.swing.JOptionPane;

public class Aviao extends Veiculo {
    private String TipodeAsa;

    // Construtor
    public Aviao(String Marca, String Modelo, int Ano, float Preco, String Combustivel, int VelocidadeMaxima, String TipodeAsa) {
        super(Marca, Modelo, Ano, Preco, Combustivel, VelocidadeMaxima);
        this.TipodeAsa = TipodeAsa;
    }

    // Getter
    public String getTipodeAsa() {
        return TipodeAsa;
    }

    // Setter
    public void setTipodeAsa(String TipodeAsa) {
        this.TipodeAsa = TipodeAsa;
    }

    public void dados() {

        String info = "Marca: " + getMarca() +
                    "\nModelo: " + getModelo() +
                    "\nAno: " + getAno() +
                    "\nPreço: " + getPreco() +
                    "\nCombustível: " + getCombustivel() +
                    "\nVelocidade Máxima: " + getVelocidadeMaxima() +
                    "\nTipo de Asa: " + TipodeAsa;

        JOptionPane.showMessageDialog(
            null,
            info,
            "Informações do Avião",
            JOptionPane.INFORMATION_MESSAGE
        );
    }
}