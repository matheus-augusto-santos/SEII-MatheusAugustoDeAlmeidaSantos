using System;

class Pessoa
{
    // Método 1
    public void apresentar()
    {
        Console.WriteLine("Olá !!");
    }

    // Método 2
    public void apresentar(string nome)
    {
        Console.WriteLine("Olá "+nome);
    }

    // Método 3
    public void apresentar(string nome, int idade)
    {
        Console.WriteLine("Olá " + nome + " voce tem " + idade + " anos");
    }

}