package pratica02;

import java.util.ArrayList;
import java.util.List;



// ======================= SUBCLASSES =======================

class NaveExploracao extends NaveEspacial {

    public NaveExploracao(String nome) {
        super(nome, 100.0f);
    }

    @Override
    public void viajar(float distancia) {
        System.out.println("A explorar novos sistemas... Consumo moderado.");
        
        if (distancia < 0) distancia = 0;
        
        float consumo = (distancia / 10.0f) * 1.0f; // 1% a cada 10 unidades
        combustivel -= consumo; // Reduz o combustível com base na distância percorrida
        
        if (combustivel < 0) combustivel = 0;
    }
}

class CargueiroIntergalatico extends NaveEspacial {

    public CargueiroIntergalatico(String nome) {
        super(nome, 100.0f);
    }

    @Override
    public void viajar(float distancia) {
        System.out.println("A transportar carga pesada... Consumo elevado!");
        
        if (distancia < 0) distancia = 0;
        
        float consumo = (distancia / 2.0f) * 1.0f; // 1% a cada 2 unidades
        combustivel -= consumo;
        
        if (combustivel < 0) combustivel = 0;
    }
}

class SondaAutonoma extends NaveEspacial {

    public SondaAutonoma(String nome) {
        super(nome, 100.0f);
    }

    @Override
    public void viajar(float distancia) {
        System.out.println("Sonda em modo económico. Longo alcance detectado.");
        
        if (distancia < 0) distancia = 0;
        
        float consumo = (distancia / 50.0f) * 1.0f; // 1% a cada 50 unidades
        combustivel -= consumo;
        
        if (combustivel < 0) combustivel = 0;
    }
}

// ======================= CLASSE PRINCIPAL =======================
public class Main {

    public static void main(String[] args) {
        
        List<NaveEspacial> frota = new ArrayList<>();

       
        frota.add(new NaveExploracao("Explorador Alpha"));
        frota.add(new CargueiroIntergalatico("Cargueiro Beta"));
        frota.add(new SondaAutonoma("Sonda Gamma"));

        System.out.println("=== FROTA DO COMANDO ESTRELAR ===\n");

    
        for (NaveEspacial nave : frota) {
            System.out.println("=== Viagem iniciada ===");
            nave.viajar(120.0f);   // Distância de exemplo
            nave.MostrarStatus();
            System.out.println("----------------------------\n");
        }
    }
}
