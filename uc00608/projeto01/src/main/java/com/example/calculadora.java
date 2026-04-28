
package com.example;

class Calculadora {

    // Variáveis membro do tipo float
    float Num1, Num2;

    // Getters
    public float getNum1() {
        return Num1;
    }

    public float getNum2() {
        return Num2;
    }

    // Setters
    public void setNum1(float Num1) {
        this.Num1 = Num1;
    }

    public void setNum2(float Num2) {
        this.Num2 = Num2;
    }

    // Métodos
    public float Somar() {
        return Num1 + Num2;
    }

    public float Subtrair() {
        return Num1 - Num2;
    }

    public float Multiplicar() {
        return Num1 * Num2;
    }


    public float Dividir() {
    if (Num2 == 0) {
        throw new ArithmeticException("Erro: divisão por zero!"); //erro matemático
    }
    return Num1 / Num2;
    }
}

