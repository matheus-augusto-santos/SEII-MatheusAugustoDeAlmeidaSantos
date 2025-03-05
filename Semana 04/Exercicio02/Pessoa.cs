using System;

class Pessoa
{
    // Atributos
    public string Nome;
    public int idade;

    // Métodos
    public void mensagem()
    {
        Console.WriteLine("Olá " + Nome + "você tem " + idade + " anos");
    }
}