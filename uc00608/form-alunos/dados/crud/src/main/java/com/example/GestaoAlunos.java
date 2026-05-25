package com.example;

import javax.swing.JOptionPane;
import javax.swing.JScrollPane;
import javax.swing.JTextArea;

import java.util.List;

public class GestaoAlunos {
    private static final AlunoDados Al = new AlunoDados();

    public static void main(String[] args) {
        String[] Opcoes={"Inserir","Listar","Pesquisar","Atualizar","Eliminar","Sair"};
        boolean Continuar=true;
        while(Continuar){
            int Escolha=JOptionPane.showOptionDialog(null, "Selecione uma opção", "CRUD - Alunos", JOptionPane.OK_CANCEL_OPTION, JOptionPane.PLAIN_MESSAGE, null, Opcoes, Opcoes[0]);

            switch(Escolha){
                case 0-> inserirAluno();
                case 1-> listarAlunos();
                case 2-> pesquisarAluno();
                case 3-> atualizarAluno();
                case 4-> eliminarAluno();
                default-> Continuar=false;
            }

        }

    }
    private static void inserirAluno(){
        String Nome=JOptionPane.showInputDialog(null,"Nome:","Inserir Aluno - Nome",JOptionPane.PLAIN_MESSAGE);
        if(Nome==null || Nome.isBlank()){
            MostraAviso("Nome não pode estar em branco!");
            return;
        }
        String Email=JOptionPane.showInputDialog(null,"Email:","Inserir Aluno - Email",JOptionPane.PLAIN_MESSAGE);
        if(Email==null || Email.isBlank()){
            MostraAviso("Email não pode estar em branco!");
            return;
        }   
        String Telefone=JOptionPane.showInputDialog(null,"Telefone:","Inserir Aluno - Telefone",JOptionPane.PLAIN_MESSAGE);
        if(Telefone==null || Telefone.isBlank()){
            MostraAviso("Telefone não pode estar em branco!");
            return;
        }    
        
        Aluno A=new Aluno(0,Nome.trim(),Email.trim(),Telefone.trim());
        boolean Ok=Al.Inserir(A);
        if(Ok){
            MostraAviso("Aluno inserido!\nNome: "+Nome+"\nEmail: "+Email+"\nTelefone: "+Telefone);
        }
        else{
            MostraErro("Erro ao inserir o aluno!");
        }

    }
    private static void listarAlunos(){
        List<Aluno> Lista=Al.ListarAlunos();
        if(Lista.isEmpty()){
            MostraErro("Lista vazia!");
            return;
        }
        StringBuilder Sb=new StringBuilder();
        Sb.append(String.format("%-5s %-30s %-25s %-15s%n", "Id","Nome","Email","Telefone"));
        Sb.append("-".repeat(70)).append("\n");

        for(Aluno A : Lista){
            Sb.append(String.format("%-5d %-30s %-25s %-15s%n",
            A.getId(),A.getNome(),A.getEmail(),A.getTelefone()));
        }


        JTextArea textArea=new JTextArea(Sb.toString());
        textArea.setFont(new java.awt.Font("Monospaced",java.awt.Font.PLAIN,12));
        textArea.setEditable(false);
        textArea.setBackground(null);
        JScrollPane scroll=new JScrollPane(textArea);
        scroll.setPreferredSize(new java.awt.Dimension(620,300));
        JOptionPane.showMessageDialog(null, scroll,"Lista de alunos ("+Lista.size()+" registo(s)",JOptionPane.PLAIN_MESSAGE);
    } 
    private static void pesquisarAluno(){
        String IdStr=JOptionPane.showInputDialog(null,"Insira o nÃºmero de aluno a pesquisar","Pesquisar aluno",
        JOptionPane.PLAIN_MESSAGE);

        if(IdStr==null) return;

        try{
            int Id=Integer.parseInt(IdStr);
            Aluno A=Al.PesquisaPorId(Id);
            if(A !=null){
                JOptionPane.showMessageDialog(null, "Dados do aluno\n"+"Id:"+A.getId()+"\nNome:"+A.getNome()+"\nEmail:"+A.getEmail()+"\nTelefone:"+A.getTelefone(),"Pesquisar aluno",JOptionPane.INFORMATION_MESSAGE);

            }
            else{
                MostraAviso("Id não existe!");
            }
        }
        catch(NumberFormatException e){
            MostraErro("Id inválido!");
        }
    }   
    private static void atualizarAluno(){
        String IdStr=JOptionPane.showInputDialog(null,"Insira o número de aluno a alterar","Alterar aluno",
        JOptionPane.PLAIN_MESSAGE);

        if(IdStr==null) return;  
        
        try {
            int Id=Integer.parseInt(IdStr);
            Aluno Existe=Al.PesquisaPorId(Id);
            if(Existe==null) {
                MostraAviso("Id de aluno não existe.");
                return;
            } 

            String Nome=JOptionPane.showInputDialog(null,"\nAtualizar para: ","Nome atual:"+Existe.getNome(),JOptionPane.INFORMATION_MESSAGE);

            if(Nome==null || Nome.isBlank()) Nome=Existe.getNome();

            String Email=JOptionPane.showInputDialog(null,"\nAtualizar para: ","Email atual:"+Existe.getEmail(),JOptionPane.INFORMATION_MESSAGE);

            if(Email==null || Email.isBlank()) Email=Existe.getEmail();
            
            String Telefone=JOptionPane.showInputDialog(null,"\nAtualizar para: ","Telefone atual:"+Existe.getTelefone(),JOptionPane.INFORMATION_MESSAGE);

            if(Telefone==null || Telefone.isBlank()) Telefone=Existe.getTelefone();            
            
            Aluno AlunoAtualizado=new Aluno(Id, Nome, Email, Telefone);
            boolean Ok=Al.AtualizarAluno(AlunoAtualizado);
            if(Ok){
                JOptionPane.showMessageDialog(null, 
                "Aluno atualizado\n\n"+
                "Id:"+Id+
                "\nNome:"+Nome+
                "\nEmail:"+Email+
                "\nTelefone:"+Telefone,"atualizar aluno",JOptionPane.INFORMATION_MESSAGE);
            }
            else{
                MostraErro("Erro ao atualizar o aluno!");
            }

        } catch (NumberFormatException e) {
                MostraErro("Id de aluno inválido!");
        }

    } 
    private static void eliminarAluno(){
        String IdStr=JOptionPane.showInputDialog(null,"Insira o número de aluno a eliminar","Eliminar aluno",
        JOptionPane.PLAIN_MESSAGE);

        if(IdStr==null) return;   
        
        try {
            int Id=Integer.parseInt(IdStr);
            Aluno A=Al.PesquisaPorId(Id);
            if(A==null){
                MostraAviso("Id de aluno não existe!");
                return;
            }
            int Confirmar=JOptionPane.showConfirmDialog(null, 
            "Confirmar a eliminação do aluno?\n\n"+
            "Id:"+A.getId()+
            "\nNome:"+A.getNome()+
            "\nEmail:"+A.getEmail()+
            "\nTelefone:"+A.getTelefone(),"Eliminar aluno",JOptionPane.YES_NO_OPTION, JOptionPane.WARNING_MESSAGE);

            if(Confirmar==JOptionPane.YES_OPTION){
                boolean Ok=Al.EliminarAluno(Id);
                if(Ok){
                    MostraAviso("Aluno eliminado!");
                }
                else{
                    MostraErro("Erro ao eliminar o aluno!");
                }
            }

        } catch (NumberFormatException e) {
            MostraErro("Id de aluno inválido");
        }


    }  
    private static void MostraAviso(String Mensagem){
        JOptionPane.showMessageDialog(null, Mensagem,"Aviso",JOptionPane.INFORMATION_MESSAGE);
    }   
   private static void MostraErro(String Mensagem){
        JOptionPane.showMessageDialog(null, Mensagem,"Erro",JOptionPane.ERROR_MESSAGE);
    }            
}
