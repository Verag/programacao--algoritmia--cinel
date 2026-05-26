package com.example;

public TestaInterface{

    public static void main(String[] args) {

        GestorNotificacoes G = new GestorNotificacoes();

        G.AdicionarCanal(new NotificadorEmail("smtp.empresa.pt"));
        G.AdicionarCanal(new NotificadorSms("chave-api-twilio"));
        G.AdicionarCanal(new NotificadorPush("id-app-firebase"));

        // todos os canais
        G.NotificarTodos("utilizador@gmail.com", "Alerta servidor em baixo.");

        // notificar com tentativa
        G.NotificarPrimeiroDisponivel("utilizador@gmail.com", "Alerta servidor em baixo.");

    }



}

