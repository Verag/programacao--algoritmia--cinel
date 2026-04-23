package com.example;

import javax.swing.JOptionPane;

class Aluno {
    String Nome;
    float Nota;

    // o método construtor
    Aluno(String Nome, float Nota) {
        this.Nome = Nome;
        this.Nota = Nota;
    }

    // método para mostrar os dados
    void MostrarDados() {
        JOptionPane.showMessageDialog(null, 
        "Nome:"+Nome+"\n"+"Nota:"+Nota,"Classe Aluno",
        JOptionPane.INFORMATION_MESSAGE);
    }
}

public class Exemplo2 {
    public static void main(String[] args) {
        String Nome=JOptionPane.showInputDialog(null,
        "Digite o nome");
        float Nota=Float.parseFloat(JOptionPane.showInputDialog(null,
        "Digite a nota"));
        Aluno A = new Aluno(Nome, Nota);
        A.MostrarDados();
    }
}
