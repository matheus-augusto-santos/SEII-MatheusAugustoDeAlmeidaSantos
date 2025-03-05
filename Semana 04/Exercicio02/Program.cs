using System;

namespace _Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciar um objeto
            Pessoa obj = new Pessoa();
            obj.Nome = "Matheus";
            obj.idade = 23;
            obj.mensagem();
            
        }
    }
}