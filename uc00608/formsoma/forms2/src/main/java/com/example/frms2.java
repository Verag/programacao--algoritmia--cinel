package com.example;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class frms2 extends JFrame implements ActionListener {

    JLabel lbl_numero1, lbl_numero2, lbl_resultado;
    JTextField txt_numero1, txt_numero2;
    JButton btn_calcular, btn_cancelar;

    public frms2() {

        // titulo do form
        setTitle("Soma de 2 números");

        // layout do form
        setLayout(new GridLayout(4, 2, 10, 10));

        // Criar os componentes
        lbl_numero1 = new JLabel("Digite o 1º número:");
        txt_numero1 = new JTextField();

        lbl_numero2 = new JLabel("Digite o 2º número:");
        txt_numero2 = new JTextField();

        btn_calcular = new JButton("Somar");

        btn_cancelar = new JButton("Cancelar");

        lbl_resultado = new JLabel("Soma: ");

       
        // Adicionar componentes ao form
        add(lbl_numero1);
        add(txt_numero1);

        add(lbl_numero2);
        add(txt_numero2);

        add(btn_calcular);
        add(btn_cancelar);
        add(new JLabel(""));

        add(lbl_resultado);

        // definições do form
        setSize(350, 200);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setLocationRelativeTo(null); // Center the frame
        setVisible(true);

        // adicionar actionlistener
        btn_calcular.addActionListener(this);
        btn_cancelar.addActionListener(this);
        
    }
    @Override
    public void actionPerformed(ActionEvent e){
        if(e.getSource()==btn_calcular){
            try {
                int N1=Integer.parseInt(txt_numero1.getText());
                int N2=Integer.parseInt(txt_numero2.getText());
                lbl_resultado.setText("Soma:"+(N1+N2));
            } catch (Exception ex) {
                JOptionPane.showMessageDialog(null,"Deve digitar apenas números","Erro",JOptionPane.ERROR_MESSAGE);
            }
        }
        else if (e.getSource()==btn_cancelar){
            txt_numero1.setText("");
            txt_numero2.setText("");
            lbl_resultado.setText("");
        }
    }
   
    public static void main(String[] args) {
        new frms2();
    }

}