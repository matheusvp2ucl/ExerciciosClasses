using System;

class MainClass {
  public static void Main (string[] args) {
    
    Pessoa matheus = new Pessoa();
    matheus.setNome("Matheus Oliveira");
    matheus.setPeso(70);
    matheus.engordar();

    Console.WriteLine( matheus.getNome() );
    Console.WriteLine( matheus.getPeso() );

  }
}