
package com.example;

public class TestarVeiculo {
    public static void main(String[] args) {

        Veiculo jipe = new Veiculo(
            "Range Rover",
            "XPTO 20",
            2000,
            20000f,
            "Gasóleo",
            240
        );

        Carro bolide = new Carro(
            "Honda",
            "Civic",
            2004,
            15000f,
            "Gasolina",
            200,
            5
        );

        Aviao voar = new Aviao(
            "Boeing",
            "777",
            2004,
            400000f,
            "Jet Fuel",
            950,
            "Fixa"
        );

        Carro favorito = new Carro(
            "Tesla",
            "Model S",
            2022,
            80000f,
            "Elétrico",
            250,
            4
        );

        jipe.mostrarInformacoes();

        bolide.mostrarDadosCarro();

        voar.dados();

        favorito.mostrarDadosCarro();
    }
}