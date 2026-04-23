package com.example;

class Pessoa{
    String Nome;
    int Idade;

    void MostarDados(){
        System.out.println("Nome: " + Nome); // + é usado para concatenar strings
        System.out.println("Idade: " + Idade);
    }
}


public class Main {
    public static void main(String[] args) {

        Pessoa p = new Pessoa();
        p.Nome = "Paulo Freitas";
        p.Idade = 30;
        p.MostarDados();

        System.out.println("Hello world!");
    }
}