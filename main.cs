using System;

class Program {
  public static void Main (string[] args) {
    
Double num1;
String celsius;

  Console.Write("Digite a temperatura  fahrenheit a ser comvertida em celsius: ");
  
    celsius=Console.ReadLine();  
    num1=Double.Parse(celsius);
    
    num1 = (num1-32)*(5.0/9.0);

    Console.Write("O valor comvertido é: " +num1);
  }
}