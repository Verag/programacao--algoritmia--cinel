package com.example;

import java.util.ArrayList;
import java.util.List;


public class GestorNotificacoes {
    private List<Notificador> Canais = new ArrayList<>(); //lista do tipo notificador

    public void AdicionarCanal(Notificador N){
        Canais.add(N);
    }

    // enviar por todos os canais disponíveis
    public void NotificarTodos(String Destinatario, String Messagem){
        for (Notificador C: Canais) {
            if (C.EstaDisponivel()) {
                C.enviar(Destinatario, Messagem);
            } else {
                System.out.println("O notificador " + C.getClass().getSimpleName() + " não está disponível.");
            }
        }
    }

    // tenta o 1º canal disponivel e se falhar passa ao seguinte
    public void NotificarPrimeiroDisponivel(String Destinatario, String Messagem){
        for (Notificador C: Canais) {
            if (C.EstaDisponivel()) {
                C.enviar(Destinatario, Messagem);
                return; // sai do método após enviar a notificação

            } else {
                System.out.println("O notificador " + C.getClass().getSimpleName() +
                        " não está disponível. Tentando o próximo canal...");
            }
        }




}
