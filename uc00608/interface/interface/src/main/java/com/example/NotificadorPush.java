package com.example;


public class NotificadorPush implements Notificador {
    private String AppId;

    // Método constructor 
    public NotificadorPush(String AppId) {
        this.AppId = AppId ;
    }

    // implementar métodos abstractos da interface Notificador
    public void enviar(String Destinatario, String Messagem) {
        System.out.println("Push para " + Destinatario + " com a mensagem: " + Messagem);

        // invocar o firebase ou onesignal
    }

    public boolean EstaDisponivel() {
        // Simulando que o serviço de push está sempre disponível
        return AppId != null && !AppId.isEmpty();
    }
    
}