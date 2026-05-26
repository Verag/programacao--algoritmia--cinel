package com.example;

public class NotificadorSms implements Notificador {
    private String ApiKey;

    // Método constructor 
    public NotificadorSms(String ApiKey) {
        this.ApiKey = ApiKey;
    }

    // implementar métodos abstractos da interface Notificador
    public void enviar(String Destinatario, String Messagem) {
        if(Messagem.length()>160){
            Messagem = Messagem.substring(beginIndex:0, endIndex: 160); // Trunca a mensagem para 160 caracteres
        }
        System.out.println("SMS para " + Destinatario + " com a mensagem: " + Messagem);

        // invocar o twilio ou nexmo
    }

    public boolean EstaDisponivel() {
        // Simulando que o serviço de SMS está sempre disponível
        return ApiKey != null && !ApiKey.isEmpty();
    }
    
}
