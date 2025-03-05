using System;

namespace _03ExEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciar objeto da classe Aluno
            Aluno a = new Aluno();
            a.nome = "Juvenal";
            a.nota1 = 5;
            a.nota2 = 7;
            a.mensagem();

        }
    }
}