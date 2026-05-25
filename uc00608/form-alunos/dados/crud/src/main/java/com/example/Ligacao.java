package com.example;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class Ligacao {
    private static final String Url = "jdbc:mysql://localhost:3306/bdcrud?useTimezone=true&serverTimezone=UTC";
/*     private static final String Utilizador = "root";
    private static final String Password = "12345678"; */

    public static Connection ObterLigacao() throws SQLException {
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            return(DriverManager.getConnection(Url));    
        } catch (ClassNotFoundException e) {
            throw new SQLException("Driver não encontrado.");
        }
    }
}
