package com.example;

public class NotificadorEmail implements Notificador {

    private String ServidorSMTP;

    // Método constructor 
    public NotificadorEmail(String ServidorSMTP) {
        this.ServidorSMTP = ServidorSMTP;
    }


    // implementar métodos abstractos da interface Notificador
    @Override
    public void enviar(String Destinatario, String Messsage) {
        System.out.println("Email para " + Destinatario + " com a mensagem: " + Messsage);

        // invocar o javamail ou send grid
    }

    @Override
    public boolean EstaDisponivel() {
        // Simulando que o serviço de email está sempre disponível
        return true;
    }
}