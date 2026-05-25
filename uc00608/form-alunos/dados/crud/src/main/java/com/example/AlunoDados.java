package com.example;

import java.sql.Connection;
import java.sql.Statement;
import java.sql.ResultSet;
import java.sql.PreparedStatement;
import java.sql.SQLException;
import java.util.List;
import java.util.ArrayList;

public class AlunoDados {
    // método para inserir um novo aluno
    public boolean Inserir(Aluno A){
        String Sql="insert into alunos (nome,email,telefone) values (?,?,?)";
        try(Connection Cn=Ligacao.ObterLigacao();
            PreparedStatement Ps=Cn.prepareStatement(Sql)){
                Ps.setString(1,A.getNome());
                Ps.setString(2,A.getEmail());
                Ps.setString(3,A.getTelefone());
                Ps.executeUpdate();
                return(true);
        }catch(SQLException e){
                System.out.println("Erro ao inserir o aluno!");
                return(false);
        }   
    }
    // método para listar todos os alunos
    public List<Aluno> ListarAlunos(){
        List<Aluno> Lista=new ArrayList<>();
        String Sql="select * from alunos";
        try(Connection Cn=Ligacao.ObterLigacao();
            Statement St=Cn.createStatement();
            ResultSet Rs=St.executeQuery(Sql)){
            while(Rs.next()){
                Aluno A=new Aluno(Rs.getInt("Id"),
                Rs.getString("Nome"),
                Rs.getString("Email"),
                Rs.getString("Telefone"));
                Lista.add(A);
            }    
        }catch(SQLException e){
                System.out.println("Erro ao listar!");     
        }           
        return(Lista);
    }

    // método para localizar o aluno através do Id
    public Aluno PesquisaPorId(int Id){
        String Sql="select * from alunos where id=?";
        try(Connection Cn=Ligacao.ObterLigacao();
            PreparedStatement Ps=Cn.prepareStatement(Sql)){
            Ps.setInt(1,Id);
            ResultSet Rs=Ps.executeQuery();
            if(Rs.next()){
                return new Aluno(Rs.getInt("Id"),
                Rs.getString("Nome"),
                Rs.getString("Email"),
                Rs.getString("Telefone"));
            }    
        }catch(SQLException e){
                System.out.println("Erro ao pesquisar o aluno!");     
        }           
        return(null);
    }

   // método para atualizar o aluno 
    public boolean AtualizarAluno(Aluno A){
        String Sql="update alunos set nome=?, email=?,telefone=? where id=?";
        try(Connection Cn=Ligacao.ObterLigacao();
            PreparedStatement Ps=Cn.prepareStatement(Sql)){
            Ps.setString(1, A.getNome());
            Ps.setString(2, A.getEmail());
            Ps.setString(3, A.getTelefone());
            Ps.setInt(4, A.getId());
            int linhas=Ps.executeUpdate();
            return(linhas>0);
        }catch(SQLException e){
                System.out.println("Erro ao atualizar o aluno!");   
                return(false); 
        }           
    }
    // método para eliminar o aluno
   public boolean EliminarAluno(int Id){
        String Sql="delete from alunos where id=?";
        try(Connection Cn=Ligacao.ObterLigacao();
            PreparedStatement Ps=Cn.prepareStatement(Sql)){
            Ps.setInt(1,Id);
            int linhas=Ps.executeUpdate();
            return(linhas>0);    
            
        }catch(SQLException e){
            System.out.println("Erro ao pesquisar o aluno!");  
            return(false);  
        }           
        
    }
}
