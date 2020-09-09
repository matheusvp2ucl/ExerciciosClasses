using System;

class MainClass {
  public static void Main (string[] args) {
    
    Pessoa matheus = new Pessoa();
    matheus.setNome("Matheus Oliveira");
    matheus.setIdade(10);
    matheus.setPeso(70);
    matheus.setAltura(1.50);
    matheus.crescer();

    Console.WriteLine( matheus.getNome() );
    Console.WriteLine( matheus.getIdade() );
    Console.WriteLine( matheus.getPeso() );
    Console.WriteLine( matheus.getAltura() );

  }
}