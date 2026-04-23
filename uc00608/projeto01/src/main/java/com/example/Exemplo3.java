package com.example;

import javax.swing.JOptionPane;

class Conta {
    // encapsulamento
    private float Saldo;

    // criar o getter para o Saldo
    public float getSaldo() {
        return (Saldo);
    }

    // criar o setter para o Saldo
    public void setSaldo(float Saldo) {
        this.Saldo = Saldo;
    }

    // criar um método para depositar
    public void Depositar(float Valor) {
        Saldo += Valor;
    }

    // criar um método para levantamento
    public void Levantamento(float Valor) {
        if (Valor <= Saldo) {
            Saldo -= Valor;
        } else {
            JOptionPane.showMessageDialog(null, "Saldo:" +
                    Saldo, "Classe Conta Bancária", JOptionPane.ERROR_MESSAGE);
        }
    }
}

public class Exemplo3 {
    public static void main(String[] args) {
        Conta C = new Conta();
        C.Depositar(Integer.parseInt(JOptionPane.showInputDialog(null,
                "Digite o valor a depositar")));

        JOptionPane.showMessageDialog(null, "Saldo:" +
                C.getSaldo(), "Classe Conta Bancária", JOptionPane.INFORMATION_MESSAGE);

        C.Levantamento(Integer.parseInt(JOptionPane.showInputDialog(null,
                "Digite o valor a levantar")));

        JOptionPane.showMessageDialog(null, "Saldo:" +
                C.getSaldo(), "Classe Conta Bancária", JOptionPane.INFORMATION_MESSAGE);
    }
}

