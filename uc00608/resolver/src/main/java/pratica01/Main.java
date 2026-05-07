package pratica01;

public class Main {

    public static void main(String[] args) {

        Arbitro a = new Arbitro(
                "Carlos",
                "Norte",
                "912345678",
                "123456789",
                "Porto",
                "Internacional",
                "Professor",
                4,
                2500
        );

        Clube c = new Clube(
                "FC Exemplo",
                "Norte",
                "222222222",
                "987654321",
                "Porto",
                "João Silva",
                "Geral",
                4,
                50000
        );

        Jogador j = new Jogador(
                "Ronaldo",
                "Sul",
                "933333333",
                "111111111",
                "Portugal",
                "FC Exemplo",
                "Avançado",
                1.87,
                83,
                4,
                3,
                10000
        );

        a.imprimirDados();
        System.out.println();

        c.imprimirDados();
        System.out.println();

        j.imprimirDados();
    }
}