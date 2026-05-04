package com.example;

import javax.swing.JOptionPane;

public class Carro extends Veiculo {
    private int Portas; // não acesso direto, necessário usar getter e getter

    public Carro(String Marca, String Modelo, int Ano, float Preco, String Combustivel, int VelocidadeMaxima, int Portas) {
        super(Marca, Modelo, Ano, Preco, Combustivel, VelocidadeMaxima); // super é para aceder À classe veículo
        this.Portas = Portas;
    }

    //Método getter e setter para portas
    public int getPortas() {
        return Portas;
    }

    public void setPortas(int Portas) {
        this.Portas = Portas;
    }

public void mostrarDadosCarro() {

    String info = "Marca: " + getMarca() +
                  "\nModelo: " + getModelo() +
                  "\nAno: " + getAno() +
                  "\nPreço: " + getPreco() +
                  "\nCombustível: " + getCombustivel() +
                  "\nVelocidade Máxima: " + getVelocidadeMaxima() +
                  "\nPortas: " + Portas;

    JOptionPane.showMessageDialog(
        null,
        info,
        "Informações do Carro",
        JOptionPane.INFORMATION_MESSAGE
    );
}
}