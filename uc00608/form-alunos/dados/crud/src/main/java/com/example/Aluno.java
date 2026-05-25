package com.example;

public class Aluno {
    private int Id;
    private String Nome, Email, Telefone;
    
    public Aluno(int id, String nome, String email, String telefone) {
        Id = id;
        Nome = nome;
        Email = email;
        Telefone = telefone;
    }

    public int getId() {
        return Id;
    }

    public void setId(int id) {
        Id = id;
    }

    public String getNome() {
        return Nome;
    }

    public void setNome(String nome) {
        Nome = nome;
    }

    public String getEmail() {
        return Email;
    }

    public void setEmail(String email) {
        Email = email;
    }

    public String getTelefone() {
        return Telefone;
    }

    public void setTelefone(String telefone) {
        Telefone = telefone;
    }

    public String Registo(){
        return("ID: "+Id+" | Nome: "+Nome+" | Email: "+Email+" | Telefone: "+Telefone);
    }
    

    
}
