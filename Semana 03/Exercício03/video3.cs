using System;
using System.IO;

namespace CSCourse
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] documentos = {"Documento 1.", "Documento 2."};

            string nomeDoArquivo = "Documentos.txt";

            File.WriteAllLines(nomeDoArquivo, documentos);
            
            Console.WriteLine("Arquivo criado com sucesso!");

            Console.ReadKey(true);
        }
    }
}