package com.exemplo;

public class AlunosDados {
    
    public boolean Inserir(Aluno A){
        String sql = "INSERT INTO Alunos (nome, email, telefone) VALUES ('"+A.getNome()+"', '"+A.getEmail()+"', '"+A.getTelefone()+"')";
    }
}
