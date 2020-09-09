class Pessoa {

  private string nome;
  private int idade;
  private double peso;
  private double altura;

  public string getNome(){
    return nome;
  }

  public void setNome(string value){
    nome = value;
  }
  
  public int getIdade(){
    return idade;
  }

  public void setIdade(int value){
    idade = value;
  }
  
  public double getPeso(){
    return peso;
  }

  public void setPeso(double value){
    peso = value;
  }
  
  public double getAltura(){
    return altura;
  }

  public void setAltura(double value){
    altura = value;
  }

  public void envelhercer(){
    if( idade < 21 ){
      crescer();
    }
    idade += 1;
  }

  public void engordar(){
    peso += 1;
  }

  public void emagrecer(){
    peso -= 1;
  }

  public void crescer(){
    altura += 0.5;
  }


}