using System;

class MainClass {
  public static void Main (string[] args) {
    
    Pessoa matheus = new Pessoa();
    matheus.setNome("Matheus Oliveira");
    Console.WriteLine( matheus.getNome() );

  }
}