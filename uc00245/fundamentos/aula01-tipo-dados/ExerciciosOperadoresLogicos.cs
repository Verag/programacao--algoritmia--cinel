using System;
 
namespace Fundamentos01;
 
/// <summary>
/// 🔗 SUMÁRIO DOS EXERCÍCIOS DE OPERADORES LÓGICOS
/// ===============================================
///
/// Exercício 1: Operador AND (&&) - "E"
/// - Ambas as condições devem ser verdadeiras
/// - Exemplo: podeDirigir = temIdade E temCarta
/// - Se uma for falsa, o resultado é falso
///
/// Exercício 2: Operador OR (||) - "OU"
/// - Pelo menos uma condição deve ser verdadeira
/// - Exemplo: acessoPermitido = estaLogado OU ehAdmin
/// - Se ambas forem falsas, o resultado é falso
///
/// Exercício 3: Operador NOT (!) - "NÃO"
/// - Inverte o valor booleano
/// - Exemplo: !true = false, !false = true
/// - Útil para negar uma condição
///
/// Demonstração adicional:
/// - Combinações de operadores lógicos
/// - Tabelas verdade do AND (&&)
/// - Tabelas verdade do OR (||)
/// </summary>
 
/// SAIDA na Tela  ou Resultado esperado
 
 
 
 
 
 
 
public class AlunoOperadoresLogicos
{
  public void Executar()
  {
    Console.WriteLine("\n🔗 2. EXERCÍCIOS DE OPERADORES LÓGICOS");
    Console.WriteLine("====================================\n");
 
    // ===================================================
    // EXERCÍCIO 1: Operador AND (&&)
    // ===================================================
    // 👉 O QUE FAZER:
    // 1. Criar duas variáveis booleanas (true/false)
    //1A. Criar outra variavel que receberá os valores Ex:     bool podeDirigir = temIdade && temCarta; // true && false = false
    // 2. Usar o operador && (AND)
    // 3. Mostrar o resultado no console
    //
    // 💡 Regra:
    // AND (&&) só retorna TRUE se TODAS as condições forem TRUE
    // OBS: Use a Interpolação dentro do Console.WriteLine(?) para testar e passar os valores das Variaveis {...}
    Console.WriteLine("📝 Exercício 1: Operador AND (&&)");

    bool temIdade = true; // A pessoa tem idade suficiente para dirigir
    bool temCarta = false; // A pessoa não tem carta de condução

    bool podeDirigir = temIdade && temCarta; // true && false = false

    Console.WriteLine($"Tem idade? {temIdade}");
    Console.WriteLine($"Tem carta? {temCarta}");
    Console.WriteLine($"Pode dirigir? ({temIdade} && {temCarta}) = {podeDirigir}");
    
 
    /**
    SAIDA na Tela  ou Resultado esperado
�   Exercício 1: Operador AND (&&)
    Tem idade? True
    Tem carta? False
     Pode dirigir? (True && False) = False
    */
 
 
 
    // ===================================================
    // EXERCÍCIO 2: Operador OR (||)
    // ===================================================
    // 👉 O QUE FAZER:
    // 1. Criar duas variáveis booleanas
    // 1A. Criar outra variavel que RECEBERÁ os valores das outras 2 Ex:  bool acessoPermitido = estaLogado || ehAdmin;
    // 2. Usar o operador || (OR)
    // 3. Mostrar o resultado
    //
    // 💡 Regra:
    // OR (||) retorna TRUE se PELO MENOS UMA condição for TRUE
    // OBS: Use a Interpolação dentro do Console.WriteLine(?) para testar e passar os valores das Variaveis {...}
 
    Console.WriteLine("📝 Exercício 2: Operador OR (||)");

    bool estaLogado = false; // O utilizador não está logado
    bool ehAdmin = true; // O utilizador é um administrador
    bool acessoPermitido = estaLogado || ehAdmin; // false || true = true
    Console.WriteLine($"Está logado? {estaLogado}");
    Console.WriteLine($"É admin? {ehAdmin}");
    Console.WriteLine($"Acesso permitido? ({estaLogado} || {ehAdmin}) = {acessoPermitido}");

    /**
     SAIDA na Tela  ou Resultado esperado
   � Exercício 2: Operador OR (||)
    Está logado? False
    É admin? True
    Acesso permitido? (False || True) = True
    */
 
 
 
 
 
 
    // ===================================================
    // EXERCÍCIO 3: Operador NOT (!)
    // ===================================================
    // 👉 O QUE FAZER:
    // 1. Criar uma variável booleana
    // 2. Usar o operador ! (NOT)
    // 3. Mostrar o valor original e o invertido
    //
    // 💡 Regra:
    // NOT (!) inverte o valor:
    // true → false
    // false → true
    // OBS: Use a Interpolação dentro do Console.WriteLine(?) para testar e passar os valores das Variaveis {...}
    Console.WriteLine("📝 Exercício 3: Operador NOT (!)");

    bool valorOriginal = true; // Valor original
    bool valorInvertido = !valorOriginal; // Invertendo o valor original
    Console.WriteLine($"Valor original: {valorOriginal}");
    Console.WriteLine($"Valor invertido: {valorInvertido}");
 
    /**SAIDA na Tela  ou Resultado esperado
     � Exercício 3: Operador NOT (!)
     Valor original: True
     Valor invertido: False = False
 
    */
 
 
 
    // ===================================================
    // EXERCÍCIO 4: Combinação de operadores
    // ===================================================
    // 👉 O QUE FAZER:
    // 1. Criar 3 variáveis booleanas
    // 2. Combinar AND (&&) e OR (||)
    // 3. Usar parênteses para controlar a lógica
    // 💡 Regra:
    // Parênteses definem a ordem da avaliação
    // OBS: Use a Interpolação dentro do Console.WriteLine(?) para testar e passar os valores das Variaveis {...}
 
    Console.WriteLine("📝 Exercício 4: Combinação de operadores");

    bool temEntrada = true; // A pessoa tem entrada para o evento
    bool temConvite = false; // A pessoa não tem convite para o evento
    bool ehVIP = true; // A pessoa é VIP

    bool podeEntrar = (temEntrada || temConvite) && ehVIP; // (true || false) && true = true
 
    /**SAIDA na Tela  ou Resultado esperado
   � Exercício 4: Combinação de operadores
   Tem entrada? True
   Tem convite? False
    É VIP? True
    Pode entrar? ((True || False) && True) = True
    */
 
 
 
    // ===================================================
    // EXERCÍCIO 5: Tabela Verdade (Prática)
    // ===================================================
    // 👉 O QUE FAZER:
    // 1. Testar todas as combinações possíveis
    // 2. Observar os resultados dos operadores
    //
    // 💡 Objetivo:
    // Entender completamente como os operadores funcionam
    // OBS: Use a Interpolação dentro do Console.WriteLine(?) para testar e passar os valores das Variaveis {...}
    Console.WriteLine("📊 Tabela verdade do operador AND (&&):");


    bool a, b;

    a = true; b = true;
    Console.WriteLine($"{a} && {b} = {a && b}");

    a = true; b = false;
    Console.WriteLine($"{a} && {b} = {a && b}");

    a = false; b = true;
    Console.WriteLine($"{a} && {b} = {a && b}");

    a = false; b = false;
    Console.WriteLine($"{a} && {b} = {a && b}");

    /**SAIDA na Tela  ou Resultado esperado
 
   � Tabela verdade do operador AND (&&):
    true && true = True
    true && false = False
    false && true = False
    false && false = False
    */


    Console.WriteLine("\n📊 Tabela verdade do operador OR (||):");

    a = true; b = true;
    Console.WriteLine($"{a} || {b} = {a || b}");

    a = true; b = false;
    Console.WriteLine($"{a} || {b} = {a || b}");

    a = false; b = true;
    Console.WriteLine($"{a} || {b} = {a || b}");

    a = false; b = false;
    Console.WriteLine($"{a} || {b} = {a || b}");

    /*  � Tabela verdade do operador OR (||):
      true || true = True
      true || false = True
      false || true = True
      false || false = False
   */
 
  }
 
}
 