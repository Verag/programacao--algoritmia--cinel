package tarefa2;

import java.util.*;

public class Dados {

    // Estruturas mais eficientes
    private Map<String, Viaturas> viaturasMap;

    public Dados() {
        this.viaturasMap = new HashMap<>();
    }

    // 1. Adicionar viatura
    public boolean adicionarViatura(Viaturas v) {
        if (v == null || v.getMatricula() == null) {//verifica se objeto existe e tem matrícula
            throw new IllegalArgumentException("Viatura inválida");
        }

        if (viaturasMap.containsKey(v.getMatricula())) { // verifica se já existe matrícula
            return false; // matrícula já existe
        }

        viaturasMap.put(v.getMatricula(), v); //adiciona a viatura ao mapa usando a matrícula como chave
        return true;
    }

    // 2. Remover viatura
    public boolean removerViatura(String matricula) {
        return viaturasMap.remove(matricula) != null;
    }

    // 3. Listar todas
    public List<Viaturas> listarTodas() {
        return new ArrayList<>(viaturasMap.values());
    }

    // 4. Filtrar por marca
    public List<Viaturas> listarPorMarca(String marca) {
        List<Viaturas> resultado = new ArrayList<>();

        for (Viaturas v : viaturasMap.values()) {
            if (v.getMarca().equalsIgnoreCase(marca)) {
                resultado.add(v);
            }
        }

        return resultado;
    }

    // 5. Total de preços
    public float calcularTotalPrecos() {
        float total = 0;

        for (Viaturas v : viaturasMap.values()) {
            total += v.getPreco();
        }

        return total;
    }
}