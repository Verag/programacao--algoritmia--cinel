package com.example;

import javax.swing.JOptionPane;

public class Veiculo{

    //Atributos
    private String Marca, Modelo, Combustivel;
    private int Ano, VelocidadeMaxima;
    private float Preco;

    //Constructor
    public Veiculo(String Marca, String Modelo, int Ano, float Preco, String Combustivel, int VelocidadeMaxima){
        this.Marca=Marca;
        this.Modelo=Modelo;
        this.Ano=Ano;
        this.Preco=Preco;
        this.Combustivel=Combustivel;
        this.VelocidadeMaxima=VelocidadeMaxima;
    }

    // Métodos getter e setter para cada um dos atributos
    public String getMarca() {
        return Marca;
    }

    public void setMarca(String Marca) {
        this.Marca = Marca;
    }

    public String getModelo() {
        return Modelo;
    }

    public void setModelo(String Modelo) {
        this.Modelo = Modelo;
    }

    public int getAno() {
        return Ano; 
    }

    public void setAno(int Ano) {
        this.Ano = Ano;
    }

    public float getPreco() {
        return Preco;
    }
    public void setPreco(float Preco) {
        this.Preco = Preco;
    }

    public String getCombustivel() {
        return Combustivel;
    }
    public void setCombustivel(String Combustivel) {
        this.Combustivel = Combustivel; 
    }

    public int getVelocidadeMaxima() {
        return VelocidadeMaxima;
    }
    public void setVelocidadeMaxima(int VelocidadeMaxima) {
        this.VelocidadeMaxima = VelocidadeMaxima;
    }

    // Método para mostrar as informações do veículo num relatório
    public void mostrarInformacoes() {
        String info = "Marca: " + Marca +
                      "\nModelo: " + Modelo +
                      "\nAno: " + Ano +
                      "\nPreço: " + Preco +
                      "\nCombustível: " + Combustivel +
                      "\nVelocidade Máxima: " + VelocidadeMaxima + " km/h";

        JOptionPane.showMessageDialog(null, info, "Informações do Veículo", JOptionPane.INFORMATION_MESSAGE);

        







    }




}
