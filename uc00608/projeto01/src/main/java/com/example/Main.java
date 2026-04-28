package com.example;

import javax.swing.JOptionPane;

public class Main {

    public static void main(String[] args) {

        Float valor1 = lerFloat("Introduza o primeiro numero, sff:");
        if (valor1 == null) return; // para terminar quando o utilizador cancela

        Float valor2 = lerFloat("Introduza o segundo numero, sff:");
        if (valor2 == null) return;// para terminar quando o utilizador cancela

        Calculadora calc = new Calculadora();
        calc.setNum1(valor1);
        calc.setNum2(valor2);

        try {
            float soma = calc.Somar();
            float sub = calc.Subtrair();
            float mult = calc.Multiplicar();
            float div = calc.Dividir();

            String resultado = "Soma: " + soma +
                               "\nSubtração: " + sub +
                               "\nMultiplicação: " + mult +
                               "\nDivisão: " + div;

            JOptionPane.showMessageDialog(null, resultado);

        } catch (ArithmeticException e) {
            JOptionPane.showMessageDialog(null, e.getMessage());
        }
    }

    // 🔁 Método reutilizável para ler float com validação
    public static Float lerFloat(String mensagem) {

        while (true) {

            String input = JOptionPane.showInputDialog(mensagem);

            // Cancelar
            if (input == null) {
                JOptionPane.showMessageDialog(null, "Operação cancelada.");
                return null;
            }

            // Campo vazio
            if (input.trim().isEmpty()) {
                JOptionPane.showMessageDialog(null, "Campo vazio! Tente novamente.");
                continue;
            }

            // Número inválido
            try {
                return Float.parseFloat(input);
            } catch (NumberFormatException e) {
                JOptionPane.showMessageDialog(null, "Valor inválido! Introduza um número.");
            }
        }
    }
}