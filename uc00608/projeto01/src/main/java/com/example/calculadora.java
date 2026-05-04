
package com.example;

class Calculadora {

    // Variáveis membro do tipo float
    private float Num1, Num2; // encapsulamento(só aceder dentro da própria classe e não ser modificada por outras classes
    

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
    //boa prática usar o 'this' para referenciar as variáveis membro da classe, evitando confusão com os parâmetros do método
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

